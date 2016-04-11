using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netflix
{
    class Catalouge
    {
        Genre All = new Genre();
       Genre Action = new Genre();
        Genre TV = new Genre();
        Genre Comedy = new Genre();
        Genre Romance = new Genre();

        Movies starskyandHutch = new Movies(90, "Starsky and Hutch", 4);
        Movies disturbia = new Movies(120, "Disturbia", 4.5);
        Movies inTime = new Movies(100, "In Time", 4);
        Movies akira = new Movies(150, "Akira", 5);

        Movies definatelyMaybe = new Movies(125, "Definately, Maybe", 5);
        Movies forgettingSarah = new Movies(110, "Forgetting Sarah Marshall", 3.5);
        Movies goneGirl = new Movies(150, "Gone Girl", 4);
        Movies crazyStupidLove = new Movies(130, "Crazy, Stupid, Love", 4.2);

        Movies howHigh = new Movies(100, "How High", 4);
        Movies superBad = new Movies(115, "Super Bad", 3.5);
        Movies pineappleExpress = new Movies(135, "Pineapple Express", 5);
        Movies weddingCrashers = new Movies(140, "The Wedding Crashers", 3.9);

        Shows gameofThrones = new Shows("Game of Thrones");
        Shows dragonBallZ = new Shows("DragonBall z");

        Shows rickandMorty = new Shows("Rick and Morty");
        Shows onePunchMan = new Shows("One Punch Man");
        Shows curbYourEnthusiam = new Shows("Curb Your Enthusiasm");

        Shows friends = new Shows("Friends");
        Shows midoriDays = new Shows("Midori Days");
        


        public void addToCollections()
        {
            Action.titles.Add(starskyandHutch);
            Action.titles.Add(disturbia);
            Action.titles.Add(inTime);
            Action.titles.Add(akira);
            Romance.titles.Add(definatelyMaybe);
            Romance.titles.Add(forgettingSarah);
            Romance.titles.Add(goneGirl);
            Romance.titles.Add(crazyStupidLove);
            Comedy.titles.Add(howHigh);
            Comedy.titles.Add(superBad);
            Comedy.titles.Add(pineappleExpress);
            Comedy.titles.Add(weddingCrashers);

            gOT();
            DBZ();
            rickandMort();
            onePunch();
            friendz();
            curbYour();
          
        }

        public void printAction()
        {
            foreach(Title title in Action)
            {
                Console.WriteLine(title.ToString());
            }
        }
        public void printComedy()
        {
            foreach(Title title in Comedy)
            {
                Console.WriteLine(title.ToString());
            }
        }
        public void printRomance()
        {
            foreach(Title title in Romance)
            {
                Console.WriteLine(title.ToString());
            }
        }            
        public void createActionComedy()
        {
            Genre ActionComedy = Action + Comedy;
            foreach(Title title in ActionComedy)
            {
                Console.WriteLine(title.name + " has a rating of " + title.rating);
            }
        } 
        public void createActionRomance()
        {
            Genre ActionRomance = Action + Romance;
            foreach(Title title in ActionRomance)
            {
                Console.WriteLine((title.name + " has a rating of " + title.rating));

            }
        }                  
        public void createComedyRomance()
        {
            Genre ComedyRomance = Comedy + Romance;
            foreach(Title title in ComedyRomance)
            {
                Console.WriteLine((title.name + " has a rating of " + title.rating));
            }
        }
        public void tvShows()
        {
            foreach(Shows tvShow in TV)
            {
                Console.WriteLine(tvShow.ToString());
            }
        } 
        public void gOT()
        {
            TV.titles.Add(gameofThrones);
            Episodes highSparrow = new Episodes(4);
            Episodes lordSnow = new Episodes(5);
            gameofThrones.series.Add(highSparrow);
            gameofThrones.series.Add(lordSnow);
        }
        public void DBZ()
        {
            TV.titles.Add(dragonBallZ);
            Episodes androids = new Episodes(4);
            Episodes vegeta = new Episodes(3);
            Episodes beerusWhis = new Episodes(5);
            dragonBallZ.series.Add(androids);
            dragonBallZ.series.Add(vegeta);
            dragonBallZ.series.Add(beerusWhis);
        }
        public void rickandMort()
        {
            TV.titles.Add(rickandMorty);
            Episodes getSchwifty = new Episodes(5);
            Episodes meeseeksandDestory = new Episodes(5);
            Episodes purge = new Episodes(5);
            rickandMorty.series.Add(getSchwifty);
            rickandMorty.series.Add(meeseeksandDestory);
            rickandMorty.series.Add(purge);
        }
        public void onePunch()
        {
            TV.titles.Add(onePunchMan);
            Episodes genos = new Episodes(5);
            Episodes one = new Episodes(4);
            Episodes battleForEarth = new Episodes(4);
            onePunchMan.series.Add(genos);
            onePunchMan.series.Add(one);
            onePunchMan.series.Add(battleForEarth);
        }
        public void friendz()
        {
            TV.titles.Add(friends);
            Episodes withTheMonkey = new Episodes(2);
            Episodes dozenLasagnas = new Episodes(3);
            Episodes stonedGuy = new Episodes(3);
            friends.series.Add(withTheMonkey);
            friends.series.Add(dozenLasagnas);
            friends.series.Add(stonedGuy);
        }
        public void midori()
        {
            TV.titles.Add(midoriDays);
            Episodes midori1 = new Episodes(2);
            Episodes midori2 = new Episodes(3);
            Episodes midori3 = new Episodes(5);
            midoriDays.series.Add(midori1);
            midoriDays.series.Add(midori2);
            midoriDays.series.Add(midori3);
        }
        public void curbYour()
        {
            TV.titles.Add(curbYourEnthusiam);
            Episodes theHero = new Episodes(3);
            Episodes theLeftyCall = new Episodes(4);
            Episodes theWood = new Episodes(4);
            curbYourEnthusiam.series.Add(theHero);
            curbYourEnthusiam.series.Add(theLeftyCall);
            curbYourEnthusiam.series.Add(theWood);
        }
    }
}




