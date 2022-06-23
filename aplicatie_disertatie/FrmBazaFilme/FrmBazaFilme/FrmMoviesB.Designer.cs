namespace FrmBazaFilme
{
    partial class FrmMoviesB
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
            this.bMovies = new System.Windows.Forms.Button();
            this.bActors = new System.Windows.Forms.Button();
            this.bDirectors = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bMovies
            // 
            this.bMovies.Location = new System.Drawing.Point(86, 81);
            this.bMovies.Name = "bMovies";
            this.bMovies.Size = new System.Drawing.Size(110, 65);
            this.bMovies.TabIndex = 0;
            this.bMovies.Text = "MOVIES";
            this.bMovies.UseVisualStyleBackColor = true;
            this.bMovies.Click += new System.EventHandler(this.bMovies_Click);
            // 
            // bActors
            // 
            this.bActors.Location = new System.Drawing.Point(86, 239);
            this.bActors.Name = "bActors";
            this.bActors.Size = new System.Drawing.Size(110, 65);
            this.bActors.TabIndex = 1;
            this.bActors.Text = "ACTORS";
            this.bActors.UseVisualStyleBackColor = true;
            this.bActors.Click += new System.EventHandler(this.bActors_Click);
            // 
            // bDirectors
            // 
            this.bDirectors.Location = new System.Drawing.Point(86, 399);
            this.bDirectors.Name = "bDirectors";
            this.bDirectors.Size = new System.Drawing.Size(110, 65);
            this.bDirectors.TabIndex = 2;
            this.bDirectors.Text = "DIRECTORS";
            this.bDirectors.UseVisualStyleBackColor = true;
            this.bDirectors.Click += new System.EventHandler(this.bDirectors_Click);
            // 
            // FrmMoviesB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::FrmBazaFilme.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.bDirectors);
            this.Controls.Add(this.bActors);
            this.Controls.Add(this.bMovies);
            this.Name = "FrmMoviesB";
            this.Text = "MovieBase";
            this.Load += new System.EventHandler(this.FrmMoviesB_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bMovies;
        private System.Windows.Forms.Button bActors;
        private System.Windows.Forms.Button bDirectors;
    }
}

