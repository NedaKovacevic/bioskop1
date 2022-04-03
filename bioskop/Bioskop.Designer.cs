namespace bioskop
{
    partial class Bioskop
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
            this.components = new System.ComponentModel.Container();
            this.dgTabela = new System.Windows.Forms.DataGridView();
            this.bioskop2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bioskop2DataSet = new bioskop.Bioskop2DataSet();
            this.tbFilm = new System.Windows.Forms.TextBox();
            this.tbVreme = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnOpis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bioskop2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bioskop2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTabela
            // 
            this.dgTabela.AllowUserToAddRows = false;
            this.dgTabela.AllowUserToDeleteRows = false;
            this.dgTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTabela.Location = new System.Drawing.Point(73, 259);
            this.dgTabela.Name = "dgTabela";
            this.dgTabela.ReadOnly = true;
            this.dgTabela.RowHeadersWidth = 102;
            this.dgTabela.RowTemplate.Height = 40;
            this.dgTabela.Size = new System.Drawing.Size(1173, 981);
            this.dgTabela.TabIndex = 0;
            // 
            // bioskop2DataSetBindingSource
            // 
            this.bioskop2DataSetBindingSource.DataSource = this.bioskop2DataSet;
            this.bioskop2DataSetBindingSource.Position = 0;
            // 
            // bioskop2DataSet
            // 
            this.bioskop2DataSet.DataSetName = "Bioskop2DataSet";
            this.bioskop2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbFilm
            // 
            this.tbFilm.Location = new System.Drawing.Point(290, 98);
            this.tbFilm.Name = "tbFilm";
            this.tbFilm.Size = new System.Drawing.Size(243, 38);
            this.tbFilm.TabIndex = 1;
            // 
            // tbVreme
            // 
            this.tbVreme.Location = new System.Drawing.Point(799, 98);
            this.tbVreme.Name = "tbVreme";
            this.tbVreme.Size = new System.Drawing.Size(231, 38);
            this.tbVreme.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1352, 88);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(195, 48);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnOpis
            // 
            this.btnOpis.Location = new System.Drawing.Point(1352, 1224);
            this.btnOpis.Name = "btnOpis";
            this.btnOpis.Size = new System.Drawing.Size(190, 56);
            this.btnOpis.TabIndex = 4;
            this.btnOpis.Text = "saznaj vise!";
            this.btnOpis.UseVisualStyleBackColor = true;
            this.btnOpis.Click += new System.EventHandler(this.btnOpis_Click);
            // 
            // Bioskop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1627, 1473);
            this.Controls.Add(this.btnOpis);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbVreme);
            this.Controls.Add(this.tbFilm);
            this.Controls.Add(this.dgTabela);
            this.Name = "Bioskop";
            this.Text = "Bioskop";
            this.Load += new System.EventHandler(this.Bioskop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bioskop2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bioskop2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTabela;
        private System.Windows.Forms.BindingSource bioskop2DataSetBindingSource;
        private Bioskop2DataSet bioskop2DataSet;
        private System.Windows.Forms.TextBox tbFilm;
        private System.Windows.Forms.TextBox tbVreme;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnOpis;
    }
}

