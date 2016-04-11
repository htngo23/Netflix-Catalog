using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netflix
{
    class View
    {
        Catalouge display = new Catalouge();

        public void Menu()
        {
            display.addToCollections();

            bool meow = true;
            while (meow)
            {
                
                Console.WriteLine("What genre would you like to view?");
                Console.WriteLine("Input 1 for Action Movies");
                Console.WriteLine("Input 2 for Comedy Movies");
                Console.WriteLine("Input 3 for Romance Movies");
                Console.WriteLine("Input 4 for Aggregated genres");
                Console.WriteLine("Input 5 to view all tv series");
                Console.WriteLine("Input 6 to end program");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        display.printAction();

                        break;
                    case "2":
                        display.printComedy();
                        break;
                    case "3":
                        display.printRomance();
                        break;
                    case "4":
                        Console.WriteLine("Input 1 to view Action Comedy");
                        Console.WriteLine("Input 2 to view Action Romance");
                        Console.WriteLine("Input 3 to view Comedic Romance");
                        string choose = Console.ReadLine();
                        switch (choose)
                        {
                            case "1":
                                display.createActionComedy();
                                break;
                            case "2":
                                display.createActionRomance();
                                break;
                            case "3":
                                display.createComedyRomance();
                                break;
                            default:
                                Menu();
                                break;
                        }
                        break;
                    case "5":
                        display.tvShows();
                        break;
                    case "6":
                        meow = false;
                        break;
                    default:
                        Menu();
                        break;
                }
            }

        }
    }
}
