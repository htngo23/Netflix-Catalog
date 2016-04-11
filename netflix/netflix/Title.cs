using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netflix
{
    class Title
    {
//        Title
//-    Name field
//-    Rating field
//-    Overload plus(+) operator to take in two Titles and return an aggregated Genre
//-    Offer two overloaded constructors: one that takes in all the fields and sets them, another that takes in no fields and sets the internal fields to null.

        public string name;
        public double? rating;


    public Title(string name, double rating)
        {
            name = "";
            rating = 0;
        }
           
        public Title()
        {
            name = null;
            rating = null;
        } 
    }
}
