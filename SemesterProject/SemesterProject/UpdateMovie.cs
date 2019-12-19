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
    public partial class UpdateMovie : Form
    {

//Drop down selections
        string[] GenreTypes = { "Animation", "Action", "Comdey", "Drama", "Horror", "Mystery", "Romance", "Science Fiction", "Western" };

        public UpdateMovie()
        {
            InitializeComponent();
        }


//Find button to search database for an existing movie
        private void UmFind_Click(object sender, EventArgs e)
        {
            Finder();
        }

//Clear textboxes button
        private void UmClear_Click(object sender, EventArgs e)
        {
            UmMovieTitle.Text = String.Empty;
            UmYear.Text = String.Empty;
            UmDirector.Text = String.Empty;
            UmRTS.Text = String.Empty;
            UmBOE.Text = String.Empty;
            UmGenre.SelectedIndex = -1;
        }

//Update Movie from database Button
//Will also call Finder method to see if the movie exists in the database
//Will also check to see if any required textboxes are empty before updating the movie and before exiting
        private void UmUpdate_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            string newTitle = UpdateMovieTitle();
            int newYear = UpdateMovieYear();
            string newDirector = UpdateMovieDir();
            int newGenre = UpdateGenre();
            int newRTS = UpdateRTS();
            Decimal newBOE = UpdateBOE();

            if (UmMovieTitle.Text == "")
            {
                MessageBox.Show("Please insert a Movie Title.");
            }
            if (UpdateMovieYear() == 0)
            {
                MessageBox.Show("Please Insert a Valid Year.");
            }
            if (UmDirector.Text == "")
            {
                MessageBox.Show("Please insert a Director.");
            }
            if (UmGenre.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Genre.");
            }
            else if (UmMovieTitle.Text != "" && UpdateMovieYear() != 0 && UmDirector.Text != "" && UmGenre.SelectedIndex != -1)
            {
                main.updateMovie(newTitle, newYear, newDirector, newGenre, newRTS, newBOE);
                this.Close();
            }
        }

//Close Form Button
        private void UmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

//Title Textbox
        private void UmMovieTitle_TextChanged(object sender, EventArgs e)
        {
            UpdateMovieTitle();
        }

//Year Textbox
        private void UmYear_TextChanged(object sender, EventArgs e)
        {
            UpdateMovieYear();
        }

//Director Textbox
        private void UmDirector_TextChanged(object sender, EventArgs e)
        {
            UpdateMovieDir();
        }

//Genre Dropdown Textbox
//Called upon GenreSelection to display the options
        private void UmGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenreSelection();
            UpdateGenre();
        }

//Rotten Tomatoes Textbox
        private void UmRTS_TextChanged(object sender, EventArgs e)
        {
            UpdateRTS();
        }

//Total Earned Textbox
        private void UmBOE_TextChanged(object sender, EventArgs e)
        {
            UpdateBOE();
        }

//Returns Movie Title String to Title Textbox that will update the movie in the database
        public String UpdateMovieTitle()
        {
            string updateMovieTitle;
            updateMovieTitle = Convert.ToString(UmMovieTitle.Text);
            return updateMovieTitle;
        }

//Returns Movie Year String (from int) to Year Textbox that will update the movie in the database
        public int UpdateMovieYear()
        {
            int updateMovieYear;
            bool year = Int32.TryParse(UmYear.Text, out updateMovieYear);

            if (year == false)
            {
                return 0;
            }
            else
            {
                return updateMovieYear;
            }
        }

//Returns Movie Direcotr String to Director Textbox that will update the movie in the database
        public String UpdateMovieDir()
        {
            string updateMovieDir;
            updateMovieDir = Convert.ToString(UmDirector.Text);
            return updateMovieDir;
        }

//Returns Movie Genre Int to Genre Dropdown Textbox that will update the movie in the database
        public int UpdateGenre()
        {
            int updateGenre = Convert.ToInt32(UmGenre.SelectedIndex);
            return updateGenre;
        }

//Returns Rotten Tomatoes Score string (from int) to Rotten Tomatoes Score Textbox that will update the movie in the database
        public int UpdateRTS()
        {
            int updateRTS;
            updateRTS = Convert.ToInt32(UmRTS.Text);
            if (UmRTS.Text != null)
            {
                return updateRTS;
            }
            else
            {
                return updateRTS = 0;
            }
        }

//Returns Total Earned String (from int) to Total Earned textbox that will update the movie in the database
        public Decimal UpdateBOE()
        {
            Decimal updateBOE;
            updateBOE = Convert.ToDecimal(UmBOE.Text);
            if (UmBOE.Text != null)
            {
                return updateBOE;
            }
            else
            {
                return updateBOE = 0;
            }
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

//Conects to the databse to see if the Movie that is trying to be updated exists
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
                            new SqlParameter("@SearchBox", UmMovieTitle.Text)
                        };
                        command.Parameters.AddRange(sqlParams);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var movies = new Movies();

                                UmMovieTitle.Text = reader["Title"].ToString();
                                UmYear.Text = reader["Year"].ToString();
                                UmDirector.Text = reader["Director"].ToString();
                                movies.GenreNum = reader.GetInt32(reader.GetOrdinal("Genre"));
                                UmGenre.Text = movies.Genre;
                                UmRTS.Text = reader["RottenTomatoesScore"].ToString();
                                UmBOE.Text = reader["TotalEarned"].ToString();

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
            if (MovieWasFound == false)
            {
                MessageBox.Show("Movie Does Not Exist in Database");

            }

            return MovieWasFound;

        }
    }
}
