
namespace JuegoDeRolPorTurnos
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxLuchadores = new System.Windows.Forms.ListBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnElegir = new System.Windows.Forms.Button();
            this.lblPrimerLuchador = new System.Windows.Forms.Label();
            this.lblSegundoLuchador = new System.Windows.Forms.Label();
            this.lblClase1 = new System.Windows.Forms.Label();
            this.lblNivel1 = new System.Windows.Forms.Label();
            this.lblVelocidad1 = new System.Windows.Forms.Label();
            this.lblDestreza1 = new System.Windows.Forms.Label();
            this.lblFuerza1 = new System.Windows.Forms.Label();
            this.lblArmadura = new System.Windows.Forms.Label();
            this.lblArmadura2 = new System.Windows.Forms.Label();
            this.lblFuerza2 = new System.Windows.Forms.Label();
            this.lblDestreza2 = new System.Windows.Forms.Label();
            this.lblVelocidad2 = new System.Windows.Forms.Label();
            this.lblNivel2 = new System.Windows.Forms.Label();
            this.lblClase2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.lblSalud1 = new System.Windows.Forms.Label();
            this.lblSalud2 = new System.Windows.Forms.Label();
            this.btnAtacar1 = new System.Windows.Forms.Button();
            this.btnAtacar2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDado = new System.Windows.Forms.Button();
            this.btnDado2 = new System.Windows.Forms.Button();
            this.btnPelear = new System.Windows.Forms.Button();
            this.lblGanador = new System.Windows.Forms.Label();
            this.lblSigpelea = new System.Windows.Forms.Button();
            this.detallesBtn = new System.Windows.Forms.Button();
            this.gndHistBtn = new System.Windows.Forms.Button();
            this.salirBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(38, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elija dos luchadores";
            // 
            // listBoxLuchadores
            // 
            this.listBoxLuchadores.FormattingEnabled = true;
            this.listBoxLuchadores.ItemHeight = 15;
            this.listBoxLuchadores.Location = new System.Drawing.Point(38, 143);
            this.listBoxLuchadores.Name = "listBoxLuchadores";
            this.listBoxLuchadores.Size = new System.Drawing.Size(194, 154);
            this.listBoxLuchadores.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTitulo.Location = new System.Drawing.Point(323, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(299, 47);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Torneo de peleas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(403, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "¿Quién saldra victorioso?";
            // 
            // btnCargar
            // 
            this.btnCargar.Enabled = false;
            this.btnCargar.Location = new System.Drawing.Point(143, 303);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(89, 29);
            this.btnCargar.TabIndex = 4;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click_1);
            // 
            // btnElegir
            // 
            this.btnElegir.Location = new System.Drawing.Point(38, 303);
            this.btnElegir.Name = "btnElegir";
            this.btnElegir.Size = new System.Drawing.Size(89, 29);
            this.btnElegir.TabIndex = 5;
            this.btnElegir.Text = "Elegir";
            this.btnElegir.UseVisualStyleBackColor = true;
            this.btnElegir.Click += new System.EventHandler(this.btnElegir_Click);
            // 
            // lblPrimerLuchador
            // 
            this.lblPrimerLuchador.AutoSize = true;
            this.lblPrimerLuchador.BackColor = System.Drawing.Color.Transparent;
            this.lblPrimerLuchador.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrimerLuchador.Location = new System.Drawing.Point(267, 143);
            this.lblPrimerLuchador.Name = "lblPrimerLuchador";
            this.lblPrimerLuchador.Size = new System.Drawing.Size(121, 20);
            this.lblPrimerLuchador.TabIndex = 6;
            this.lblPrimerLuchador.Text = "Primer luchador";
            // 
            // lblSegundoLuchador
            // 
            this.lblSegundoLuchador.AutoSize = true;
            this.lblSegundoLuchador.BackColor = System.Drawing.Color.Transparent;
            this.lblSegundoLuchador.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSegundoLuchador.Location = new System.Drawing.Point(568, 143);
            this.lblSegundoLuchador.Name = "lblSegundoLuchador";
            this.lblSegundoLuchador.Size = new System.Drawing.Size(135, 20);
            this.lblSegundoLuchador.TabIndex = 7;
            this.lblSegundoLuchador.Text = "Segundo luchador";
            // 
            // lblClase1
            // 
            this.lblClase1.AutoSize = true;
            this.lblClase1.BackColor = System.Drawing.Color.Transparent;
            this.lblClase1.Location = new System.Drawing.Point(267, 190);
            this.lblClase1.Name = "lblClase1";
            this.lblClase1.Size = new System.Drawing.Size(41, 15);
            this.lblClase1.TabIndex = 9;
            this.lblClase1.Text = "Clase: ";
            // 
            // lblNivel1
            // 
            this.lblNivel1.AutoSize = true;
            this.lblNivel1.BackColor = System.Drawing.Color.Transparent;
            this.lblNivel1.Location = new System.Drawing.Point(267, 217);
            this.lblNivel1.Name = "lblNivel1";
            this.lblNivel1.Size = new System.Drawing.Size(40, 15);
            this.lblNivel1.TabIndex = 10;
            this.lblNivel1.Text = "Nivel: ";
            // 
            // lblVelocidad1
            // 
            this.lblVelocidad1.AutoSize = true;
            this.lblVelocidad1.BackColor = System.Drawing.Color.Transparent;
            this.lblVelocidad1.Location = new System.Drawing.Point(267, 244);
            this.lblVelocidad1.Name = "lblVelocidad1";
            this.lblVelocidad1.Size = new System.Drawing.Size(61, 15);
            this.lblVelocidad1.TabIndex = 11;
            this.lblVelocidad1.Text = "Velocidad:";
            // 
            // lblDestreza1
            // 
            this.lblDestreza1.AutoSize = true;
            this.lblDestreza1.BackColor = System.Drawing.Color.Transparent;
            this.lblDestreza1.Location = new System.Drawing.Point(267, 271);
            this.lblDestreza1.Name = "lblDestreza1";
            this.lblDestreza1.Size = new System.Drawing.Size(54, 15);
            this.lblDestreza1.TabIndex = 12;
            this.lblDestreza1.Text = "Destreza:";
            // 
            // lblFuerza1
            // 
            this.lblFuerza1.AutoSize = true;
            this.lblFuerza1.BackColor = System.Drawing.Color.Transparent;
            this.lblFuerza1.Location = new System.Drawing.Point(267, 298);
            this.lblFuerza1.Name = "lblFuerza1";
            this.lblFuerza1.Size = new System.Drawing.Size(44, 15);
            this.lblFuerza1.TabIndex = 13;
            this.lblFuerza1.Text = "Fuerza:";
            // 
            // lblArmadura
            // 
            this.lblArmadura.AutoSize = true;
            this.lblArmadura.BackColor = System.Drawing.Color.Transparent;
            this.lblArmadura.Location = new System.Drawing.Point(267, 325);
            this.lblArmadura.Name = "lblArmadura";
            this.lblArmadura.Size = new System.Drawing.Size(66, 15);
            this.lblArmadura.TabIndex = 14;
            this.lblArmadura.Text = "Armadura: ";
            // 
            // lblArmadura2
            // 
            this.lblArmadura2.AutoSize = true;
            this.lblArmadura2.BackColor = System.Drawing.Color.Transparent;
            this.lblArmadura2.Location = new System.Drawing.Point(568, 325);
            this.lblArmadura2.Name = "lblArmadura2";
            this.lblArmadura2.Size = new System.Drawing.Size(66, 15);
            this.lblArmadura2.TabIndex = 21;
            this.lblArmadura2.Text = "Armadura: ";
            // 
            // lblFuerza2
            // 
            this.lblFuerza2.AutoSize = true;
            this.lblFuerza2.BackColor = System.Drawing.Color.Transparent;
            this.lblFuerza2.Location = new System.Drawing.Point(568, 298);
            this.lblFuerza2.Name = "lblFuerza2";
            this.lblFuerza2.Size = new System.Drawing.Size(44, 15);
            this.lblFuerza2.TabIndex = 20;
            this.lblFuerza2.Text = "Fuerza:";
            // 
            // lblDestreza2
            // 
            this.lblDestreza2.AutoSize = true;
            this.lblDestreza2.BackColor = System.Drawing.Color.Transparent;
            this.lblDestreza2.Location = new System.Drawing.Point(568, 271);
            this.lblDestreza2.Name = "lblDestreza2";
            this.lblDestreza2.Size = new System.Drawing.Size(54, 15);
            this.lblDestreza2.TabIndex = 19;
            this.lblDestreza2.Text = "Destreza:";
            // 
            // lblVelocidad2
            // 
            this.lblVelocidad2.AutoSize = true;
            this.lblVelocidad2.BackColor = System.Drawing.Color.Transparent;
            this.lblVelocidad2.Location = new System.Drawing.Point(568, 244);
            this.lblVelocidad2.Name = "lblVelocidad2";
            this.lblVelocidad2.Size = new System.Drawing.Size(61, 15);
            this.lblVelocidad2.TabIndex = 18;
            this.lblVelocidad2.Text = "Velocidad:";
            // 
            // lblNivel2
            // 
            this.lblNivel2.AutoSize = true;
            this.lblNivel2.BackColor = System.Drawing.Color.Transparent;
            this.lblNivel2.Location = new System.Drawing.Point(568, 217);
            this.lblNivel2.Name = "lblNivel2";
            this.lblNivel2.Size = new System.Drawing.Size(40, 15);
            this.lblNivel2.TabIndex = 17;
            this.lblNivel2.Text = "Nivel: ";
            // 
            // lblClase2
            // 
            this.lblClase2.AutoSize = true;
            this.lblClase2.BackColor = System.Drawing.Color.Transparent;
            this.lblClase2.Location = new System.Drawing.Point(568, 190);
            this.lblClase2.Name = "lblClase2";
            this.lblClase2.Size = new System.Drawing.Size(41, 15);
            this.lblClase2.TabIndex = 16;
            this.lblClase2.Text = "Clase: ";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Red;
            this.progressBar1.Location = new System.Drawing.Point(267, 168);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(113, 15);
            this.progressBar1.TabIndex = 22;
            // 
            // progressBar2
            // 
            this.progressBar2.ForeColor = System.Drawing.Color.Red;
            this.progressBar2.Location = new System.Drawing.Point(568, 168);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(113, 15);
            this.progressBar2.TabIndex = 23;
            // 
            // lblSalud1
            // 
            this.lblSalud1.AutoSize = true;
            this.lblSalud1.BackColor = System.Drawing.Color.Transparent;
            this.lblSalud1.Location = new System.Drawing.Point(386, 168);
            this.lblSalud1.Name = "lblSalud1";
            this.lblSalud1.Size = new System.Drawing.Size(42, 15);
            this.lblSalud1.TabIndex = 24;
            this.lblSalud1.Text = "Salud1";
            // 
            // lblSalud2
            // 
            this.lblSalud2.AutoSize = true;
            this.lblSalud2.BackColor = System.Drawing.Color.Transparent;
            this.lblSalud2.Location = new System.Drawing.Point(687, 168);
            this.lblSalud2.Name = "lblSalud2";
            this.lblSalud2.Size = new System.Drawing.Size(42, 15);
            this.lblSalud2.TabIndex = 25;
            this.lblSalud2.Text = "Salud2";
            // 
            // btnAtacar1
            // 
            this.btnAtacar1.Enabled = false;
            this.btnAtacar1.Location = new System.Drawing.Point(267, 352);
            this.btnAtacar1.Name = "btnAtacar1";
            this.btnAtacar1.Size = new System.Drawing.Size(75, 23);
            this.btnAtacar1.TabIndex = 26;
            this.btnAtacar1.Text = "Atacar";
            this.btnAtacar1.UseVisualStyleBackColor = true;
            this.btnAtacar1.Click += new System.EventHandler(this.btnAtacar1_Click);
            // 
            // btnAtacar2
            // 
            this.btnAtacar2.Enabled = false;
            this.btnAtacar2.Location = new System.Drawing.Point(568, 352);
            this.btnAtacar2.Name = "btnAtacar2";
            this.btnAtacar2.Size = new System.Drawing.Size(75, 23);
            this.btnAtacar2.TabIndex = 27;
            this.btnAtacar2.Text = "Atacar";
            this.btnAtacar2.UseVisualStyleBackColor = true;
            this.btnAtacar2.Click += new System.EventHandler(this.btnAtacar2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(434, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Sortear salida";
            this.label4.Visible = false;
            // 
            // btnDado
            // 
            this.btnDado.Enabled = false;
            this.btnDado.Location = new System.Drawing.Point(442, 232);
            this.btnDado.Name = "btnDado";
            this.btnDado.Size = new System.Drawing.Size(27, 27);
            this.btnDado.TabIndex = 28;
            this.btnDado.Text = "0";
            this.btnDado.UseVisualStyleBackColor = true;
            this.btnDado.Visible = false;
            this.btnDado.Click += new System.EventHandler(this.btnDado_Click_1);
            // 
            // btnDado2
            // 
            this.btnDado2.Enabled = false;
            this.btnDado2.Location = new System.Drawing.Point(475, 232);
            this.btnDado2.Name = "btnDado2";
            this.btnDado2.Size = new System.Drawing.Size(27, 27);
            this.btnDado2.TabIndex = 30;
            this.btnDado2.Text = "0";
            this.btnDado2.UseVisualStyleBackColor = true;
            this.btnDado2.Visible = false;
            this.btnDado2.Click += new System.EventHandler(this.btnDado2_Click);
            // 
            // btnPelear
            // 
            this.btnPelear.Enabled = false;
            this.btnPelear.Location = new System.Drawing.Point(434, 267);
            this.btnPelear.Name = "btnPelear";
            this.btnPelear.Size = new System.Drawing.Size(77, 30);
            this.btnPelear.TabIndex = 31;
            this.btnPelear.Text = "Pelear!";
            this.btnPelear.UseVisualStyleBackColor = true;
            this.btnPelear.Visible = false;
            this.btnPelear.Click += new System.EventHandler(this.btnPelear_Click);
            // 
            // lblGanador
            // 
            this.lblGanador.AutoSize = true;
            this.lblGanador.BackColor = System.Drawing.Color.Transparent;
            this.lblGanador.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGanador.ForeColor = System.Drawing.Color.Black;
            this.lblGanador.Location = new System.Drawing.Point(366, 404);
            this.lblGanador.Name = "lblGanador";
            this.lblGanador.Size = new System.Drawing.Size(92, 21);
            this.lblGanador.TabIndex = 32;
            this.lblGanador.Text = "GANADOR:";
            this.lblGanador.Visible = false;
            // 
            // lblSigpelea
            // 
            this.lblSigpelea.Enabled = false;
            this.lblSigpelea.Location = new System.Drawing.Point(386, 437);
            this.lblSigpelea.Name = "lblSigpelea";
            this.lblSigpelea.Size = new System.Drawing.Size(192, 32);
            this.lblSigpelea.TabIndex = 33;
            this.lblSigpelea.Text = "Siguiente pelea";
            this.lblSigpelea.UseVisualStyleBackColor = true;
            this.lblSigpelea.Visible = false;
            this.lblSigpelea.Click += new System.EventHandler(this.lblSigpelea_Click);
            // 
            // detallesBtn
            // 
            this.detallesBtn.Enabled = false;
            this.detallesBtn.Location = new System.Drawing.Point(38, 338);
            this.detallesBtn.Name = "detallesBtn";
            this.detallesBtn.Size = new System.Drawing.Size(193, 27);
            this.detallesBtn.TabIndex = 34;
            this.detallesBtn.Text = "Detalles del torneo";
            this.detallesBtn.UseVisualStyleBackColor = true;
            this.detallesBtn.Visible = false;
            this.detallesBtn.Click += new System.EventHandler(this.detallesBtn_Click);
            // 
            // gndHistBtn
            // 
            this.gndHistBtn.Enabled = false;
            this.gndHistBtn.Location = new System.Drawing.Point(38, 371);
            this.gndHistBtn.Name = "gndHistBtn";
            this.gndHistBtn.Size = new System.Drawing.Size(193, 27);
            this.gndHistBtn.TabIndex = 35;
            this.gndHistBtn.Text = "Campeón";
            this.gndHistBtn.UseVisualStyleBackColor = true;
            this.gndHistBtn.Visible = false;
            this.gndHistBtn.Click += new System.EventHandler(this.gndHistBtn_Click);
            // 
            // salirBtn
            // 
            this.salirBtn.Enabled = false;
            this.salirBtn.ForeColor = System.Drawing.Color.Red;
            this.salirBtn.Location = new System.Drawing.Point(747, 441);
            this.salirBtn.Name = "salirBtn";
            this.salirBtn.Size = new System.Drawing.Size(45, 28);
            this.salirBtn.TabIndex = 36;
            this.salirBtn.Text = "Salir";
            this.salirBtn.UseVisualStyleBackColor = true;
            this.salirBtn.Visible = false;
            this.salirBtn.Click += new System.EventHandler(this.salirBtn_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(804, 481);
            this.Controls.Add(this.salirBtn);
            this.Controls.Add(this.gndHistBtn);
            this.Controls.Add(this.detallesBtn);
            this.Controls.Add(this.lblSigpelea);
            this.Controls.Add(this.lblGanador);
            this.Controls.Add(this.btnPelear);
            this.Controls.Add(this.btnDado2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDado);
            this.Controls.Add(this.btnAtacar2);
            this.Controls.Add(this.btnAtacar1);
            this.Controls.Add(this.lblSalud2);
            this.Controls.Add(this.lblSalud1);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblArmadura2);
            this.Controls.Add(this.lblFuerza2);
            this.Controls.Add(this.lblDestreza2);
            this.Controls.Add(this.lblVelocidad2);
            this.Controls.Add(this.lblNivel2);
            this.Controls.Add(this.lblClase2);
            this.Controls.Add(this.lblArmadura);
            this.Controls.Add(this.lblFuerza1);
            this.Controls.Add(this.lblDestreza1);
            this.Controls.Add(this.lblVelocidad1);
            this.Controls.Add(this.lblNivel1);
            this.Controls.Add(this.lblClase1);
            this.Controls.Add(this.lblSegundoLuchador);
            this.Controls.Add(this.lblPrimerLuchador);
            this.Controls.Add(this.btnElegir);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.listBoxLuchadores);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxLuchadores;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Button btnElegir;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblPrimerLuchador;
        private System.Windows.Forms.Label lblSegundoLuchador;
        private System.Windows.Forms.Label lblClase1;
        private System.Windows.Forms.Label lblNivel1;
        private System.Windows.Forms.Label lblVelocidad1;
        private System.Windows.Forms.Label lblDestreza1;
        private System.Windows.Forms.Label lblFuerza1;
        private System.Windows.Forms.Label lblArmadura;
        private System.Windows.Forms.Label lblArmadura2;
        private System.Windows.Forms.Label lblFuerza2;
        private System.Windows.Forms.Label lblDestreza2;
        private System.Windows.Forms.Label lblVelocidad2;
        private System.Windows.Forms.Label lblNivel2;
        private System.Windows.Forms.Label lblClase2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label lblSalud1;
        private System.Windows.Forms.Label lblSalud2;
        private System.Windows.Forms.Button btnAtacar1;
        private System.Windows.Forms.Button btnAtacar2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDado;
        private System.Windows.Forms.Button btnDado2;
        private System.Windows.Forms.Button btnPelear;
        private System.Windows.Forms.Label lblGanador;
        private System.Windows.Forms.Button lblSigpelea;
        private System.Windows.Forms.Button detallesBtn;
        private System.Windows.Forms.Button gndHistBtn;
        private System.Windows.Forms.Button salirBtn;
    }
}