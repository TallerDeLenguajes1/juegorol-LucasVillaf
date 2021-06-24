
namespace JuegoDeRolPorTurnos
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblCreaTuPeleador = new System.Windows.Forms.Label();
            this.btnPersonalizar = new System.Windows.Forms.Button();
            this.btnAleatorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCreaTuPeleador
            // 
            this.lblCreaTuPeleador.AutoSize = true;
            this.lblCreaTuPeleador.BackColor = System.Drawing.Color.Transparent;
            this.lblCreaTuPeleador.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCreaTuPeleador.Location = new System.Drawing.Point(325, 174);
            this.lblCreaTuPeleador.Name = "lblCreaTuPeleador";
            this.lblCreaTuPeleador.Size = new System.Drawing.Size(160, 25);
            this.lblCreaTuPeleador.TabIndex = 0;
            this.lblCreaTuPeleador.Text = "Crea tu peleador";
            // 
            // btnPersonalizar
            // 
            this.btnPersonalizar.Location = new System.Drawing.Point(246, 271);
            this.btnPersonalizar.Name = "btnPersonalizar";
            this.btnPersonalizar.Size = new System.Drawing.Size(133, 36);
            this.btnPersonalizar.TabIndex = 1;
            this.btnPersonalizar.Text = "Personalizado";
            this.btnPersonalizar.UseVisualStyleBackColor = true;
            this.btnPersonalizar.Click += new System.EventHandler(this.btnPersonalizar_Click);
            // 
            // btnAleatorio
            // 
            this.btnAleatorio.Location = new System.Drawing.Point(425, 271);
            this.btnAleatorio.Name = "btnAleatorio";
            this.btnAleatorio.Size = new System.Drawing.Size(133, 36);
            this.btnAleatorio.TabIndex = 2;
            this.btnAleatorio.Text = "Aleatorio";
            this.btnAleatorio.UseVisualStyleBackColor = true;
            this.btnAleatorio.Click += new System.EventHandler(this.btnAleatorio_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(804, 481);
            this.Controls.Add(this.btnAleatorio);
            this.Controls.Add(this.btnPersonalizar);
            this.Controls.Add(this.lblCreaTuPeleador);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreaTuPeleador;
        private System.Windows.Forms.Button btnPersonalizar;
        private System.Windows.Forms.Button btnAleatorio;
    }
}