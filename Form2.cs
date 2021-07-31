using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace JuegoDeRolPorTurnos
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        FabricaDePersonajes PersonajeRandom = new FabricaDePersonajes();
        List<Personaje> ListadoDePersonajes = new List<Personaje>(); 

        private void btnAleatorio_Click(object sender, EventArgs e) //botón que crea un pj de manera aleatoria
        {
            Personaje nuevoPersonaje = new Personaje();
            nuevoPersonaje = PersonajeRandom.CrearPersonajePorDefecto();
            ListadoDePersonajes.Add(nuevoPersonaje);
            Form4 cuartoFormulario = new Form4(ListadoDePersonajes);
            cuartoFormulario.ShowDialog();            
        }

        private void btnPersonalizar_Click(object sender, EventArgs e) //botón que crea un pj de manera personalizada
        {
            Form3 tercerFormulario = new Form3(ListadoDePersonajes);
            tercerFormulario.ShowDialog();
            
        }
    }
}
