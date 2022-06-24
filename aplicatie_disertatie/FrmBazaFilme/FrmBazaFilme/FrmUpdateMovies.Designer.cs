namespace FrmBazaFilme
{
    partial class FrmUpdateMovies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpdateMovies));
            this.utbEarn = new System.Windows.Forms.TextBox();
            this.lbProgressBar = new System.Windows.Forms.Label();
            this.upbSuccess = new System.Windows.Forms.ProgressBar();
            this.utbEarnings = new System.Windows.Forms.TrackBar();
            this.unupdDuration = new System.Windows.Forms.NumericUpDown();
            this.udtpYear = new System.Windows.Forms.DateTimePicker();
            this.bUpdateMovie = new System.Windows.Forms.Button();
            this.ucbCountry = new System.Windows.Forms.ComboBox();
            this.ugbGenre = new System.Windows.Forms.GroupBox();
            this.urbMusical = new System.Windows.Forms.RadioButton();
            this.urbAdventure = new System.Windows.Forms.RadioButton();
            this.urbBiography = new System.Windows.Forms.RadioButton();
            this.urbHistory = new System.Windows.Forms.RadioButton();
            this.urbSciFi = new System.Windows.Forms.RadioButton();
            this.urbComedy = new System.Windows.Forms.RadioButton();
            this.urbRomance = new System.Windows.Forms.RadioButton();
            this.urbFantasy = new System.Windows.Forms.RadioButton();
            this.utbTitle = new System.Windows.Forms.TextBox();
            this.utbMovieID = new System.Windows.Forms.TextBox();
            this.lbEarnings = new System.Windows.Forms.Label();
            this.lbDuration = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbMovieID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.utbEarnings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unupdDuration)).BeginInit();
            this.ugbGenre.SuspendLayout();
            this.SuspendLayout();
            // 
            // utbEarn
            // 
            this.utbEarn.Location = new System.Drawing.Point(79, 322);
            this.utbEarn.Name = "utbEarn";
            this.utbEarn.Size = new System.Drawing.Size(78, 22);
            this.utbEarn.TabIndex = 35;
            // 
            // lbProgressBar
            // 
            this.lbProgressBar.AutoSize = true;
            this.lbProgressBar.Location = new System.Drawing.Point(528, 268);
            this.lbProgressBar.Name = "lbProgressBar";
            this.lbProgressBar.Size = new System.Drawing.Size(154, 17);
            this.lbProgressBar.TabIndex = 34;
            this.lbProgressBar.Text = "Procentage of Success";
            // 
            // upbSuccess
            // 
            this.upbSuccess.Location = new System.Drawing.Point(502, 302);
            this.upbSuccess.Name = "upbSuccess";
            this.upbSuccess.Size = new System.Drawing.Size(243, 23);
            this.upbSuccess.TabIndex = 33;
            // 
            // utbEarnings
            // 
            this.utbEarnings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.utbEarnings.Location = new System.Drawing.Point(155, 302);
            this.utbEarnings.Maximum = 1500;
            this.utbEarnings.Name = "utbEarnings";
            this.utbEarnings.Size = new System.Drawing.Size(213, 56);
            this.utbEarnings.TabIndex = 32;
            this.utbEarnings.Scroll += new System.EventHandler(this.utbEarnings_Scroll);
            // 
            // unupdDuration
            // 
            this.unupdDuration.Location = new System.Drawing.Point(155, 252);
            this.unupdDuration.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.unupdDuration.Minimum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.unupdDuration.Name = "unupdDuration";
            this.unupdDuration.Size = new System.Drawing.Size(200, 22);
            this.unupdDuration.TabIndex = 31;
            this.unupdDuration.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // udtpYear
            // 
            this.udtpYear.CustomFormat = "yyyy";
            this.udtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.udtpYear.Location = new System.Drawing.Point(155, 195);
            this.udtpYear.MaxDate = new System.DateTime(2022, 8, 1, 0, 0, 0, 0);
            this.udtpYear.MinDate = new System.DateTime(1942, 1, 1, 0, 0, 0, 0);
            this.udtpYear.Name = "udtpYear";
            this.udtpYear.Size = new System.Drawing.Size(200, 22);
            this.udtpYear.TabIndex = 30;
            this.udtpYear.Value = new System.DateTime(2022, 7, 7, 0, 0, 0, 0);
            // 
            // bUpdateMovie
            // 
            this.bUpdateMovie.Location = new System.Drawing.Point(372, 373);
            this.bUpdateMovie.Name = "bUpdateMovie";
            this.bUpdateMovie.Size = new System.Drawing.Size(125, 52);
            this.bUpdateMovie.TabIndex = 29;
            this.bUpdateMovie.Text = "UPDATE MOVIE";
            this.bUpdateMovie.UseVisualStyleBackColor = true;
            this.bUpdateMovie.Click += new System.EventHandler(this.bUpdateMovie_Click);
            // 
            // ucbCountry
            // 
            this.ucbCountry.FormattingEnabled = true;
            this.ucbCountry.Items.AddRange(new object[] {
            "USA",
            "UK",
            "Italia",
            "France",
            "Romania"});
            this.ucbCountry.Location = new System.Drawing.Point(155, 138);
            this.ucbCountry.Name = "ucbCountry";
            this.ucbCountry.Size = new System.Drawing.Size(200, 24);
            this.ucbCountry.TabIndex = 28;
            // 
            // ugbGenre
            // 
            this.ugbGenre.Controls.Add(this.urbMusical);
            this.ugbGenre.Controls.Add(this.urbAdventure);
            this.ugbGenre.Controls.Add(this.urbBiography);
            this.ugbGenre.Controls.Add(this.urbHistory);
            this.ugbGenre.Controls.Add(this.urbSciFi);
            this.ugbGenre.Controls.Add(this.urbComedy);
            this.ugbGenre.Controls.Add(this.urbRomance);
            this.ugbGenre.Controls.Add(this.urbFantasy);
            this.ugbGenre.Location = new System.Drawing.Point(502, 37);
            this.ugbGenre.Name = "ugbGenre";
            this.ugbGenre.Size = new System.Drawing.Size(295, 190);
            this.ugbGenre.TabIndex = 27;
            this.ugbGenre.TabStop = false;
            this.ugbGenre.Text = "Genre";
            // 
            // urbMusical
            // 
            this.urbMusical.AutoSize = true;
            this.urbMusical.Location = new System.Drawing.Point(179, 163);
            this.urbMusical.Name = "urbMusical";
            this.urbMusical.Size = new System.Drawing.Size(76, 21);
            this.urbMusical.TabIndex = 7;
            this.urbMusical.TabStop = true;
            this.urbMusical.Text = "Musical";
            this.urbMusical.UseVisualStyleBackColor = true;
            // 
            // urbAdventure
            // 
            this.urbAdventure.AutoSize = true;
            this.urbAdventure.Location = new System.Drawing.Point(179, 118);
            this.urbAdventure.Name = "urbAdventure";
            this.urbAdventure.Size = new System.Drawing.Size(94, 21);
            this.urbAdventure.TabIndex = 6;
            this.urbAdventure.TabStop = true;
            this.urbAdventure.Text = "Adventure";
            this.urbAdventure.UseVisualStyleBackColor = true;
            // 
            // urbBiography
            // 
            this.urbBiography.AutoSize = true;
            this.urbBiography.Location = new System.Drawing.Point(179, 78);
            this.urbBiography.Name = "urbBiography";
            this.urbBiography.Size = new System.Drawing.Size(93, 21);
            this.urbBiography.TabIndex = 5;
            this.urbBiography.TabStop = true;
            this.urbBiography.Text = "Biography";
            this.urbBiography.UseVisualStyleBackColor = true;
            // 
            // urbHistory
            // 
            this.urbHistory.AutoSize = true;
            this.urbHistory.Location = new System.Drawing.Point(179, 45);
            this.urbHistory.Name = "urbHistory";
            this.urbHistory.Size = new System.Drawing.Size(73, 21);
            this.urbHistory.TabIndex = 4;
            this.urbHistory.TabStop = true;
            this.urbHistory.Text = "History";
            this.urbHistory.UseVisualStyleBackColor = true;
            // 
            // urbSciFi
            // 
            this.urbSciFi.AutoSize = true;
            this.urbSciFi.Location = new System.Drawing.Point(29, 163);
            this.urbSciFi.Name = "urbSciFi";
            this.urbSciFi.Size = new System.Drawing.Size(64, 21);
            this.urbSciFi.TabIndex = 3;
            this.urbSciFi.TabStop = true;
            this.urbSciFi.Text = "Sci-Fi";
            this.urbSciFi.UseVisualStyleBackColor = true;
            // 
            // urbComedy
            // 
            this.urbComedy.AutoSize = true;
            this.urbComedy.Location = new System.Drawing.Point(29, 118);
            this.urbComedy.Name = "urbComedy";
            this.urbComedy.Size = new System.Drawing.Size(80, 21);
            this.urbComedy.TabIndex = 2;
            this.urbComedy.TabStop = true;
            this.urbComedy.Text = "Comedy";
            this.urbComedy.UseVisualStyleBackColor = true;
            // 
            // urbRomance
            // 
            this.urbRomance.AutoSize = true;
            this.urbRomance.Location = new System.Drawing.Point(29, 78);
            this.urbRomance.Name = "urbRomance";
            this.urbRomance.Size = new System.Drawing.Size(89, 21);
            this.urbRomance.TabIndex = 1;
            this.urbRomance.TabStop = true;
            this.urbRomance.Text = "Romance";
            this.urbRomance.UseVisualStyleBackColor = true;
            // 
            // urbFantasy
            // 
            this.urbFantasy.AutoSize = true;
            this.urbFantasy.Location = new System.Drawing.Point(29, 44);
            this.urbFantasy.Name = "urbFantasy";
            this.urbFantasy.Size = new System.Drawing.Size(79, 21);
            this.urbFantasy.TabIndex = 0;
            this.urbFantasy.TabStop = true;
            this.urbFantasy.Text = "Fantasy";
            this.urbFantasy.UseVisualStyleBackColor = true;
            // 
            // utbTitle
            // 
            this.utbTitle.Location = new System.Drawing.Point(155, 81);
            this.utbTitle.Name = "utbTitle";
            this.utbTitle.Size = new System.Drawing.Size(200, 22);
            this.utbTitle.TabIndex = 26;
            // 
            // utbMovieID
            // 
            this.utbMovieID.Location = new System.Drawing.Point(155, 37);
            this.utbMovieID.Name = "utbMovieID";
            this.utbMovieID.Size = new System.Drawing.Size(200, 22);
            this.utbMovieID.TabIndex = 25;
            // 
            // lbEarnings
            // 
            this.lbEarnings.AutoSize = true;
            this.lbEarnings.Location = new System.Drawing.Point(76, 302);
            this.lbEarnings.Name = "lbEarnings";
            this.lbEarnings.Size = new System.Drawing.Size(81, 17);
            this.lbEarnings.TabIndex = 24;
            this.lbEarnings.Text = "MilEarnings";
            // 
            // lbDuration
            // 
            this.lbDuration.AutoSize = true;
            this.lbDuration.Location = new System.Drawing.Point(76, 254);
            this.lbDuration.Name = "lbDuration";
            this.lbDuration.Size = new System.Drawing.Size(62, 17);
            this.lbDuration.TabIndex = 23;
            this.lbDuration.Text = "Duration";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(76, 200);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(38, 17);
            this.lbYear.TabIndex = 22;
            this.lbYear.Text = "Year";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(76, 138);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(57, 17);
            this.lbCountry.TabIndex = 21;
            this.lbCountry.Text = "Country";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(76, 86);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(35, 17);
            this.lbTitle.TabIndex = 20;
            this.lbTitle.Text = "Title";
            // 
            // lbMovieID
            // 
            this.lbMovieID.AutoSize = true;
            this.lbMovieID.Location = new System.Drawing.Point(76, 37);
            this.lbMovieID.Name = "lbMovieID";
            this.lbMovieID.Size = new System.Drawing.Size(58, 17);
            this.lbMovieID.TabIndex = 19;
            this.lbMovieID.Text = "MovieID";
            // 
            // FrmUpdateMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.utbEarn);
            this.Controls.Add(this.lbProgressBar);
            this.Controls.Add(this.upbSuccess);
            this.Controls.Add(this.utbEarnings);
            this.Controls.Add(this.unupdDuration);
            this.Controls.Add(this.udtpYear);
            this.Controls.Add(this.bUpdateMovie);
            this.Controls.Add(this.ucbCountry);
            this.Controls.Add(this.ugbGenre);
            this.Controls.Add(this.utbTitle);
            this.Controls.Add(this.utbMovieID);
            this.Controls.Add(this.lbEarnings);
            this.Controls.Add(this.lbDuration);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbMovieID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUpdateMovies";
            this.Text = "MovieBase/UpdateMovie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmUpdateMovies_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.utbEarnings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unupdDuration)).EndInit();
            this.ugbGenre.ResumeLayout(false);
            this.ugbGenre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox utbEarn;
        private System.Windows.Forms.Label lbProgressBar;
        private System.Windows.Forms.ProgressBar upbSuccess;
        private System.Windows.Forms.TrackBar utbEarnings;
        private System.Windows.Forms.NumericUpDown unupdDuration;
        private System.Windows.Forms.DateTimePicker udtpYear;
        private System.Windows.Forms.Button bUpdateMovie;
        private System.Windows.Forms.ComboBox ucbCountry;
        private System.Windows.Forms.GroupBox ugbGenre;
        private System.Windows.Forms.RadioButton urbMusical;
        private System.Windows.Forms.RadioButton urbAdventure;
        private System.Windows.Forms.RadioButton urbBiography;
        private System.Windows.Forms.RadioButton urbHistory;
        private System.Windows.Forms.RadioButton urbSciFi;
        private System.Windows.Forms.RadioButton urbComedy;
        private System.Windows.Forms.RadioButton urbRomance;
        private System.Windows.Forms.RadioButton urbFantasy;
        private System.Windows.Forms.TextBox utbTitle;
        private System.Windows.Forms.TextBox utbMovieID;
        private System.Windows.Forms.Label lbEarnings;
        private System.Windows.Forms.Label lbDuration;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbMovieID;
    }
}