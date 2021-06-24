
namespace JuegoDeRolPorTurnos
{
    partial class Form3
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
            this.lblPjPersonalizado = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblApodoPj = new System.Windows.Forms.Label();
            this.lblNombrePj = new System.Windows.Forms.Label();
            this.lblClase = new System.Windows.Forms.Label();
            this.comboBoxClase = new System.Windows.Forms.ComboBox();
            this.txtBoxNombrePj = new System.Windows.Forms.TextBox();
            this.txtApodoPj = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCrear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPjPersonalizado
            // 
            this.lblPjPersonalizado.AutoSize = true;
            this.lblPjPersonalizado.BackColor = System.Drawing.Color.Transparent;
            this.lblPjPersonalizado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPjPersonalizado.Location = new System.Drawing.Point(240, 90);
            this.lblPjPersonalizado.Name = "lblPjPersonalizado";
            this.lblPjPersonalizado.Size = new System.Drawing.Size(337, 25);
            this.lblPjPersonalizado.TabIndex = 0;
            this.lblPjPersonalizado.Text = "Creación de personaje personalizada";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaNac.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFechaNac.Location = new System.Drawing.Point(258, 264);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(117, 15);
            this.lblFechaNac.TabIndex = 6;
            this.lblFechaNac.Text = "Fecha de nacimiento";
            // 
            // lblApodoPj
            // 
            this.lblApodoPj.AutoSize = true;
            this.lblApodoPj.BackColor = System.Drawing.Color.Transparent;
            this.lblApodoPj.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApodoPj.Location = new System.Drawing.Point(259, 227);
            this.lblApodoPj.Name = "lblApodoPj";
            this.lblApodoPj.Size = new System.Drawing.Size(116, 15);
            this.lblApodoPj.TabIndex = 5;
            this.lblApodoPj.Text = "Apodo del personaje";
            // 
            // lblNombrePj
            // 
            this.lblNombrePj.AutoSize = true;
            this.lblNombrePj.BackColor = System.Drawing.Color.Transparent;
            this.lblNombrePj.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombrePj.Location = new System.Drawing.Point(251, 190);
            this.lblNombrePj.Name = "lblNombrePj";
            this.lblNombrePj.Size = new System.Drawing.Size(124, 15);
            this.lblNombrePj.TabIndex = 4;
            this.lblNombrePj.Text = "Nombre del personaje";
            // 
            // lblClase
            // 
            this.lblClase.AutoSize = true;
            this.lblClase.BackColor = System.Drawing.Color.Transparent;
            this.lblClase.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClase.Location = new System.Drawing.Point(340, 153);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(34, 15);
            this.lblClase.TabIndex = 7;
            this.lblClase.Text = "Clase";
            // 
            // comboBoxClase
            // 
            this.comboBoxClase.FormattingEnabled = true;
            this.comboBoxClase.Location = new System.Drawing.Point(381, 150);
            this.comboBoxClase.Name = "comboBoxClase";
            this.comboBoxClase.Size = new System.Drawing.Size(173, 23);
            this.comboBoxClase.TabIndex = 8;
            this.comboBoxClase.SelectedIndexChanged += new System.EventHandler(this.comboBoxClase_SelectedIndexChanged);
            // 
            // txtBoxNombrePj
            // 
            this.txtBoxNombrePj.Location = new System.Drawing.Point(381, 187);
            this.txtBoxNombrePj.Name = "txtBoxNombrePj";
            this.txtBoxNombrePj.Size = new System.Drawing.Size(173, 23);
            this.txtBoxNombrePj.TabIndex = 9;
            this.txtBoxNombrePj.TextChanged += new System.EventHandler(this.txtBoxNombrePj_TextChanged);
            // 
            // txtApodoPj
            // 
            this.txtApodoPj.Location = new System.Drawing.Point(381, 224);
            this.txtApodoPj.Name = "txtApodoPj";
            this.txtApodoPj.Size = new System.Drawing.Size(173, 23);
            this.txtApodoPj.TabIndex = 10;
            this.txtApodoPj.TextChanged += new System.EventHandler(this.txtApodoPj_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(381, 258);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(173, 23);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(357, 324);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(91, 34);
            this.btnCrear.TabIndex = 12;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JuegoDeRolPorTurnos.Properties.Resources.img2;
            this.ClientSize = new System.Drawing.Size(804, 481);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtApodoPj);
            this.Controls.Add(this.txtBoxNombrePj);
            this.Controls.Add(this.comboBoxClase);
            this.Controls.Add(this.lblClase);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.lblApodoPj);
            this.Controls.Add(this.lblNombrePj);
            this.Controls.Add(this.lblPjPersonalizado);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPjPersonalizado;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblApodoPj;
        private System.Windows.Forms.Label lblNombrePj;
        private System.Windows.Forms.Label lblClase;
        private System.Windows.Forms.ComboBox comboBoxClase;
        private System.Windows.Forms.TextBox txtBoxNombrePj;
        private System.Windows.Forms.TextBox txtApodoPj;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnCrear;
    }
}