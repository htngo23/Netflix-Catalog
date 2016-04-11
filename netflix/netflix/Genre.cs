using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace netflix
{
    class Genre:IEnumerable
    {
        //        Genre
        //-    Contains a list of Titles
        //-    Implement custom iterator to iterate over those Titles
        //-    Overload plus(+) operator to take in two Genres and return the aggregated Genre.
        //o For example, if we want to create an aggregated genre Romantic Comedy, all the film titles in that specific genre would include film titles from Romance and film titles from Comedy.
        //-    Overload plus (+) operator to take in a Genre and a Title to return the aggregated Genre.
        //o Take in a title, add it to the genre, return an aggregated list.
        //o For example, title Die Hard and genre Comedy would return a list of all comedy films and Die Hard.
        //-    Create the genres: All, Romance, Action, Comedy.They need to share some titles(such as Romantic Comedies) by reference, not by duplicating the title itself.


        public List<Title> titles;
        public Genre()
        {
            titles = new List<Title>();
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Title title in titles)
            {
                //Console.WriteLine(name.name);
                //Console.WriteLine(name.rating + "/5");
                //Console.WriteLine(name.duration + "minutes");
                //Console.WriteLine("");
                yield return title;
            }
        }

        public static Genre operator +(Genre genre1, Genre genre2)
        {
            Genre newGenre = new Genre();
            newGenre.titles.AddRange(genre1.titles);
            newGenre.titles.AddRange(genre2.titles);
            return newGenre;
        }
        public static Genre operator +(Genre genre1, Title title)
        {
            Genre newGenreTitle = new Genre();
            newGenreTitle.titles.AddRange(newGenreTitle.titles);
            newGenreTitle.titles.Add(title);
            return newGenreTitle;
        }

    }
}



