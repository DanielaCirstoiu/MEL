namespace FrmBazaFilme
{
    partial class FrmActors
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
            this.bDeleteActor = new System.Windows.Forms.Button();
            this.dgvActors = new System.Windows.Forms.DataGridView();
            this.bUpdateActor = new System.Windows.Forms.Button();
            this.bAddActors = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).BeginInit();
            this.SuspendLayout();
            // 
            // bDeleteActor
            // 
            this.bDeleteActor.Location = new System.Drawing.Point(409, 104);
            this.bDeleteActor.Name = "bDeleteActor";
            this.bDeleteActor.Size = new System.Drawing.Size(86, 40);
            this.bDeleteActor.TabIndex = 8;
            this.bDeleteActor.Text = "DELETE";
            this.bDeleteActor.UseVisualStyleBackColor = true;
            // 
            // dgvActors
            // 
            this.dgvActors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActors.Location = new System.Drawing.Point(32, 181);
            this.dgvActors.Name = "dgvActors";
            this.dgvActors.RowTemplate.Height = 24;
            this.dgvActors.Size = new System.Drawing.Size(740, 245);
            this.dgvActors.TabIndex = 7;
            // 
            // bUpdateActor
            // 
            this.bUpdateActor.Location = new System.Drawing.Point(243, 104);
            this.bUpdateActor.Name = "bUpdateActor";
            this.bUpdateActor.Size = new System.Drawing.Size(85, 40);
            this.bUpdateActor.TabIndex = 6;
            this.bUpdateActor.Text = "UPDATE";
            this.bUpdateActor.UseVisualStyleBackColor = true;
            // 
            // bAddActors
            // 
            this.bAddActors.Location = new System.Drawing.Point(70, 104);
            this.bAddActors.Name = "bAddActors";
            this.bAddActors.Size = new System.Drawing.Size(92, 40);
            this.bAddActors.TabIndex = 5;
            this.bAddActors.Text = "ADD";
            this.bAddActors.UseVisualStyleBackColor = true;
            // 
            // FrmActors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FrmBazaFilme.Properties.Resources.download;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bDeleteActor);
            this.Controls.Add(this.dgvActors);
            this.Controls.Add(this.bUpdateActor);
            this.Controls.Add(this.bAddActors);
            this.Name = "FrmActors";
            this.Text = "MovieBase/Actors";
            this.Load += new System.EventHandler(this.FrmActors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bDeleteActor;
        private System.Windows.Forms.DataGridView dgvActors;
        private System.Windows.Forms.Button bUpdateActor;
        private System.Windows.Forms.Button bAddActors;
    }
}