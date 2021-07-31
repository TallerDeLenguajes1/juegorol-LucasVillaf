using System;
using System.Collections.Generic;
using System.Text;

namespace JuegoDeRolPorTurnos
{
    public class Participantes
    {
        private DateTime fecha;
        private List<string> listaDeParticipantes = new List<string>();
        private string ganador;

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public List<string> ListaDeParticipantes { get => listaDeParticipantes; set => listaDeParticipantes = value; }
        public string Ganador { get => ganador; set => ganador = value; }
    }
}
