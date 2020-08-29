namespace Hyrus
{
    partial class Hinweis
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hinweis));
            this.Start = new System.Windows.Forms.Button();
            this.Bes = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.namea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Enabled = false;
            this.Start.Location = new System.Drawing.Point(672, 287);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bes
            // 
            this.Bes.AutoSize = true;
            this.Bes.Location = new System.Drawing.Point(368, 291);
            this.Bes.Name = "Bes";
            this.Bes.Size = new System.Drawing.Size(298, 17);
            this.Bes.TabIndex = 2;
            this.Bes.Text = "Ich habe das oben stehende gelesen und stimme dem zu.";
            this.Bes.UseVisualStyleBackColor = true;
            this.Bes.CheckedChanged += new System.EventHandler(this.Bes_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(753, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Abbrechen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // namea
            // 
            this.namea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.namea.Location = new System.Drawing.Point(12, 12);
            this.namea.Multiline = true;
            this.namea.Name = "namea";
            this.namea.ReadOnly = true;
            this.namea.Size = new System.Drawing.Size(840, 269);
            this.namea.TabIndex = 5;
            this.namea.Text = "Es ist ein Fehler aufgetreten! Bitte klicke auf Abbrechen und starte das Programm" +
    " neu!";
            this.namea.TextChanged += new System.EventHandler(this.namea_TextChanged);
            // 
            // Hinweis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 338);
            this.Controls.Add(this.namea);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Bes);
            this.Controls.Add(this.Start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hinweis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hyrus";
            this.Load += new System.EventHandler(this.Hinweis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.CheckBox Bes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox namea;
    }
}

