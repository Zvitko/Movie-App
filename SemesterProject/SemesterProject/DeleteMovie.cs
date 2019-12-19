using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SemesterProject
{
    public partial class DeleteMovie : Form
    {

//Drop down selections
        string[] GenreTypes = { "Animation", "Action", "Comdey", "Drama", "Horror", "Mystery", "Romance", "Science Fiction", "Western" };

        public DeleteMovie()
        {
            InitializeComponent();
        }

//Find button to search database for an existing movie
        private void DmFind_Click(object sender, EventArgs e)
        {
            Finder();
        }

//Delete Movie from database Button
//Will also call Finder method to see if the movie exists in the database
//Will also check to see if any required textboxes are empty before deleting the movie and before exiting
        private void DmUpdate_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            string deleteTitle = DeleteMovieTitle();

            if (DmMovieTitle.Text == "")
            {
                MessageBox.Show("Please insert a Movie Title.");
            }
            else if (DmMovieTitle.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Are you positive that you wish to delete this movie?","Delete Movie", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    main.deleteMovie(deleteTitle);
                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

//Clear textboxes button
        private void DmClear_Click(object sender, EventArgs e)
        {
            DmMovieTitle.Text = String.Empty;
            DmYear.Text = String.Empty;
            DmDirector.Text = String.Empty;
            DmRTS.Text = String.Empty;
            DmBOE.Text = String.Empty;
            DmGenre.SelectedIndex = -1;
        }

//Close Form Button
        private void DmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

//Title Textbox
        private void DmMovieTitle_TextChanged(object sender, EventArgs e)
        {
            DeleteMovieTitle();
        }

//Year Textbox
        private void DmYear_TextChanged(object sender, EventArgs e)
        {

        }

//Director Textbox
        private void DmDirector_TextChanged(object sender, EventArgs e)
        {

        }

//Genre Dropdown Textbox
//Called upon GenreSelection to display the options
        private void DmGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenreSelection();
        }

//Rotten Tomatoes Score Textbox
        private void DmRTS_TextChanged(object sender, EventArgs e)
        {
           
        }

//Total Earned Textbox
        private void DmBOE_TextChanged(object sender, EventArgs e)
        {
          
        }

//Returns Movie Title String to Title Textbox that will delete the movie in the database
        public String DeleteMovieTitle()
        {
            string deleteMovieTitle;
            deleteMovieTitle = Convert.ToString(DmMovieTitle.Text);
            return deleteMovieTitle;
        }

//Open conection to database to connect the Genre options to the array above
        public void GenreSelection()
        {
            Form1 main = new Form1();
            string sqlCommand = "SELECT [Genre] FROM [Movies] ORDER BY [Genre]";
            string connectionString = main.connecting();

            List<Movies> movies = new List<Movies>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string Animation = GenreTypes[0];
                            string Action = GenreTypes[1];
                            string Comedy = GenreTypes[2];
                            string Drama = GenreTypes[3];
                            string Horror = GenreTypes[4];
                            string Mystery = GenreTypes[5];
                            string Romance = GenreTypes[6];
                            string ScienceFiction = GenreTypes[7];
                            string Western = GenreTypes[8];
                        }
                        reader.Close();
                    }
                }
            }
        }

//Conects to the databse to see if the Movie that is trying to be deleted exists
        private bool Finder()
        {
            bool MovieWasFound = false;

            string connectionString = "Data Source=coursemaster1.csbchotp6tva.us-east-2.rds.amazonaws.com,1433;Initial Catalog=CSCI1630;User ID=rw1630;Password=Project!";
            string sqlCommand = "SELECT TOP 1 Title, Year, Director, Genre, RottenTomatoesScore, TotalEarned FROM Movies Where[Title] LIKE '%' + @SearchBox + '%'";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                    {
                        connection.Open();
                        var sqlParams = new SqlParameter[]
                        {
                            new SqlParameter("@SearchBox", DmMovieTitle.Text)
                        };
                        command.Parameters.AddRange(sqlParams);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var movies = new Movies();

                                DmMovieTitle.Text = reader["Title"].ToString();
                                DmYear.Text = reader["Year"].ToString();
                                DmDirector.Text = reader["Director"].ToString();
                                movies.GenreNum = reader.GetInt32(reader.GetOrdinal("Genre"));
                                DmGenre.Text = movies.Genre;
                                DmRTS.Text = reader["RottenTomatoesScore"].ToString();
                                DmBOE.Text = reader["TotalEarned"].ToString();

                                MovieWasFound = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Movie Does Not Exist in Database. Error {ex.Message}");
            }
            if(MovieWasFound == false)
            {
                MessageBox.Show("Movie Does Not Exist in Database.");

            }
            return MovieWasFound;
        }
    }
}