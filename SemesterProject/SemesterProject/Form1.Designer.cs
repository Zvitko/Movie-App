namespace SemesterProject
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRefreshListFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExitFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMaintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RottenTomatoesScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalEarned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuMaintenance,
            this.mnuAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1113, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRefreshListFile,
            this.mnuExitFile});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(46, 24);
            this.mnuFile.Text = "File";
            // 
            // mnuRefreshListFile
            // 
            this.mnuRefreshListFile.Name = "mnuRefreshListFile";
            this.mnuRefreshListFile.Size = new System.Drawing.Size(167, 26);
            this.mnuRefreshListFile.Text = "Refresh List";
            this.mnuRefreshListFile.Click += new System.EventHandler(this.MnuRefreshListFile_Click);
            // 
            // mnuExitFile
            // 
            this.mnuExitFile.Name = "mnuExitFile";
            this.mnuExitFile.Size = new System.Drawing.Size(167, 26);
            this.mnuExitFile.Text = "Exit";
            this.mnuExitFile.Click += new System.EventHandler(this.MnuExitFile_Click);
            // 
            // mnuMaintenance
            // 
            this.mnuMaintenance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddMovie,
            this.mnuUpdateMovie,
            this.mnuDeleteMovie});
            this.mnuMaintenance.Name = "mnuMaintenance";
            this.mnuMaintenance.Size = new System.Drawing.Size(108, 24);
            this.mnuMaintenance.Text = "Maintenance";
            // 
            // mnuAddMovie
            // 
            this.mnuAddMovie.Name = "mnuAddMovie";
            this.mnuAddMovie.Size = new System.Drawing.Size(186, 26);
            this.mnuAddMovie.Text = "Add Movie";
            this.mnuAddMovie.Click += new System.EventHandler(this.MnuAddMovie_Click);
            // 
            // mnuUpdateMovie
            // 
            this.mnuUpdateMovie.Name = "mnuUpdateMovie";
            this.mnuUpdateMovie.Size = new System.Drawing.Size(186, 26);
            this.mnuUpdateMovie.Text = "Update Movie";
            this.mnuUpdateMovie.Click += new System.EventHandler(this.MnuUpdateMovie_Click);
            // 
            // mnuDeleteMovie
            // 
            this.mnuDeleteMovie.Name = "mnuDeleteMovie";
            this.mnuDeleteMovie.Size = new System.Drawing.Size(186, 26);
            this.mnuDeleteMovie.Text = "Delete Movie";
            this.mnuDeleteMovie.Click += new System.EventHandler(this.MnuDeleteMovie_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(64, 24);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.MnuAbout_Click);
            // 
            // dgvMovies
            // 
            this.dgvMovies.AllowUserToAddRows = false;
            this.dgvMovies.AllowUserToDeleteRows = false;
            this.dgvMovies.AllowUserToOrderColumns = true;
            this.dgvMovies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Year,
            this.Director,
            this.Genre,
            this.RottenTomatoesScore,
            this.TotalEarned});
            this.dgvMovies.Location = new System.Drawing.Point(12, 31);
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.ReadOnly = true;
            this.dgvMovies.RowHeadersWidth = 51;
            this.dgvMovies.RowTemplate.Height = 24;
            this.dgvMovies.Size = new System.Drawing.Size(1089, 407);
            this.dgvMovies.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 125;
            // 
            // Year
            // 
            this.Year.HeaderText = "Year";
            this.Year.MinimumWidth = 6;
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            this.Year.Width = 125;
            // 
            // Director
            // 
            this.Director.HeaderText = "Director";
            this.Director.MinimumWidth = 6;
            this.Director.Name = "Director";
            this.Director.ReadOnly = true;
            this.Director.Width = 125;
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.MinimumWidth = 6;
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            this.Genre.Width = 125;
            // 
            // RottenTomatoesScore
            // 
            this.RottenTomatoesScore.HeaderText = "Rotten Tomatoes Score";
            this.RottenTomatoesScore.MinimumWidth = 6;
            this.RottenTomatoesScore.Name = "RottenTomatoesScore";
            this.RottenTomatoesScore.ReadOnly = true;
            this.RottenTomatoesScore.Width = 125;
            // 
            // TotalEarned
            // 
            this.TotalEarned.HeaderText = "Total Box Office";
            this.TotalEarned.MinimumWidth = 6;
            this.TotalEarned.Name = "TotalEarned";
            this.TotalEarned.ReadOnly = true;
            this.TotalEarned.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 450);
            this.Controls.Add(this.dgvMovies);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Movie Manager Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuRefreshListFile;
        private System.Windows.Forms.ToolStripMenuItem mnuExitFile;
        private System.Windows.Forms.ToolStripMenuItem mnuMaintenance;
        private System.Windows.Forms.ToolStripMenuItem mnuAddMovie;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateMovie;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteMovie;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Director;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn RottenTomatoesScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalEarned;
    }
}

