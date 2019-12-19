namespace SemesterProject
{
    partial class DeleteMovie
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
            this.DmFind = new System.Windows.Forms.Button();
            this.DmClose = new System.Windows.Forms.Button();
            this.DmClear = new System.Windows.Forms.Button();
            this.DmUpdate = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.DmBOE = new System.Windows.Forms.TextBox();
            this.DmRTS = new System.Windows.Forms.TextBox();
            this.DmGenre = new System.Windows.Forms.ComboBox();
            this.DmDirector = new System.Windows.Forms.TextBox();
            this.DmYear = new System.Windows.Forms.TextBox();
            this.DmMovieTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DmFind
            // 
            this.DmFind.Location = new System.Drawing.Point(594, 61);
            this.DmFind.Name = "DmFind";
            this.DmFind.Size = new System.Drawing.Size(83, 30);
            this.DmFind.TabIndex = 52;
            this.DmFind.Text = "Find";
            this.DmFind.UseVisualStyleBackColor = true;
            this.DmFind.Click += new System.EventHandler(this.DmFind_Click);
            // 
            // DmClose
            // 
            this.DmClose.Location = new System.Drawing.Point(635, 342);
            this.DmClose.Name = "DmClose";
            this.DmClose.Size = new System.Drawing.Size(83, 30);
            this.DmClose.TabIndex = 51;
            this.DmClose.Text = "Close";
            this.DmClose.UseVisualStyleBackColor = true;
            this.DmClose.Click += new System.EventHandler(this.DmClose_Click);
            // 
            // DmClear
            // 
            this.DmClear.Location = new System.Drawing.Point(157, 342);
            this.DmClear.Name = "DmClear";
            this.DmClear.Size = new System.Drawing.Size(83, 30);
            this.DmClear.TabIndex = 50;
            this.DmClear.Text = "Clear";
            this.DmClear.UseVisualStyleBackColor = true;
            this.DmClear.Click += new System.EventHandler(this.DmClear_Click);
            // 
            // DmUpdate
            // 
            this.DmUpdate.Location = new System.Drawing.Point(28, 342);
            this.DmUpdate.Name = "DmUpdate";
            this.DmUpdate.Size = new System.Drawing.Size(83, 30);
            this.DmUpdate.TabIndex = 49;
            this.DmUpdate.Text = "Delete";
            this.DmUpdate.UseVisualStyleBackColor = true;
            this.DmUpdate.Click += new System.EventHandler(this.DmUpdate_Click);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox6.Location = new System.Drawing.Point(7, 326);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(727, 67);
            this.textBox6.TabIndex = 48;
            // 
            // DmBOE
            // 
            this.DmBOE.Location = new System.Drawing.Point(560, 284);
            this.DmBOE.Name = "DmBOE";
            this.DmBOE.Size = new System.Drawing.Size(158, 22);
            this.DmBOE.TabIndex = 47;
            this.DmBOE.TextChanged += new System.EventHandler(this.DmBOE_TextChanged);
            // 
            // DmRTS
            // 
            this.DmRTS.Location = new System.Drawing.Point(322, 284);
            this.DmRTS.Name = "DmRTS";
            this.DmRTS.Size = new System.Drawing.Size(90, 22);
            this.DmRTS.TabIndex = 46;
            this.DmRTS.TextChanged += new System.EventHandler(this.DmRTS_TextChanged);
            // 
            // DmGenre
            // 
            this.DmGenre.FormattingEnabled = true;
            this.DmGenre.Items.AddRange(new object[] {
            "Animation",
            "Action",
            "Comedy",
            "Drama",
            "Horror",
            "Mystery",
            "Romance",
            "Science Fiction",
            "Western"});
            this.DmGenre.Location = new System.Drawing.Point(157, 234);
            this.DmGenre.Name = "DmGenre";
            this.DmGenre.Size = new System.Drawing.Size(159, 24);
            this.DmGenre.TabIndex = 45;
            this.DmGenre.SelectedIndexChanged += new System.EventHandler(this.DmGenre_SelectedIndexChanged);
            // 
            // DmDirector
            // 
            this.DmDirector.Location = new System.Drawing.Point(157, 177);
            this.DmDirector.Name = "DmDirector";
            this.DmDirector.Size = new System.Drawing.Size(260, 22);
            this.DmDirector.TabIndex = 44;
            this.DmDirector.TextChanged += new System.EventHandler(this.DmDirector_TextChanged);
            // 
            // DmYear
            // 
            this.DmYear.Location = new System.Drawing.Point(157, 119);
            this.DmYear.Name = "DmYear";
            this.DmYear.Size = new System.Drawing.Size(159, 22);
            this.DmYear.TabIndex = 43;
            this.DmYear.TextChanged += new System.EventHandler(this.DmYear_TextChanged);
            // 
            // DmMovieTitle
            // 
            this.DmMovieTitle.Location = new System.Drawing.Point(157, 63);
            this.DmMovieTitle.Name = "DmMovieTitle";
            this.DmMovieTitle.Size = new System.Drawing.Size(397, 22);
            this.DmMovieTitle.TabIndex = 42;
            this.DmMovieTitle.TextChanged += new System.EventHandler(this.DmMovieTitle_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 17);
            this.label7.TabIndex = 41;
            this.label7.Text = "Box Office Earnings:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "Rotten Tomatoes Score:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Genre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Director:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Movie Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Delete Movie Screen";
            // 
            // DeleteMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 405);
            this.Controls.Add(this.DmFind);
            this.Controls.Add(this.DmClose);
            this.Controls.Add(this.DmClear);
            this.Controls.Add(this.DmUpdate);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.DmBOE);
            this.Controls.Add(this.DmRTS);
            this.Controls.Add(this.DmGenre);
            this.Controls.Add(this.DmDirector);
            this.Controls.Add(this.DmYear);
            this.Controls.Add(this.DmMovieTitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeleteMovie";
            this.Text = "DeleteMovie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DmFind;
        private System.Windows.Forms.Button DmClose;
        private System.Windows.Forms.Button DmClear;
        private System.Windows.Forms.Button DmUpdate;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox DmBOE;
        private System.Windows.Forms.TextBox DmRTS;
        private System.Windows.Forms.ComboBox DmGenre;
        private System.Windows.Forms.TextBox DmDirector;
        private System.Windows.Forms.TextBox DmYear;
        private System.Windows.Forms.TextBox DmMovieTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}