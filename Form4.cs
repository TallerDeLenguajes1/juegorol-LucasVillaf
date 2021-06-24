using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JuegoDeRolPorTurnos
{
    public partial class Form4 : Form
    {
        List<Personaje> ListadoDePersonajes3 = new List<Personaje>();
        public Form4(List<Personaje> ListadoDePersonajes)
        {
            InitializeComponent();
            ListadoDePersonajes3 = ListadoDePersonajes;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            imgElfa.SendToBack();
            imgOrco.SendToBack();
            imgEnano.SendToBack();
            imgHumano.SendToBack();
            imgElfaOsc.SendToBack();
            lblNombreElegido.Text = "Nombre: " + ListadoDePersonajes3[0].Nombre;
            lblApodoEscodigo.Text = "Apodo: " + ListadoDePersonajes3[0].Apodo;
            lblClaseEscogida.Text = "Clase: " + ListadoDePersonajes3[0].Clase.ToString();
            lblFechaEscogida.Text = "Fecha de nacimiento: " + ListadoDePersonajes3[0].FechadeNacimiento.ToString("dd/MM/yyyy");
            lblEdadEscogida.Text = "Edad: " + ListadoDePersonajes3[0].Edad.ToString();
            lblNivel.Text = "Nivel: " + ListadoDePersonajes3[0].Nivel.ToString();
            lblVelocidad.Text = "Velocida: " + ListadoDePersonajes3[0].Velocidad.ToString();
            lblDestreza.Text = "Destreza: " + ListadoDePersonajes3[0].Destreza.ToString();
            lblFuerza.Text = "Fuerza: " + ListadoDePersonajes3[0].Fuerza.ToString();
            lblArmadura.Text = "Armadura: " + ListadoDePersonajes3[0].Armadura.ToString();

            CargarImagenDelPersonajeCreado();

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            ListadoDePersonajes3.Clear();
            Form2 segundoFormulario = new Form2();
            segundoFormulario.ShowDialog();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Form5 quintoFormulario = new Form5(ListadoDePersonajes3);
            quintoFormulario.ShowDialog();
        }

        private void CargarImagenDelPersonajeCreado()
        {
            switch (ListadoDePersonajes3[0].Clase)
            {
                case (TipoDeClase)0:
                    imgOrco.Visible = true;
                    break;
                case (TipoDeClase)1:
                    imgHumano.Visible = true;
                    break;
                case (TipoDeClase)2:
                    imgEnano.Visible = true;
                    break;
                case (TipoDeClase)3:
                    imgElfa.Visible = true;
                    break;
                case (TipoDeClase)4:
                    imgElfaOsc.Visible = true;
                    break;
            }
        }
    }
}
