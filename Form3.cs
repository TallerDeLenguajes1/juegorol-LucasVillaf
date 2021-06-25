using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JuegoDeRolPorTurnos
{
    public partial class Form3 : Form
    {
        List<Personaje> ListadoDePersonajes2 = new List<Personaje>();
        public Form3(List<Personaje> ListadoDePersonajes)
        {
            InitializeComponent();
            ListadoDePersonajes2 = ListadoDePersonajes;
        }

        Personaje nuevoPJ = new Personaje();
        FabricaDePersonajes stats = new FabricaDePersonajes();        

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBoxClase.Items.Add(TipoDeClase.Orco);
            comboBoxClase.Items.Add(TipoDeClase.Humano);
            comboBoxClase.Items.Add(TipoDeClase.Enano);
            comboBoxClase.Items.Add(TipoDeClase.Elfo);
            comboBoxClase.Items.Add(TipoDeClase.ElfoOscuro);
        }
        private void txtBoxNombrePj_TextChanged(object sender, EventArgs e) 
        {
            nuevoPJ.Nombre = txtBoxNombrePj.Text;
        }

        private void txtApodoPj_TextChanged(object sender, EventArgs e)
        {
            nuevoPJ.Apodo = txtApodoPj.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            nuevoPJ.FechadeNacimiento = dateTimePicker1.Value;
            nuevoPJ.Edad = DateTime.Now.Year - dateTimePicker1.Value.Year; // cálculo de edad, resta de año y año de nacimiento
        }

        private void comboBoxClase_SelectedIndexChanged(object sender, EventArgs e)
        {
            nuevoPJ.Clase = (TipoDeClase)comboBoxClase.SelectedItem;
            stats.StatsDeLaClase(nuevoPJ);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtBoxNombrePj.Text == "" || txtBoxNombrePj.Text == "" || comboBoxClase.SelectedIndex.ToString() == "")
            {
                MessageBox.Show("Ingrese los datos obligatorios");
            }
            else
            {
                ListadoDePersonajes2.Add(nuevoPJ);
                Form4 cuartoFormulario = new Form4(ListadoDePersonajes2);
                cuartoFormulario.ShowDialog();
            }
        }
    }
}
