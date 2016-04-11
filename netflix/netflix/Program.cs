using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netflix
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalouge cat = new Catalouge();
            View display = new View();

            display.Menu();
            
            Console.ReadLine();
        }
    }
}
