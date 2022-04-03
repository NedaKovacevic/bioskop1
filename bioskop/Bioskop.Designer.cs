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
            this.tbZanr = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
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
            this.dgTabela.Size = new System.Drawing.Size(1281, 981);
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
            this.tbFilm.Location = new System.Drawing.Point(421, 88);
            this.tbFilm.Name = "tbFilm";
            this.tbFilm.Size = new System.Drawing.Size(195, 38);
            this.tbFilm.TabIndex = 1;
            // 
            // tbZanr
            // 
            this.tbZanr.Location = new System.Drawing.Point(781, 88);
            this.tbZanr.Name = "tbZanr";
            this.tbZanr.Size = new System.Drawing.Size(195, 38);
            this.tbZanr.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1352, 88);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(195, 48);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // Bioskop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2109, 1323);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbZanr);
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
        private System.Windows.Forms.TextBox tbZanr;
        private System.Windows.Forms.Button btnSearch;
    }
}

