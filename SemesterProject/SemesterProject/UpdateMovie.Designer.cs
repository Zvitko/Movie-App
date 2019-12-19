namespace SemesterProject
{
    partial class UpdateMovie
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
            this.UmClose = new System.Windows.Forms.Button();
            this.UmClear = new System.Windows.Forms.Button();
            this.UmUpdate = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.UmBOE = new System.Windows.Forms.TextBox();
            this.UmRTS = new System.Windows.Forms.TextBox();
            this.UmGenre = new System.Windows.Forms.ComboBox();
            this.UmDirector = new System.Windows.Forms.TextBox();
            this.UmYear = new System.Windows.Forms.TextBox();
            this.UmMovieTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UmFind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UmClose
            // 
            this.UmClose.Location = new System.Drawing.Point(635, 342);
            this.UmClose.Name = "UmClose";
            this.UmClose.Size = new System.Drawing.Size(83, 30);
            this.UmClose.TabIndex = 33;
            this.UmClose.Text = "Close";
            this.UmClose.UseVisualStyleBackColor = true;
            this.UmClose.Click += new System.EventHandler(this.UmClose_Click);
            // 
            // UmClear
            // 
            this.UmClear.Location = new System.Drawing.Point(157, 342);
            this.UmClear.Name = "UmClear";
            this.UmClear.Size = new System.Drawing.Size(83, 30);
            this.UmClear.TabIndex = 32;
            this.UmClear.Text = "Clear";
            this.UmClear.UseVisualStyleBackColor = true;
            this.UmClear.Click += new System.EventHandler(this.UmClear_Click);
            // 
            // UmUpdate
            // 
            this.UmUpdate.Location = new System.Drawing.Point(28, 342);
            this.UmUpdate.Name = "UmUpdate";
            this.UmUpdate.Size = new System.Drawing.Size(83, 30);
            this.UmUpdate.TabIndex = 31;
            this.UmUpdate.Text = "Update";
            this.UmUpdate.UseVisualStyleBackColor = true;
            this.UmUpdate.Click += new System.EventHandler(this.UmUpdate_Click);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox6.Location = new System.Drawing.Point(7, 326);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(727, 67);
            this.textBox6.TabIndex = 30;
            // 
            // UmBOE
            // 
            this.UmBOE.Location = new System.Drawing.Point(560, 284);
            this.UmBOE.Name = "UmBOE";
            this.UmBOE.Size = new System.Drawing.Size(158, 22);
            this.UmBOE.TabIndex = 29;
            this.UmBOE.TextChanged += new System.EventHandler(this.UmBOE_TextChanged);
            // 
            // UmRTS
            // 
            this.UmRTS.Location = new System.Drawing.Point(322, 284);
            this.UmRTS.Name = "UmRTS";
            this.UmRTS.Size = new System.Drawing.Size(90, 22);
            this.UmRTS.TabIndex = 28;
            this.UmRTS.TextChanged += new System.EventHandler(this.UmRTS_TextChanged);
            // 
            // UmGenre
            // 
            this.UmGenre.FormattingEnabled = true;
            this.UmGenre.Items.AddRange(new object[] {
            "Animation",
            "Action",
            "Comedy",
            "Drama",
            "Horror",
            "Mystery",
            "Romance",
            "Science Fiction",
            "Western"});
            this.UmGenre.Location = new System.Drawing.Point(157, 234);
            this.UmGenre.Name = "UmGenre";
            this.UmGenre.Size = new System.Drawing.Size(159, 24);
            this.UmGenre.TabIndex = 27;
            this.UmGenre.SelectedIndexChanged += new System.EventHandler(this.UmGenre_SelectedIndexChanged);
            // 
            // UmDirector
            // 
            this.UmDirector.Location = new System.Drawing.Point(157, 177);
            this.UmDirector.Name = "UmDirector";
            this.UmDirector.Size = new System.Drawing.Size(260, 22);
            this.UmDirector.TabIndex = 26;
            this.UmDirector.TextChanged += new System.EventHandler(this.UmDirector_TextChanged);
            // 
            // UmYear
            // 
            this.UmYear.Location = new System.Drawing.Point(157, 119);
            this.UmYear.Name = "UmYear";
            this.UmYear.Size = new System.Drawing.Size(159, 22);
            this.UmYear.TabIndex = 25;
            this.UmYear.TextChanged += new System.EventHandler(this.UmYear_TextChanged);
            // 
            // UmMovieTitle
            // 
            this.UmMovieTitle.Location = new System.Drawing.Point(157, 63);
            this.UmMovieTitle.Name = "UmMovieTitle";
            this.UmMovieTitle.Size = new System.Drawing.Size(397, 22);
            this.UmMovieTitle.TabIndex = 24;
            this.UmMovieTitle.TextChanged += new System.EventHandler(this.UmMovieTitle_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Box Office Earnings:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Rotten Tomatoes Score:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Genre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Director:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Movie Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Update Movie Screen";
            // 
            // UmFind
            // 
            this.UmFind.Location = new System.Drawing.Point(594, 61);
            this.UmFind.Name = "UmFind";
            this.UmFind.Size = new System.Drawing.Size(83, 30);
            this.UmFind.TabIndex = 34;
            this.UmFind.Text = "Find";
            this.UmFind.UseVisualStyleBackColor = true;
            this.UmFind.Click += new System.EventHandler(this.UmFind_Click);
            // 
            // UpdateMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 405);
            this.Controls.Add(this.UmFind);
            this.Controls.Add(this.UmClose);
            this.Controls.Add(this.UmClear);
            this.Controls.Add(this.UmUpdate);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.UmBOE);
            this.Controls.Add(this.UmRTS);
            this.Controls.Add(this.UmGenre);
            this.Controls.Add(this.UmDirector);
            this.Controls.Add(this.UmYear);
            this.Controls.Add(this.UmMovieTitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateMovie";
            this.Text = "Update Movie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UmClose;
        private System.Windows.Forms.Button UmClear;
        private System.Windows.Forms.Button UmUpdate;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox UmBOE;
        private System.Windows.Forms.TextBox UmRTS;
        private System.Windows.Forms.ComboBox UmGenre;
        private System.Windows.Forms.TextBox UmDirector;
        private System.Windows.Forms.TextBox UmYear;
        private System.Windows.Forms.TextBox UmMovieTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UmFind;
    }
}