
namespace JuegoDeRolPorTurnos
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblSuLuchador = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnPelear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(191, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "La batalla está por comenzar, no hay vuelta atrás";
            // 
            // lblSuLuchador
            // 
            this.lblSuLuchador.AutoSize = true;
            this.lblSuLuchador.BackColor = System.Drawing.Color.Transparent;
            this.lblSuLuchador.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSuLuchador.Location = new System.Drawing.Point(271, 142);
            this.lblSuLuchador.Name = "lblSuLuchador";
            this.lblSuLuchador.Size = new System.Drawing.Size(122, 17);
            this.lblSuLuchador.TabIndex = 1;
            this.lblSuLuchador.Text = "lblLuchadorElegido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(287, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione la cantidad de rivales: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(475, 185);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(42, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // btnPelear
            // 
            this.btnPelear.Location = new System.Drawing.Point(343, 331);
            this.btnPelear.Name = "btnPelear";
            this.btnPelear.Size = new System.Drawing.Size(118, 29);
            this.btnPelear.TabIndex = 4;
            this.btnPelear.Text = "A pelear!";
            this.btnPelear.UseVisualStyleBackColor = true;
            this.btnPelear.Click += new System.EventHandler(this.btnPelear_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JuegoDeRolPorTurnos.Properties.Resources.img2;
            this.ClientSize = new System.Drawing.Size(804, 481);
            this.Controls.Add(this.btnPelear);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSuLuchador);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSuLuchador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnPelear;
    }
}