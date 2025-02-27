namespace TouRPGProject
{
    partial class SeleccionOpcionJugador
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
            this.btnHabilidadesAspirante = new System.Windows.Forms.Button();
            this.btnAtacarAspirante = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHabilidadesAspirante
            // 
            this.btnHabilidadesAspirante.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnHabilidadesAspirante.Location = new System.Drawing.Point(221, 12);
            this.btnHabilidadesAspirante.Name = "btnHabilidadesAspirante";
            this.btnHabilidadesAspirante.Size = new System.Drawing.Size(163, 67);
            this.btnHabilidadesAspirante.TabIndex = 46;
            this.btnHabilidadesAspirante.Text = "Habilidades";
            this.btnHabilidadesAspirante.UseVisualStyleBackColor = true;
            // 
            // btnAtacarAspirante
            // 
            this.btnAtacarAspirante.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnAtacarAspirante.Location = new System.Drawing.Point(12, 12);
            this.btnAtacarAspirante.Name = "btnAtacarAspirante";
            this.btnAtacarAspirante.Size = new System.Drawing.Size(163, 67);
            this.btnAtacarAspirante.TabIndex = 45;
            this.btnAtacarAspirante.Text = "Atacar";
            this.btnAtacarAspirante.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.button1.Location = new System.Drawing.Point(12, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 67);
            this.button1.TabIndex = 47;
            this.button1.Text = "Pose Defensiva";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.button2.Location = new System.Drawing.Point(221, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 67);
            this.button2.TabIndex = 48;
            this.button2.Text = "Objetos";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SeleccionOpcionJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 183);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHabilidadesAspirante);
            this.Controls.Add(this.btnAtacarAspirante);
            this.Name = "SeleccionOpcionJugador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecciona Habilidad";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHabilidadesAspirante;
        private System.Windows.Forms.Button btnAtacarAspirante;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}