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
    public partial class AddMovie : Form
    {

//Drop down selections
        string[] GenreTypes = { "Animation", "Action", "Comdey", "Drama", "Horror", "Mystery", "Romance", "Science Fiction", "Western" };

        public AddMovie()
        {
            InitializeComponent();
        }

//Close Form Button
        private void AddMovieClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

//Clear textboxes button
        private void AddMovieClear_Click(object sender, EventArgs e)
        {
            AmMovieTitle.Text = String.Empty;
            AmYear.Text = String.Empty;
            AmDirector.Text = String.Empty;
            AmRTS.Text = String.Empty;
            AmBOE.Text = String.Empty;
            AddMovieGenre.SelectedIndex = -1;
        }

//Add Movie to database Button
//Will also call Finder method to see if the movie exists in the database already
//Will also check to see if any required textboxes are empty before adding new movie and before exiting
        private void AddMovieAdd_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            string insertTitle = AddMovieTitle();
            int insertYear = AddMovieYear();
            string insertDirector = AddMovieDir();
            int insertGenre = AddGenre();
            int insertRTS = AddRTS();
            Decimal insertBOE = AddBOE();

            if (Finder() == true)
            {
                MessageBox.Show("Movie Already Exists in Database");
            }
            if(AmMovieTitle.Text == "")
            {
                MessageBox.Show("Please insert a Movie Title.");
            }
            if (AddMovieYear() == 0)
            {
                MessageBox.Show("Please Insert a Valid Year.");
            }
            if (AmDirector.Text == "")
            {
                MessageBox.Show("Please insert a Director.");
            }
            if(AddMovieGenre.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Genre.");
            }
            else if(AmMovieTitle.Text != "" && AddMovieYear() != 0 && AmDirector.Text != "" && AddMovieGenre.SelectedIndex != -1)
            {
                main.addMovie(insertTitle, insertYear, insertDirector, insertGenre, insertRTS, insertBOE);
                this.Close();
            }
        }

//Title Textbox
        private void AmMovieTitle_TextChanged(object sender, EventArgs e)
        {
            AddMovieTitle();
        }

//Year Textbox
        private void AmYear_TextChanged(object sender, EventArgs e)
        {
            AddMovieYear();
        }

//Director Textbox
        private void AmDirector_TextChanged(object sender, EventArgs e)
        {
            AddMovieDir();
        }

//Rotten Tomatoes Score Textbox
        private void AmRTS_TextChanged(object sender, EventArgs e)
        {
            AddRTS();
        }

//Total Earned Textbox
        private void AmBOE_TextChanged(object sender, EventArgs e)
        {
            AddBOE();
        }

//Genre Dropdown Textbox
//Called upon GenreSelection to display the options
        private void AddMovieGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenreSelection();
            AddGenre();
        }

//Returns Movie Title String to Title Textbox that will be added to database
        public String AddMovieTitle()
        {
            string addMovieTitle;
            addMovieTitle = Convert.ToString(AmMovieTitle.Text);
            return addMovieTitle;
        }

//Returns Movie Year String (from int) to Year textbox that will be added to database
        public int AddMovieYear()
        {
            int addMovieYear;
            bool year = Int32.TryParse(AmYear.Text, out addMovieYear);

            if (year == false)
            {
                return 0;
            }
            else
            {
                return addMovieYear;
            }
            
        }

//Returns Movie Director String to Director Textbox that will be added to database
        public String AddMovieDir()
        {
            string addMovieDir;
            addMovieDir = Convert.ToString(AmDirector.Text);
            return addMovieDir;
        }

//Returns Movie Genre Int to Genre Dropdown textbox that will be added to database
        public int AddGenre()
        {
            int AddGenre = Convert.ToInt32(AddMovieGenre.SelectedIndex);
            return AddGenre;
        }

//Returns Rotten Tomatoes Score string (from int) to Rotten Tomatoes Score Textbox that will be added to database
        public int AddRTS()
        {
            int addRTS;
            bool RTS = Int32.TryParse(AmRTS.Text, out addRTS);

            if (RTS == false)
            {
                return 0;
            }
            else
            {
                return addRTS;
            }
        }

//Returns Total Earned String (from int) to Total Earned textbox that will be added to the database
        public Decimal AddBOE()
        {
            Decimal addBOE;
            bool BOE = Decimal.TryParse(AmBOE.Text, out addBOE);

            if (BOE == false)
            {
                return 0;
            }
            else
            {
                return addBOE;
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

//Conects to the databse to see if the Movie that is trying to be added already exists
        private bool Finder()
        {
            bool movieWasFound = false;

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
                            new SqlParameter("@SearchBox", AmMovieTitle.Text)
                        };
                        command.Parameters.AddRange(sqlParams);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var movies = new Movies();

                                AmMovieTitle.Text = reader["Title"].ToString();

                                movieWasFound = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return movieWasFound;
        }
    }
}