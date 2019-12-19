using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProject
{
    class Movies
    {
        //SELECT  Id, Title,  Year , Director, Genre, RottenTomatoesScore, TotalEarned  FROM  Movies  ORDER   BY  Title
        public int ID { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        private int genreNum;
        public int GenreNum {
            get
            {
                return this.genreNum;
            }

            set
            {
                this.genreNum = value;
                if(value == 0)
                {
                    Genre = "Animation";
                }
                else if(value == 1)
                {
                    Genre = "Action";
                }
                else if (value == 2)
                {
                    Genre = "Comedy";
                }
                else if (value == 3)
                {
                    Genre = "Drama";
                }
                else if (value == 4)
                {
                    Genre = "Horror";
                }
                else if (value == 5)
                {
                    Genre = "Mystery";
                }
                else if (value == 6)
                {
                    Genre = "Romance";
                }
                else if (value == 7)
                {
                    Genre = "Science Fiction";
                }
                else if (value == 8)
                {
                    Genre = "Western";
                }
                else
                {
                    Genre = "";
                }
            }
        }
        public int RottenTomatoesScore { get; set; }
        public decimal TotalEarned { get; set; }
    }
}
