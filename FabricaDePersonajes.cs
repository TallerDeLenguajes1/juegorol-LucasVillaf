using System;
using System.Collections.Generic;
using System.Text;

namespace JuegoDeRolPorTurnos
{
    class FabricaDePersonajes

    {        
        public Personaje CrearPersonajePorDefecto()
        {
            Random random = new Random();      
            Personaje nuevoPersonaje = new Personaje();            
            string[] Nombres = { "Lucas", "Juan", "Pedro", "Alejandro", "Lucia", "Mariela", "José", "Simón", "Carmen" };
            string[] Apodos = { "Grande", "Matador", "Valiente", "Veloz", "Sanguinario", "Increible", "Degollador", "Malo", "Torpe" };
            int AñoActual = DateTime.Now.Year;

            nuevoPersonaje.Clase = GenerarClaseAleatoria(random);
            nuevoPersonaje.Nombre = Nombres[random.Next(0, 9)];
            nuevoPersonaje.Apodo = Apodos[random.Next(0, 9)];
            nuevoPersonaje.FechadeNacimiento = GenerarFechaAleatoria(random);
            nuevoPersonaje.Edad = AñoActual - nuevoPersonaje.FechadeNacimiento.Year;
            StatsDeLaClase(nuevoPersonaje);

            /*switch (nuevoPersonaje.Clase)
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
            }  */    
            
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
        
    
    }
}
