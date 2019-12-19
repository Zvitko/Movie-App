namespace SemesterProject
{
    partial class AboutPage
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
            this.AboutTB = new System.Windows.Forms.RichTextBox();
            this.AboutClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AboutTB
            // 
            this.AboutTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AboutTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutTB.Location = new System.Drawing.Point(18, 20);
            this.AboutTB.Name = "AboutTB";
            this.AboutTB.ReadOnly = true;
            this.AboutTB.Size = new System.Drawing.Size(519, 217);
            this.AboutTB.TabIndex = 0;
            this.AboutTB.TabStop = false;
            this.AboutTB.Text = "";
            this.AboutTB.TextChanged += new System.EventHandler(this.AboutTB_TextChanged);
            // 
            // AboutClose
            // 
            this.AboutClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AboutClose.Location = new System.Drawing.Point(448, 243);
            this.AboutClose.Name = "AboutClose";
            this.AboutClose.Size = new System.Drawing.Size(89, 27);
            this.AboutClose.TabIndex = 1;
            this.AboutClose.Text = "Close";
            this.AboutClose.UseVisualStyleBackColor = true;
            this.AboutClose.Click += new System.EventHandler(this.AboutClose_Click);
            // 
            // AboutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 294);
            this.Controls.Add(this.AboutClose);
            this.Controls.Add(this.AboutTB);
            this.Name = "AboutPage";
            this.Text = "About";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox AboutTB;
        private System.Windows.Forms.Button AboutClose;
    }
}