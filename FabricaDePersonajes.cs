//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JuegoDeRolPorTurnos
{
    class FabricaDePersonajes

    {        
        public Personaje CrearPersonajePorDefecto()
        {
            Random random = new Random();      
            Personaje nuevoPersonaje = new Personaje();
            List<dota2> valoresObtenidos = new List<dota2>();

            valoresObtenidos = ObtenerDatos();
            List<string> ListaDeNombres = new List<string>();

            foreach (var item in valoresObtenidos)
            {
                ListaDeNombres.Add(item.LocalizedName);
            }
            

            string[] Nombres = { "Lucas", "Juan", "Pedro", "Alejandro", "Lucia", "Mariela", "José", "Simón", "Carmen" };
            string[] Apodos = { "Grande", "Matador", "Valiente", "Veloz", "Sanguinario", "Increible", "Degollador", "Malo", "Torpe" };
            int AñoActual = DateTime.Now.Year;


            nuevoPersonaje.Clase = GenerarClaseAleatoria(random);
            nuevoPersonaje.Nombre = Nombres[random.Next(0, 9)];
            //nuevoPersonaje.Apodo = Apodos[random.Next(0, 9)];
            nuevoPersonaje.Apodo = ListaDeNombres[random.Next(0, ListaDeNombres.Count)];
            
            nuevoPersonaje.FechadeNacimiento = GenerarFechaAleatoria(random);
            nuevoPersonaje.Edad = AñoActual - nuevoPersonaje.FechadeNacimiento.Year;
            StatsDeLaClase(nuevoPersonaje);            
            
            return nuevoPersonaje;
        }
        public void StatsDeLaClase(Personaje nuevoPersonaje)
        {
            switch (nuevoPersonaje.Clase)
            {   //stats de cada clase - pueden aumentar al subir de lvl
                case (TipoDeClase)0: //Orco
                    nuevoPersonaje.Velocidad = 3;      //1 a 10
                    nuevoPersonaje.Destreza = 2;       //1 a 5
                    nuevoPersonaje.Fuerza = 9;         //1 a 10
                    nuevoPersonaje.Armadura = 6;       //1 a 10
                    break;
                case (TipoDeClase)1: //Humano
                    nuevoPersonaje.Velocidad = 6;      //1 a 10
                    nuevoPersonaje.Destreza = 3;       //1 a 5
                    nuevoPersonaje.Fuerza = 7;         //1 a 10
                    nuevoPersonaje.Armadura = 6;       //1 a 10
                    break;
                case (TipoDeClase)2: //Enano
                    nuevoPersonaje.Velocidad = 4;      //1 a 10
                    nuevoPersonaje.Destreza = 2;       //1 a 5
                    nuevoPersonaje.Fuerza = 8;         //1 a 10
                    nuevoPersonaje.Armadura = 6;       //1 a 10
                    break;
                case (TipoDeClase)3: //Elfo
                    nuevoPersonaje.Velocidad = 7;      //1 a 10
                    nuevoPersonaje.Destreza = 4;       //1 a 5
                    nuevoPersonaje.Fuerza = 5;         //1 a 10
                    nuevoPersonaje.Armadura = 4;       //1 a 10
                    break;
                case (TipoDeClase)4: //Elfo oscuro
                    nuevoPersonaje.Velocidad = 8;      //1 a 10
                    nuevoPersonaje.Destreza = 3;       //1 a 5
                    nuevoPersonaje.Fuerza = 6;         //1 a 10
                    nuevoPersonaje.Armadura = 3;       //1 a 10
                    break;
            }
        }

        public DateTime GenerarFechaAleatoria(Random random)
        {
            DateTime start = new DateTime(1741, 1, 1);
            int rango = (DateTime.Today - start).Days;
            return (start.AddDays(random.Next(rango)));
        }

        public TipoDeClase GenerarClaseAleatoria (Random random)
        {
            var value = Enum.GetValues(typeof(TipoDeClase));
            return((TipoDeClase)value.GetValue(random.Next(value.Length)));
        }

        private static List<dota2> ObtenerDatos()
        {
            var url = $"https://api.opendota.com/api/heroes";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "aplication/json";
            request.Accept = "aplication/json";
            //dota2 DotaInfo;
            List<dota2> DotaInfo;
            DotaInfo = null;

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader != null)
                        {
                            using (StreamReader objReader = new StreamReader(strReader))
                            {
                                string responseBody = objReader.ReadToEnd();
                                //DotaInfo = JsonConvert.DeserializeObject<List<dota2>>(responseBody);
                                DotaInfo = JsonSerializer.Deserialize<List<dota2>>(responseBody);                            
                            }
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                // Handle error
            }
            return DotaInfo;
        }

        // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
        public class dota2
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("localized_name")]
            public string LocalizedName { get; set; }

            [JsonPropertyName("primary_attr")]
            public string PrimaryAttr { get; set; }

            [JsonPropertyName("attack_type")]
            public string AttackType { get; set; }

            [JsonPropertyName("roles")]
            public List<string> Roles { get; set; }

            [JsonPropertyName("legs")]
            public int Legs { get; set; }
        }
        

    }
}
