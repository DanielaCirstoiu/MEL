namespace FrmBazaFilme
{
    partial class FrmDirectors
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
            this.bDeleteDirectors = new System.Windows.Forms.Button();
            this.dgvDirectors = new System.Windows.Forms.DataGridView();
            this.bUpdateDirectors = new System.Windows.Forms.Button();
            this.bAddDirectors = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectors)).BeginInit();
            this.SuspendLayout();
            // 
            // bDeleteDirectors
            // 
            this.bDeleteDirectors.Location = new System.Drawing.Point(415, 104);
            this.bDeleteDirectors.Name = "bDeleteDirectors";
            this.bDeleteDirectors.Size = new System.Drawing.Size(86, 40);
            this.bDeleteDirectors.TabIndex = 8;
            this.bDeleteDirectors.Text = "DELETE";
            this.bDeleteDirectors.UseVisualStyleBackColor = true;
            // 
            // dgvDirectors
            // 
            this.dgvDirectors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirectors.Location = new System.Drawing.Point(12, 181);
            this.dgvDirectors.Name = "dgvDirectors";
            this.dgvDirectors.RowTemplate.Height = 24;
            this.dgvDirectors.Size = new System.Drawing.Size(776, 240);
            this.dgvDirectors.TabIndex = 7;
            this.dgvDirectors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDirectors_CellContentClick);
            // 
            // bUpdateDirectors
            // 
            this.bUpdateDirectors.Location = new System.Drawing.Point(251, 104);
            this.bUpdateDirectors.Name = "bUpdateDirectors";
            this.bUpdateDirectors.Size = new System.Drawing.Size(85, 40);
            this.bUpdateDirectors.TabIndex = 6;
            this.bUpdateDirectors.Text = "UPDATE";
            this.bUpdateDirectors.UseVisualStyleBackColor = true;
            // 
            // bAddDirectors
            // 
            this.bAddDirectors.Location = new System.Drawing.Point(70, 104);
            this.bAddDirectors.Name = "bAddDirectors";
            this.bAddDirectors.Size = new System.Drawing.Size(92, 40);
            this.bAddDirectors.TabIndex = 5;
            this.bAddDirectors.Text = "ADD";
            this.bAddDirectors.UseVisualStyleBackColor = true;
            // 
            // FrmDirectors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FrmBazaFilme.Properties.Resources.images__1_;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bDeleteDirectors);
            this.Controls.Add(this.dgvDirectors);
            this.Controls.Add(this.bUpdateDirectors);
            this.Controls.Add(this.bAddDirectors);
            this.Name = "FrmDirectors";
            this.Text = "MovieBase/Directors";
            this.Load += new System.EventHandler(this.FrmDirectors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bDeleteDirectors;
        private System.Windows.Forms.DataGridView dgvDirectors;
        private System.Windows.Forms.Button bUpdateDirectors;
        private System.Windows.Forms.Button bAddDirectors;
    }
}