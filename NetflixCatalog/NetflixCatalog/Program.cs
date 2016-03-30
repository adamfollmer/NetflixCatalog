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
            Movie movie = new Movie();
            Genre<Movie> genre = new Genre<Movie>(movie);
            foreach (Movie newMovie in genre)
            {
                Console.WriteLine("Hello");
            }
        }
    }
}
