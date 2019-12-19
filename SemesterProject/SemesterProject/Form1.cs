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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

//Connect to Database and Obtain all movies
        private List<Movies> GetListOfMovies()
        {

            string connectionString = "Data Source=coursemaster1.csbchotp6tva.us-east-2.rds.amazonaws.com,1433;Initial Catalog=CSCI1630;User ID=rw1630;Password=Project!";
            List<Movies> movie = new List<Movies>();
            string sqlCommand = "SELECT  Id, Title,  Year , Director, Genre, RottenTomatoesScore, TotalEarned  FROM  Movies  ORDER   BY  Title";

           
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var movies = new Movies();

                                movies.ID = reader.GetInt32(0);

                                movies.Title = reader.GetString(1);

                                movies.Year = reader.GetInt32(2);

                                movies.Director = reader.GetString(3);

                                movies.GenreNum = reader.GetInt32(4);


                                if (!reader.IsDBNull(5))
                                    movies.RottenTomatoesScore = reader.GetInt32(5);

                                if (!reader.IsDBNull(6))
                                    movies.TotalEarned = reader.GetDecimal(6);

                                movie.Add(movies);
                            }
                        }
                        connection.Close();
                    }
                }
            return movie;
        }

//Fill in movies from database to the Datagridview
        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=coursemaster1.csbchotp6tva.us-east-2.rds.amazonaws.com,1433;Initial Catalog=CSCI1630;User ID=rw1630;Password=Project!";
            List<Movies> movie = new List<Movies>();
            string sqlCommand = "SELECT  Id, Title,  Year , Director, Genre, RottenTomatoesScore, TotalEarned  FROM  Movies  ORDER   BY  Title";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                    {
                        connection.Open();
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var movies = new Movies();

                                movies.ID = reader.GetInt32(0);

                                movies.Title = reader.GetString(1);

                                movies.Year = reader.GetInt32(2);

                                movies.Director = reader.GetString(3);

                                movies.GenreNum = reader.GetInt32(4);

                                if (!reader.IsDBNull(5))
                                    movies.RottenTomatoesScore = reader.GetInt32(5);

                                if(!reader.IsDBNull(6))
                                    movies.TotalEarned = reader.GetDecimal(6);

                                movie.Add(movies);
                            }
                        }
                        connection.Close();
                        FillData(movie);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database connection faled. Error {ex.Message}");
            }
        }

//Adds the rows of new movies in datagridview
        private void FillData(List<Movies> movies)
        {

            foreach(var item in movies)
            {
                dgvMovies.Rows.Add(new object[] { item.Title, item.Year, item.Director, item.Genre, item.RottenTomatoesScore, item.TotalEarned.ToString("C") });
            }

        }

//Refresh Button to fill in the datagridview with any newly added, updated, or deleted movies
        private void MnuRefreshListFile_Click(object sender, EventArgs e)
        {
            dgvMovies.Rows.Clear();
            List<Movies> movies = GetListOfMovies();
            FillData(movies);
        }

//Exit Button
        private void MnuExitFile_Click(object sender, EventArgs e)
        {
            this.Close();
        }

//Go to the AddMovie Form to add a movie
        private void MnuAddMovie_Click(object sender, EventArgs e)
        {
            AddMovie addMovie = new AddMovie();
            addMovie.ShowDialog();
        }

//Go to the UpdateMovie form to update an existing movie
        private void MnuUpdateMovie_Click(object sender, EventArgs e)
        {
            UpdateMovie updateMovie = new UpdateMovie();
            updateMovie.ShowDialog();
        }

//Go to DeleteMovie form to delete an existing movie
        private void MnuDeleteMovie_Click(object sender, EventArgs e)
        {
            DeleteMovie deleteMovie = new DeleteMovie();
            deleteMovie.ShowDialog();
        }

//Go to AboutPage dialogue box
//To edut AboutPage, go to MMA.rtf file under Semester Project Folder
        private void MnuAbout_Click(object sender, EventArgs e)
        {
            AboutPage aboutPage = new AboutPage();
            aboutPage.ShowDialog();
        }

//Connection to database
        public string connecting()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "coursemaster1.csbchotp6tva.us-east-2.rds.amazonaws.com,1433";
            builder.InitialCatalog = "CSCI1630";
            builder.UserID = "rw1630";
            builder.Password = "Project!";
            return builder.ConnectionString;
        }

//Adding a movie to the database
//Called from AddMovie Form
        public int addMovie(String Title, int Year, String Director, int GenreNum, int RottenTomatoesScore, Decimal TotalEarned)
        {
            string sqlCommand = "INSERT INTO Movies (Title, Year, Director, Genre, RottenTomatoesScore, TotalEarned)" + "VALUES (@Title, @Year, @Director, @Genre, @RottenTomatoesScore, @TotalEarned)";

            string connectionString = connecting();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    command.Parameters.AddWithValue("@Title", Title);
                    command.Parameters.Add("Year", SqlDbType.Int).Value = Year;
                    command.Parameters.Add("Director", SqlDbType.VarChar, 256).Value = Director;
                    command.Parameters.Add("Genre", SqlDbType.Int).Value = GenreNum;
                    command.Parameters.Add("RottenTomatoesScore", SqlDbType.Int).Value = RottenTomatoesScore;
                    command.Parameters.Add("TotalEarned", SqlDbType.Decimal).Value = TotalEarned;

                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }

//Deleting a movie from the database
//Called from DeleteMovie Form
        public int deleteMovie(String Title)
        {
            string sqlCommand = "Delete from Movies where Title = @Title";

            string connectionString = connecting();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    command.Parameters.AddWithValue("@Title", Title);

                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }

//Updating a movie from the Database
//Called from UpdateMovie Form
        public int updateMovie(String Title, int Year, String Director, int GenreNum, int RottenTomatoesScore, Decimal TotalEarned)
        {
            string sqlCommand = "UPDATE Movies SET Year = @Year, Director = @Director, Genre = @Genre, RottenTomatoesScore = @RottenTomatoesScore, TotalEarned = @TotalEarned WHERE Title = @Title";

            string connectionString = connecting();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    command.Parameters.Add("@Title", SqlDbType.VarChar, 256).Value = Title;
                    command.Parameters.Add("@Year", SqlDbType.Int).Value = Year;
                    command.Parameters.Add("@Director", SqlDbType.VarChar, 256).Value = Director;
                    command.Parameters.Add("@Genre", SqlDbType.Int).Value = GenreNum;
                    command.Parameters.Add("@RottenTomatoesScore", SqlDbType.Int).Value = RottenTomatoesScore;
                    command.Parameters.Add("@TotalEarned", SqlDbType.Decimal).Value = TotalEarned;

                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }
    }
}
