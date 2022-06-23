namespace FrmBazaFilme
{
    partial class FrmAddMovies
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
            this.lbMovieID = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.lbDuration = new System.Windows.Forms.Label();
            this.lbEarnings = new System.Windows.Forms.Label();
            this.tbMovieID = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.gbGenre = new System.Windows.Forms.GroupBox();
            this.rbMusical = new System.Windows.Forms.RadioButton();
            this.rbAdventure = new System.Windows.Forms.RadioButton();
            this.rbBiography = new System.Windows.Forms.RadioButton();
            this.rbHistory = new System.Windows.Forms.RadioButton();
            this.rbSciFi = new System.Windows.Forms.RadioButton();
            this.rbComedy = new System.Windows.Forms.RadioButton();
            this.rbRomance = new System.Windows.Forms.RadioButton();
            this.rbFantasy = new System.Windows.Forms.RadioButton();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.bAddMovie = new System.Windows.Forms.Button();
            this.dtpYear = new System.Windows.Forms.DateTimePicker();
            this.nupdDuration = new System.Windows.Forms.NumericUpDown();
            this.tbEarnings = new System.Windows.Forms.TrackBar();
            this.pbSuccess = new System.Windows.Forms.ProgressBar();
            this.lbProgressBar = new System.Windows.Forms.Label();
            this.tbEarn = new System.Windows.Forms.TextBox();
            this.gbGenre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEarnings)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMovieID
            // 
            this.lbMovieID.AutoSize = true;
            this.lbMovieID.Location = new System.Drawing.Point(40, 38);
            this.lbMovieID.Name = "lbMovieID";
            this.lbMovieID.Size = new System.Drawing.Size(58, 17);
            this.lbMovieID.TabIndex = 0;
            this.lbMovieID.Text = "MovieID";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(40, 87);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(35, 17);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Title";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(40, 139);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(57, 17);
            this.lbCountry.TabIndex = 3;
            this.lbCountry.Text = "Country";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(40, 201);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(38, 17);
            this.lbYear.TabIndex = 4;
            this.lbYear.Text = "Year";
            // 
            // lbDuration
            // 
            this.lbDuration.AutoSize = true;
            this.lbDuration.Location = new System.Drawing.Point(40, 255);
            this.lbDuration.Name = "lbDuration";
            this.lbDuration.Size = new System.Drawing.Size(62, 17);
            this.lbDuration.TabIndex = 5;
            this.lbDuration.Text = "Duration";
            // 
            // lbEarnings
            // 
            this.lbEarnings.AutoSize = true;
            this.lbEarnings.Location = new System.Drawing.Point(40, 303);
            this.lbEarnings.Name = "lbEarnings";
            this.lbEarnings.Size = new System.Drawing.Size(81, 17);
            this.lbEarnings.TabIndex = 6;
            this.lbEarnings.Text = "MilEarnings";
            // 
            // tbMovieID
            // 
            this.tbMovieID.Location = new System.Drawing.Point(119, 38);
            this.tbMovieID.Name = "tbMovieID";
            this.tbMovieID.Size = new System.Drawing.Size(200, 22);
            this.tbMovieID.TabIndex = 7;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(119, 82);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(200, 22);
            this.tbTitle.TabIndex = 8;
            // 
            // gbGenre
            // 
            this.gbGenre.Controls.Add(this.rbMusical);
            this.gbGenre.Controls.Add(this.rbAdventure);
            this.gbGenre.Controls.Add(this.rbBiography);
            this.gbGenre.Controls.Add(this.rbHistory);
            this.gbGenre.Controls.Add(this.rbSciFi);
            this.gbGenre.Controls.Add(this.rbComedy);
            this.gbGenre.Controls.Add(this.rbRomance);
            this.gbGenre.Controls.Add(this.rbFantasy);
            this.gbGenre.Location = new System.Drawing.Point(393, 38);
            this.gbGenre.Name = "gbGenre";
            this.gbGenre.Size = new System.Drawing.Size(295, 190);
            this.gbGenre.TabIndex = 9;
            this.gbGenre.TabStop = false;
            this.gbGenre.Text = "Genre";
            // 
            // rbMusical
            // 
            this.rbMusical.AutoSize = true;
            this.rbMusical.Location = new System.Drawing.Point(179, 163);
            this.rbMusical.Name = "rbMusical";
            this.rbMusical.Size = new System.Drawing.Size(76, 21);
            this.rbMusical.TabIndex = 7;
            this.rbMusical.TabStop = true;
            this.rbMusical.Text = "Musical";
            this.rbMusical.UseVisualStyleBackColor = true;
            // 
            // rbAdventure
            // 
            this.rbAdventure.AutoSize = true;
            this.rbAdventure.Location = new System.Drawing.Point(179, 118);
            this.rbAdventure.Name = "rbAdventure";
            this.rbAdventure.Size = new System.Drawing.Size(94, 21);
            this.rbAdventure.TabIndex = 6;
            this.rbAdventure.TabStop = true;
            this.rbAdventure.Text = "Adventure";
            this.rbAdventure.UseVisualStyleBackColor = true;
            // 
            // rbBiography
            // 
            this.rbBiography.AutoSize = true;
            this.rbBiography.Location = new System.Drawing.Point(179, 78);
            this.rbBiography.Name = "rbBiography";
            this.rbBiography.Size = new System.Drawing.Size(93, 21);
            this.rbBiography.TabIndex = 5;
            this.rbBiography.TabStop = true;
            this.rbBiography.Text = "Biography";
            this.rbBiography.UseVisualStyleBackColor = true;
            // 
            // rbHistory
            // 
            this.rbHistory.AutoSize = true;
            this.rbHistory.Location = new System.Drawing.Point(179, 45);
            this.rbHistory.Name = "rbHistory";
            this.rbHistory.Size = new System.Drawing.Size(73, 21);
            this.rbHistory.TabIndex = 4;
            this.rbHistory.TabStop = true;
            this.rbHistory.Text = "History";
            this.rbHistory.UseVisualStyleBackColor = true;
            // 
            // rbSciFi
            // 
            this.rbSciFi.AutoSize = true;
            this.rbSciFi.Location = new System.Drawing.Point(29, 163);
            this.rbSciFi.Name = "rbSciFi";
            this.rbSciFi.Size = new System.Drawing.Size(64, 21);
            this.rbSciFi.TabIndex = 3;
            this.rbSciFi.TabStop = true;
            this.rbSciFi.Text = "Sci-Fi";
            this.rbSciFi.UseVisualStyleBackColor = true;
            // 
            // rbComedy
            // 
            this.rbComedy.AutoSize = true;
            this.rbComedy.Location = new System.Drawing.Point(29, 118);
            this.rbComedy.Name = "rbComedy";
            this.rbComedy.Size = new System.Drawing.Size(80, 21);
            this.rbComedy.TabIndex = 2;
            this.rbComedy.TabStop = true;
            this.rbComedy.Text = "Comedy";
            this.rbComedy.UseVisualStyleBackColor = true;
            // 
            // rbRomance
            // 
            this.rbRomance.AutoSize = true;
            this.rbRomance.Location = new System.Drawing.Point(29, 78);
            this.rbRomance.Name = "rbRomance";
            this.rbRomance.Size = new System.Drawing.Size(89, 21);
            this.rbRomance.TabIndex = 1;
            this.rbRomance.TabStop = true;
            this.rbRomance.Text = "Romance";
            this.rbRomance.UseVisualStyleBackColor = true;
            // 
            // rbFantasy
            // 
            this.rbFantasy.AutoSize = true;
            this.rbFantasy.Location = new System.Drawing.Point(29, 44);
            this.rbFantasy.Name = "rbFantasy";
            this.rbFantasy.Size = new System.Drawing.Size(79, 21);
            this.rbFantasy.TabIndex = 0;
            this.rbFantasy.TabStop = true;
            this.rbFantasy.Text = "Fantasy";
            this.rbFantasy.UseVisualStyleBackColor = true;
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Items.AddRange(new object[] {
            "USA",
            "UK",
            "Italia",
            "France",
            "Romania"});
            this.cbCountry.Location = new System.Drawing.Point(119, 139);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(200, 24);
            this.cbCountry.TabIndex = 10;
            // 
            // bAddMovie
            // 
            this.bAddMovie.Location = new System.Drawing.Point(261, 362);
            this.bAddMovie.Name = "bAddMovie";
            this.bAddMovie.Size = new System.Drawing.Size(125, 52);
            this.bAddMovie.TabIndex = 11;
            this.bAddMovie.Text = "ADD MOVIE";
            this.bAddMovie.UseVisualStyleBackColor = true;
            this.bAddMovie.Click += new System.EventHandler(this.bAddMovie_Click);
            // 
            // dtpYear
            // 
            this.dtpYear.CustomFormat = "yyyy";
            this.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpYear.Location = new System.Drawing.Point(119, 196);
            this.dtpYear.MaxDate = new System.DateTime(2022, 8, 1, 0, 0, 0, 0);
            this.dtpYear.MinDate = new System.DateTime(1942, 1, 1, 0, 0, 0, 0);
            this.dtpYear.Name = "dtpYear";
            this.dtpYear.Size = new System.Drawing.Size(200, 22);
            this.dtpYear.TabIndex = 13;
            this.dtpYear.Value = new System.DateTime(2022, 7, 7, 0, 0, 0, 0);
            // 
            // nupdDuration
            // 
            this.nupdDuration.Location = new System.Drawing.Point(119, 253);
            this.nupdDuration.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nupdDuration.Minimum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.nupdDuration.Name = "nupdDuration";
            this.nupdDuration.Size = new System.Drawing.Size(200, 22);
            this.nupdDuration.TabIndex = 14;
            this.nupdDuration.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // tbEarnings
            // 
            this.tbEarnings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbEarnings.Location = new System.Drawing.Point(119, 303);
            this.tbEarnings.Maximum = 1500;
            this.tbEarnings.Name = "tbEarnings";
            this.tbEarnings.Size = new System.Drawing.Size(213, 56);
            this.tbEarnings.TabIndex = 15;
            this.tbEarnings.Scroll += new System.EventHandler(this.tbEarnings_Scroll);
            // 
            // pbSuccess
            // 
            this.pbSuccess.Location = new System.Drawing.Point(393, 313);
            this.pbSuccess.Name = "pbSuccess";
            this.pbSuccess.Size = new System.Drawing.Size(243, 23);
            this.pbSuccess.TabIndex = 16;
            // 
            // lbProgressBar
            // 
            this.lbProgressBar.AutoSize = true;
            this.lbProgressBar.Location = new System.Drawing.Point(390, 278);
            this.lbProgressBar.Name = "lbProgressBar";
            this.lbProgressBar.Size = new System.Drawing.Size(154, 17);
            this.lbProgressBar.TabIndex = 17;
            this.lbProgressBar.Text = "Procentage of Success";
            // 
            // tbEarn
            // 
            this.tbEarn.Location = new System.Drawing.Point(43, 323);
            this.tbEarn.Name = "tbEarn";
            this.tbEarn.Size = new System.Drawing.Size(78, 22);
            this.tbEarn.TabIndex = 18;
            // 
            // FrmAddMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbEarn);
            this.Controls.Add(this.lbProgressBar);
            this.Controls.Add(this.pbSuccess);
            this.Controls.Add(this.tbEarnings);
            this.Controls.Add(this.nupdDuration);
            this.Controls.Add(this.dtpYear);
            this.Controls.Add(this.bAddMovie);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.gbGenre);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.tbMovieID);
            this.Controls.Add(this.lbEarnings);
            this.Controls.Add(this.lbDuration);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbMovieID);
            this.Name = "FrmAddMovies";
            this.Text = "MovieBase/AddNewMovie";
            this.gbGenre.ResumeLayout(false);
            this.gbGenre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEarnings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMovieID;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label lbDuration;
        private System.Windows.Forms.Label lbEarnings;
        private System.Windows.Forms.TextBox tbMovieID;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.GroupBox gbGenre;
        private System.Windows.Forms.RadioButton rbMusical;
        private System.Windows.Forms.RadioButton rbAdventure;
        private System.Windows.Forms.RadioButton rbBiography;
        private System.Windows.Forms.RadioButton rbHistory;
        private System.Windows.Forms.RadioButton rbSciFi;
        private System.Windows.Forms.RadioButton rbComedy;
        private System.Windows.Forms.RadioButton rbRomance;
        private System.Windows.Forms.RadioButton rbFantasy;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Button bAddMovie;
        private System.Windows.Forms.DateTimePicker dtpYear;
        private System.Windows.Forms.NumericUpDown nupdDuration;
        private System.Windows.Forms.TrackBar tbEarnings;
        private System.Windows.Forms.ProgressBar pbSuccess;
        private System.Windows.Forms.Label lbProgressBar;
        private System.Windows.Forms.TextBox tbEarn;
    }
}