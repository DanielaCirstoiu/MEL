namespace FrmBazaFilme
{
    partial class FrmMovies
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
            this.bAddMovies = new System.Windows.Forms.Button();
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.dgvDetalii = new System.Windows.Forms.DataGridView();
            this.bDeleteMovie = new System.Windows.Forms.Button();
            this.lbDetalii = new System.Windows.Forms.Label();
            this.bUpdateMovie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalii)).BeginInit();
            this.SuspendLayout();
            // 
            // bAddMovies
            // 
            this.bAddMovies.Location = new System.Drawing.Point(68, 51);
            this.bAddMovies.Name = "bAddMovies";
            this.bAddMovies.Size = new System.Drawing.Size(92, 40);
            this.bAddMovies.TabIndex = 0;
            this.bAddMovies.Text = "ADD";
            this.bAddMovies.UseVisualStyleBackColor = true;
            this.bAddMovies.Click += new System.EventHandler(this.bAddMovies_Click);
            // 
            // dgvMovies
            // 
            this.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovies.Location = new System.Drawing.Point(8, 128);
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.RowTemplate.Height = 24;
            this.dgvMovies.Size = new System.Drawing.Size(1024, 165);
            this.dgvMovies.TabIndex = 2;
            this.dgvMovies.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMovies_RowHeaderMouseClick);
            // 
            // dgvDetalii
            // 
            this.dgvDetalii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalii.Location = new System.Drawing.Point(12, 350);
            this.dgvDetalii.Name = "dgvDetalii";
            this.dgvDetalii.RowTemplate.Height = 24;
            this.dgvDetalii.Size = new System.Drawing.Size(1134, 150);
            this.dgvDetalii.TabIndex = 3;
            this.dgvDetalii.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRemovedMovies_CellContentClick);
            // 
            // bDeleteMovie
            // 
            this.bDeleteMovie.Location = new System.Drawing.Point(431, 51);
            this.bDeleteMovie.Name = "bDeleteMovie";
            this.bDeleteMovie.Size = new System.Drawing.Size(86, 40);
            this.bDeleteMovie.TabIndex = 4;
            this.bDeleteMovie.Text = "DELETE";
            this.bDeleteMovie.UseVisualStyleBackColor = true;
            this.bDeleteMovie.Click += new System.EventHandler(this.bDeleteMovie_Click);
            // 
            // lbDetalii
            // 
            this.lbDetalii.AutoSize = true;
            this.lbDetalii.Location = new System.Drawing.Point(65, 316);
            this.lbDetalii.Name = "lbDetalii";
            this.lbDetalii.Size = new System.Drawing.Size(65, 17);
            this.lbDetalii.TabIndex = 5;
            this.lbDetalii.Text = "DETAILS";
            // 
            // bUpdateMovie
            // 
            this.bUpdateMovie.Location = new System.Drawing.Point(260, 51);
            this.bUpdateMovie.Name = "bUpdateMovie";
            this.bUpdateMovie.Size = new System.Drawing.Size(85, 40);
            this.bUpdateMovie.TabIndex = 7;
            this.bUpdateMovie.Text = "UPDATE";
            this.bUpdateMovie.UseVisualStyleBackColor = true;
            this.bUpdateMovie.Click += new System.EventHandler(this.bUpdateMovie_Click);
            // 
            // FrmMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FrmBazaFilme.Properties.Resources.imageMain;
            this.ClientSize = new System.Drawing.Size(1158, 530);
            this.Controls.Add(this.bUpdateMovie);
            this.Controls.Add(this.lbDetalii);
            this.Controls.Add(this.bDeleteMovie);
            this.Controls.Add(this.dgvDetalii);
            this.Controls.Add(this.dgvMovies);
            this.Controls.Add(this.bAddMovies);
            this.Name = "FrmMovies";
            this.Text = "MovieBase/Movies";
            this.Load += new System.EventHandler(this.FrmMovies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAddMovies;
        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.DataGridView dgvDetalii;
        private System.Windows.Forms.Button bDeleteMovie;
        private System.Windows.Forms.Label lbDetalii;
        private System.Windows.Forms.Button bUpdateMovie;
    }
}