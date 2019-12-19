namespace SemesterProject
{
    partial class AddMovie
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AmMovieTitle = new System.Windows.Forms.TextBox();
            this.AmYear = new System.Windows.Forms.TextBox();
            this.AmDirector = new System.Windows.Forms.TextBox();
            this.AddMovieGenre = new System.Windows.Forms.ComboBox();
            this.AmRTS = new System.Windows.Forms.TextBox();
            this.AmBOE = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.AddMovieAdd = new System.Windows.Forms.Button();
            this.AddMovieClear = new System.Windows.Forms.Button();
            this.AddMovieClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Movie Screen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Movie Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Director:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Genre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Rotten Tomatoes Score:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Box Office Earnings:";
            // 
            // AmMovieTitle
            // 
            this.AmMovieTitle.Location = new System.Drawing.Point(157, 66);
            this.AmMovieTitle.Name = "AmMovieTitle";
            this.AmMovieTitle.Size = new System.Drawing.Size(397, 22);
            this.AmMovieTitle.TabIndex = 7;
            this.AmMovieTitle.TextChanged += new System.EventHandler(this.AmMovieTitle_TextChanged);
            // 
            // AmYear
            // 
            this.AmYear.Location = new System.Drawing.Point(157, 122);
            this.AmYear.Name = "AmYear";
            this.AmYear.Size = new System.Drawing.Size(159, 22);
            this.AmYear.TabIndex = 8;
            this.AmYear.TextChanged += new System.EventHandler(this.AmYear_TextChanged);
            // 
            // AmDirector
            // 
            this.AmDirector.Location = new System.Drawing.Point(157, 180);
            this.AmDirector.Name = "AmDirector";
            this.AmDirector.Size = new System.Drawing.Size(260, 22);
            this.AmDirector.TabIndex = 9;
            this.AmDirector.TextChanged += new System.EventHandler(this.AmDirector_TextChanged);
            // 
            // AddMovieGenre
            // 
            this.AddMovieGenre.FormattingEnabled = true;
            this.AddMovieGenre.Items.AddRange(new object[] {
            "Animation",
            "Action",
            "Comedy",
            "Drama",
            "Horror",
            "Mystery",
            "Romance",
            "Science Fiction",
            "Western"});
            this.AddMovieGenre.Location = new System.Drawing.Point(157, 241);
            this.AddMovieGenre.Name = "AddMovieGenre";
            this.AddMovieGenre.Size = new System.Drawing.Size(159, 24);
            this.AddMovieGenre.TabIndex = 10;
            this.AddMovieGenre.SelectedIndexChanged += new System.EventHandler(this.AddMovieGenre_SelectedIndexChanged);
            // 
            // AmRTS
            // 
            this.AmRTS.Location = new System.Drawing.Point(322, 287);
            this.AmRTS.Name = "AmRTS";
            this.AmRTS.Size = new System.Drawing.Size(90, 22);
            this.AmRTS.TabIndex = 11;
            this.AmRTS.TextChanged += new System.EventHandler(this.AmRTS_TextChanged);
            // 
            // AmBOE
            // 
            this.AmBOE.Location = new System.Drawing.Point(560, 287);
            this.AmBOE.Name = "AmBOE";
            this.AmBOE.Size = new System.Drawing.Size(158, 22);
            this.AmBOE.TabIndex = 12;
            this.AmBOE.TextChanged += new System.EventHandler(this.AmBOE_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox6.Location = new System.Drawing.Point(7, 329);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(727, 67);
            this.textBox6.TabIndex = 13;
            // 
            // AddMovieAdd
            // 
            this.AddMovieAdd.Location = new System.Drawing.Point(28, 349);
            this.AddMovieAdd.Name = "AddMovieAdd";
            this.AddMovieAdd.Size = new System.Drawing.Size(83, 30);
            this.AddMovieAdd.TabIndex = 14;
            this.AddMovieAdd.Text = "Add";
            this.AddMovieAdd.UseVisualStyleBackColor = true;
            this.AddMovieAdd.Click += new System.EventHandler(this.AddMovieAdd_Click);
            // 
            // AddMovieClear
            // 
            this.AddMovieClear.Location = new System.Drawing.Point(157, 349);
            this.AddMovieClear.Name = "AddMovieClear";
            this.AddMovieClear.Size = new System.Drawing.Size(83, 30);
            this.AddMovieClear.TabIndex = 15;
            this.AddMovieClear.Text = "Clear";
            this.AddMovieClear.UseVisualStyleBackColor = true;
            this.AddMovieClear.Click += new System.EventHandler(this.AddMovieClear_Click);
            // 
            // AddMovieClose
            // 
            this.AddMovieClose.Location = new System.Drawing.Point(635, 349);
            this.AddMovieClose.Name = "AddMovieClose";
            this.AddMovieClose.Size = new System.Drawing.Size(83, 30);
            this.AddMovieClose.TabIndex = 16;
            this.AddMovieClose.Text = "Close";
            this.AddMovieClose.UseVisualStyleBackColor = true;
            this.AddMovieClose.Click += new System.EventHandler(this.AddMovieClose_Click);
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 405);
            this.Controls.Add(this.AddMovieClose);
            this.Controls.Add(this.AddMovieClear);
            this.Controls.Add(this.AddMovieAdd);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.AmBOE);
            this.Controls.Add(this.AmRTS);
            this.Controls.Add(this.AddMovieGenre);
            this.Controls.Add(this.AmDirector);
            this.Controls.Add(this.AmYear);
            this.Controls.Add(this.AmMovieTitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddMovie";
            this.Text = "Add Movie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AmMovieTitle;
        private System.Windows.Forms.TextBox AmYear;
        private System.Windows.Forms.TextBox AmDirector;
        private System.Windows.Forms.ComboBox AddMovieGenre;
        private System.Windows.Forms.TextBox AmRTS;
        private System.Windows.Forms.TextBox AmBOE;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button AddMovieAdd;
        private System.Windows.Forms.Button AddMovieClear;
        private System.Windows.Forms.Button AddMovieClose;
    }
}