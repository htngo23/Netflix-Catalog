using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netflix
{
    class Movies:Title
    {
        //        Movie(Inherits from Title)
        //-    Duration field
        //-    Overrides ToString() method to return a string of the name and duration of the movie

        public double? duration;

        public Movies(double Duration, string Name, double Rating)
        {
            duration = Duration;
            name = Name;
            rating = Rating;

            ToString();
        }
        
        public override string ToString()
        {
            string movieTitle = String.Format(name + ", " + duration + " mins");
            //Console.WriteLine  (movieTitle);
            return movieTitle;
            
        }

      
    }
}
