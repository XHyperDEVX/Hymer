namespace Hyrus
{
    partial class Name
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Name));
            this.WName = new System.Windows.Forms.Label();
            this.namee = new System.Windows.Forms.TextBox();
            this.Daten = new System.Windows.Forms.Label();
            this.weiter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WName
            // 
            this.WName.AutoSize = true;
            this.WName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WName.Location = new System.Drawing.Point(12, 9);
            this.WName.Name = "WName";
            this.WName.Size = new System.Drawing.Size(99, 13);
            this.WName.TabIndex = 0;
            this.WName.Text = "Wie ist dein Name?";
            // 
            // namee
            // 
            this.namee.Location = new System.Drawing.Point(15, 25);
            this.namee.Name = "namee";
            this.namee.Size = new System.Drawing.Size(121, 20);
            this.namee.TabIndex = 1;
            this.namee.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Daten
            // 
            this.Daten.AutoSize = true;
            this.Daten.Location = new System.Drawing.Point(12, 48);
            this.Daten.Name = "Daten";
            this.Daten.Size = new System.Drawing.Size(344, 39);
            this.Daten.TabIndex = 2;
            this.Daten.Text = "Die oben angegebenden Daten werden auf dem PC virtuell gespeichert\r\njedoch nicht " +
    "auf Server gesendet oder sonstiges! \r\nNach beenden des Programms wird der Name g" +
    "elöscht.";
            // 
            // weiter
            // 
            this.weiter.Location = new System.Drawing.Point(183, 25);
            this.weiter.Name = "weiter";
            this.weiter.Size = new System.Drawing.Size(78, 20);
            this.weiter.TabIndex = 3;
            this.weiter.Text = "Weiter";
            this.weiter.UseVisualStyleBackColor = true;
            this.weiter.Click += new System.EventHandler(this.weiter_Click);
            // 
            // Name
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 93);
            this.Controls.Add(this.weiter);
            this.Controls.Add(this.Daten);
            this.Controls.Add(this.namee);
            this.Controls.Add(this.WName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Name";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hallo!";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WName;
        private System.Windows.Forms.TextBox namee;
        private System.Windows.Forms.Label Daten;
        private System.Windows.Forms.Button weiter;
    }
}