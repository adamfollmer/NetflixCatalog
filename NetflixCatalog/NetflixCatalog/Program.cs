using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            TemporaryTitleList thing = new TemporaryTitleList();
            thing.AddShows();
            Console.WriteLine(thing.dieHard.ToString());
            Console.ReadLine();






            //Genre<Movie> action = new Genre<Movie>();
            // Genre<Movie> comedy = new Genre<Movie>();
            // Genre<Movie> romance = new Genre<Movie>();
            //foreach (Movie newMovie in action)
           // {
             //   Console.WriteLine("Hello");
           // }
        }
    }
}
