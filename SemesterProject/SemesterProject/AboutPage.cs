using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SemesterProject
{
    public partial class AboutPage : Form
    {

//Connects RichtextBox to the MMA.rtf work file under Semester Project
        public AboutPage()
        {
            InitializeComponent();
            AboutTB.LoadFile("..\\..\\MMA.rtf");

        }

//RichTextBox
        private void AboutTB_TextChanged(object sender, EventArgs e)
        {

        }

//Close Form Button 
        private void AboutClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
