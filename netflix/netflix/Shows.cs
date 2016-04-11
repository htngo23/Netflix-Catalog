using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netflix
{
    class Shows:Title
    {
        //        Show(inherits from Title)
        //-    Contains a list of Episodes
        //-    Overrides parent’s Rating to return an aggregated rating of Episode ratings
        //-    Overrides ToString() method to return a string of the name of the show and number of episodes
        
 
        public List<Episodes> series;
        public int numEpisodes;

        public int showRating;
        public int amount;

        public Shows(string Name)
        {
            name = Name;
            series = new List<Episodes>();
             
            
            ToString();
        }

        public new int rating
        {
            get
            {
                return showRating;
            }
            set
            {
                foreach(Episodes ep in series)
                {
                    amount = rating;
                }
                showRating = amount / series.Count;
            }
        }
        public override string ToString()
        {
            string info = string.Format(name + " has rating of " + showRating);
            return info;
        }
    }
}

        
        
            
            
                  
