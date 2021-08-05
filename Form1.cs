using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoDeRolPorTurnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            Form2 segundoFormulario = new Form2();
            segundoFormulario.ShowDialog();
            
        }

        private void btnUltCpn_Click(object sender, EventArgs e)
        {
            if (File.Exists("rankingHistorico.json"))
            {
                StringBuilder ranking = new StringBuilder();
                StreamReader reader = new StreamReader("rankingHistorico.json");
                string jsonRead = reader.ReadToEnd();
                Participantes datosR = JsonSerializer.Deserialize<Participantes>(jsonRead);                

                ranking.Append("Ultimo ganador: \nFecha: " + datosR.Fecha + "\nCampeón: \n" + datosR.Ganador + "\n\n");

                MessageBox.Show(ranking.ToString());

                reader.Close();
            }
            else
            {
                MessageBox.Show("Primero debe jugar una partida");
            }
        }
    }
}
