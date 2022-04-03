namespace bioskop
{
    partial class Opis
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
            this.labelPunNaziv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOcena = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTrajanje = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelGlumci = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelOpis = new System.Windows.Forms.Label();
            this.buttonTrailer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPunNaziv
            // 
            this.labelPunNaziv.AutoSize = true;
            this.labelPunNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPunNaziv.Location = new System.Drawing.Point(205, 176);
            this.labelPunNaziv.Name = "labelPunNaziv";
            this.labelPunNaziv.Size = new System.Drawing.Size(548, 195);
            this.labelPunNaziv.TabIndex = 0;
            this.labelPunNaziv.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ocena: ";
            // 
            // labelOcena
            // 
            this.labelOcena.AutoSize = true;
            this.labelOcena.Location = new System.Drawing.Point(266, 359);
            this.labelOcena.Name = "labelOcena";
            this.labelOcena.Size = new System.Drawing.Size(93, 32);
            this.labelOcena.TabIndex = 2;
            this.labelOcena.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 80);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trajanje:";
            // 
            // labelTrajanje
            // 
            this.labelTrajanje.AutoSize = true;
            this.labelTrajanje.Location = new System.Drawing.Point(266, 495);
            this.labelTrajanje.Name = "labelTrajanje";
            this.labelTrajanje.Size = new System.Drawing.Size(93, 32);
            this.labelTrajanje.TabIndex = 4;
            this.labelTrajanje.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 624);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Glumci:";
            // 
            // labelGlumci
            // 
            this.labelGlumci.AutoSize = true;
            this.labelGlumci.Location = new System.Drawing.Point(266, 624);
            this.labelGlumci.Name = "labelGlumci";
            this.labelGlumci.Size = new System.Drawing.Size(93, 32);
            this.labelGlumci.TabIndex = 6;
            this.labelGlumci.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 812);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 32);
            this.label6.TabIndex = 8;
            this.label6.Text = "Opis:";
            // 
            // labelOpis
            // 
            this.labelOpis.AutoSize = true;
            this.labelOpis.Location = new System.Drawing.Point(266, 812);
            this.labelOpis.Name = "labelOpis";
            this.labelOpis.Size = new System.Drawing.Size(93, 32);
            this.labelOpis.TabIndex = 9;
            this.labelOpis.Text = "label7";
            // 
            // buttonTrailer
            // 
            this.buttonTrailer.Location = new System.Drawing.Point(686, 997);
            this.buttonTrailer.Name = "buttonTrailer";
            this.buttonTrailer.Size = new System.Drawing.Size(229, 77);
            this.buttonTrailer.TabIndex = 10;
            this.buttonTrailer.Text = "Trailer";
            this.buttonTrailer.UseVisualStyleBackColor = true;
            // 
            // Opis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 1323);
            this.Controls.Add(this.buttonTrailer);
            this.Controls.Add(this.labelOpis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelGlumci);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelTrajanje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelOcena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPunNaziv);
            this.Name = "Opis";
            this.Text = "Opis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPunNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOcena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTrajanje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelGlumci;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelOpis;
        private System.Windows.Forms.Button buttonTrailer;
    }
}