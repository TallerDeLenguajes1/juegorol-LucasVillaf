using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JuegoDeRolPorTurnos
{
    public partial class Form5 : Form
    {
        List<Personaje> ListadoDePersonajes4 = new List<Personaje>();
        FabricaDePersonajes OponenteNuevo = new FabricaDePersonajes();
        public Form5(List<Personaje> ListadoDePersonajes)
        {
            InitializeComponent();
            ListadoDePersonajes4 = ListadoDePersonajes;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("4");
            comboBox1.Items.Add("5");
            comboBox1.Items.Add("6");
            comboBox1.Items.Add("7");

            lblSuLuchador.Text = "Su luchador elegido es: " + ListadoDePersonajes4[0].Nombre.ToString() + " " 
                                + ListadoDePersonajes4[0].Apodo.ToString() + ", " + ListadoDePersonajes4[0].Clase;
        }     


        private void btnPelear_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem)
            {
                case "1":
                    CrearLuchadoresYAñadirALista(1, ListadoDePersonajes4);
                    break;
                case "2":
                    CrearLuchadoresYAñadirALista(2, ListadoDePersonajes4);
                    break;
                case "3":
                    CrearLuchadoresYAñadirALista(3, ListadoDePersonajes4);
                    break;
                case "4":
                    CrearLuchadoresYAñadirALista(4, ListadoDePersonajes4);
                    break;
                case "5":
                    CrearLuchadoresYAñadirALista(5, ListadoDePersonajes4);
                    break;
                case "6":
                    CrearLuchadoresYAñadirALista(6, ListadoDePersonajes4);
                    break;
                case "7":
                    CrearLuchadoresYAñadirALista(7, ListadoDePersonajes4);
                    break;
            }

            Form6 sextoFormulario = new Form6(ListadoDePersonajes4);
            sextoFormulario.ShowDialog();

        }

        public void CrearLuchadoresYAñadirALista (int cantidad, List<Personaje> ListaDePersonajes)
        {
            for (int i=0; i<cantidad; i++)
            {
                Personaje Luchador = new Personaje();
                Luchador = OponenteNuevo.CrearPersonajePorDefecto();
                ListadoDePersonajes4.Add(Luchador);
            }
        }
    }
}
