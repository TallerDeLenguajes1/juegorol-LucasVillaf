using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JuegoDeRolPorTurnos
{
    public partial class Form6 : Form
    {
        List<Personaje> ListaDePersonajes5 = new List<Personaje>();
        List<Personaje> Pelea = new List<Personaje>();
        Random rand = new Random();
        int[] dado = new int[2];
        int cant1 = 0, cant2 = 0;
        public Form6(List<Personaje> ListaDePersonajes)
        {
            InitializeComponent();
            ListaDePersonajes5 = ListaDePersonajes;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            MostrarLuchadores(ListaDePersonajes5);
        }

        public void MostrarLuchadores (List<Personaje> ListaDePeleadores)
        {
            foreach(Personaje Peleador in ListaDePeleadores)
            {
                listBoxLuchadores.Items.Add(Peleador.Nombre + " " + Peleador.Apodo + ", " + Peleador.Clase);
            }
        }

        private void btnElegir_Click(object sender, EventArgs e)
        {
            int index = listBoxLuchadores.SelectedIndex;
            if(ListaDePersonajes5.Count>=2)
            {   
                if(Pelea.Count<=2)
                {
                    Pelea.Add(ListaDePersonajes5[index]);
                }
                else
                {
                    btnElegir.Enabled = false;
                    btnCargar.Enabled = true;
                }
               
            }
            else
            {
                btnCargar.Enabled = false;
                btnElegir.Enabled = false;
            }
        }

        private void btnCargar_Click_1(object sender, EventArgs e)
        {
            CargarDatos(Pelea);
            label4.Visible = true;
            btnDado.Visible = true;
            btnDado.Enabled = true;
            btnDado2.Visible = true;            
            btnPelear.Visible = true;
        }

        public void CargarDatos (List<Personaje> Pelea)
        {
            // primer luchador
            lblPrimerLuchador.Text = Pelea[0].Nombre + " " + Pelea[0].Apodo;
            lblClase1.Text = "Clase: " + Pelea[0].Clase.ToString();
            lblNivel1.Text = "Nivel: " + Pelea[0].Nivel.ToString();
            lblVelocidad1.Text = "Velocidad: " + Pelea[0].Velocidad.ToString();
            lblDestreza1.Text = "Destreza: " + Pelea[0].Destreza.ToString();
            lblFuerza1.Text = "Fuerza: " + Pelea[0].Fuerza.ToString();
            lblArmadura.Text = "Armadura: " + Pelea[0].Armadura.ToString();
            lblSalud1.Text = Pelea[0].Salud.ToString();
            if (Pelea[0].Salud > 0)
            {
                progressBar1.Value = Pelea[0].Salud;
            }
            else
            {
                progressBar1.Value = 0;
            }
            // segundo luchador
            lblSegundoLuchador.Text = Pelea[1].Nombre + " " + Pelea[1].Apodo;
            lblClase2.Text = "Clase: " + Pelea[1].Clase.ToString();
            lblNivel2.Text = "Nivel: " + Pelea[1].Nivel.ToString();
            lblVelocidad2.Text = "Velocidad: " + Pelea[1].Velocidad.ToString();
            lblDestreza2.Text = "Destreza: " + Pelea[1].Destreza.ToString();
            lblFuerza2.Text = "Fuerza: " + Pelea[1].Fuerza.ToString();
            lblArmadura2.Text = "Armadura: " + Pelea[1].Armadura.ToString();
            lblSalud2.Text = Pelea[1].Salud.ToString();
            if (Pelea[1].Salud > 0)
            {
                progressBar2.Value = Pelea[1].Salud;
            }
            else
            {
                progressBar2.Value = 0;
            }
        }

        public void LimpiarDatos ()
        {
            // primer luchador
            lblPrimerLuchador.Text = "Nombre:";
            lblClase1.Text = "Clase: ";
            lblNivel1.Text = "Nivel: ";
            lblVelocidad1.Text = "Velocidad: ";
            lblDestreza1.Text = "Destreza: ";
            lblFuerza1.Text = "Fuerza: ";
            lblArmadura.Text = "Armadura: ";
            lblSalud1.Text = 100.ToString();     
            progressBar1.Value = 100;

            // segundo luchador
            lblSegundoLuchador.Text = "Nombre:";
            lblClase2.Text = "Clase: ";
            lblNivel2.Text = "Nivel: ";
            lblVelocidad2.Text = "Velocidad: ";
            lblDestreza2.Text = "Destreza: ";
            lblFuerza2.Text = "Fuerza: ";
            lblArmadura2.Text = "Armadura: ";
            lblSalud2.Text = 100.ToString();
            progressBar2.Value = 100;
        }


        private void btnDado_Click_1(object sender, EventArgs e)
        {
            btnDado2.Enabled = false;
            dado[0] = rand.Next(1, 7);
            btnDado.Text = dado[0].ToString();
            btnDado2.Enabled = true;            
        }

        private void btnDado2_Click(object sender, EventArgs e)
        {
            dado[1] = rand.Next(1, 7);
            btnDado2.Text = dado[1].ToString();
            btnPelear.Enabled = true;            
        }

        public void QuienAtaca()
        {
            if(dado[0]>dado[1])
            {
                btnAtacar1.Enabled = true;
            }
            else if(dado[0] < dado[1])
            {
                btnAtacar2.Enabled = true;
            }
            else
            {
                btnAtacar1.Enabled = false;
                btnAtacar2.Enabled = false;                
            }
        }

        public void EliminarPerdedorDeLista(Personaje perdedor)
        {
            int indice = ListaDePersonajes5.IndexOf(perdedor);
            ListaDePersonajes5.Remove(ListaDePersonajes5[indice]);
            listBoxLuchadores.Items.RemoveAt(indice);
        }

        public void PeleadorGanador()
        {
            if(cant1 == 3 && cant2 == 3)
            {
                if (Pelea[0].Salud > Pelea[1].Salud)
                {
                    lblGanador.Text = Pelea[0].Nombre + " " + Pelea[0].Apodo + " es el GANADOR!";
                    Pelea[0].Salud = 100;
                    EliminarPerdedorDeLista(Pelea[1]);
                    Pelea.Clear();
                    //ListaDePersonajes5.Remove();
                    lblGanador.Visible = true;
                    btnAtacar1.Enabled = false;
                    btnAtacar2.Enabled = false;
                    lblSigpelea.Enabled = true;
                    lblSigpelea.Visible = true;
                }
                else
                {
                    lblGanador.Text = Pelea[1].Nombre + " " + Pelea[1].Apodo + " es el GANADOR!";
                    Pelea[1].Salud = 100;
                    EliminarPerdedorDeLista(Pelea[0]);
                    Pelea.Clear();
                    lblGanador.Visible = true;
                    btnAtacar1.Enabled = false;
                    btnAtacar2.Enabled = false;
                    lblSigpelea.Enabled = true;
                    lblSigpelea.Visible = true;
                }
            }            
            else
            {
                if (Pelea[1].Salud < 0 )
                {
                    lblGanador.Text = Pelea[0].Nombre + " " + Pelea[0].Apodo + " es el GANADOR!";
                    Pelea[0].Salud = 100;
                    EliminarPerdedorDeLista(Pelea[1]);
                    Pelea.Clear();
                    lblGanador.Visible = true;
                    btnAtacar1.Enabled = false;
                    btnAtacar2.Enabled = false;
                    lblSigpelea.Enabled = true;
                    lblSigpelea.Visible = true;
                }
                else if (Pelea[0].Salud < 0)
                {
                    lblGanador.Text = Pelea[1].Nombre + " " + Pelea[1].Apodo + " es el GANADOR!";
                    Pelea[1].Salud = 100;
                    EliminarPerdedorDeLista(Pelea[0]);
                    Pelea.Clear();
                    lblGanador.Visible = true;
                    btnAtacar1.Enabled = false;
                    btnAtacar2.Enabled = false;
                    lblSigpelea.Enabled = true;
                    lblSigpelea.Visible = true;
                }
            }
        }

        private void btnAtacar1_Click(object sender, EventArgs e)
        {
            Atacar(Pelea[0], Pelea[1]);
            CargarDatos(Pelea);
            //lblSalud2.Text = Pelea[1].Salud.ToString();
            btnAtacar2.Enabled = true;
            btnAtacar1.Enabled = false;
            cant1++;
            PeleadorGanador();
            if (cant1 == 3)
            {
                btnAtacar1.Enabled = false;
            }
        }

        private void btnAtacar2_Click(object sender, EventArgs e)
        {
            Atacar(Pelea[1], Pelea[0]);
            CargarDatos(Pelea);
            //lblSalud1.Text = Pelea[0].Salud.ToString();
            btnAtacar1.Enabled = true;
            btnAtacar2.Enabled = false;
            cant2++;
            PeleadorGanador();
            if (cant2 == 3)
            {
                btnAtacar1.Enabled = false;
            }
        }
        
        private void btnPelear_Click(object sender, EventArgs e)
        {
            QuienAtaca();
            
        }

        private void lblSigpelea_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
            cant1 = 0;
            cant2 = 0;
            btnDado.Text = "0";
            btnDado2.Text = "0";
            lblGanador.Visible = false;
            btnElegir.Enabled = true;
            btnCargar.Enabled = false;
        }

        public void Atacar(Personaje Ataca, Personaje Defiende)
        {
            float poderDeDisparo = Ataca.Destreza * Ataca.Fuerza * Ataca.Nivel;
            float efectividadDeDisparo = (rand.Next(1,100))/2; //modifique la Efectividad, divido el random en 2s
            float valorDeAtaque = poderDeDisparo * efectividadDeDisparo;
            float poderDeDefensa = Defiende.Armadura * Defiende.Velocidad;
            float maxDañoProv = 50000;
            float DañoProvocado = (((valorDeAtaque * efectividadDeDisparo) - poderDeDefensa)/maxDañoProv)*100;
            Defiende.Salud -= (int)DañoProvocado;            
        }
    }
}
