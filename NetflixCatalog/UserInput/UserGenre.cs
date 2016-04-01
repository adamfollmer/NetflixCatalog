using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetflixCatalog;

namespace UserInput
{
    class UserGenre
    {
        View menu;
        Menu userMenu;
        public UserGenre(View menu, Menu userMenu)
        {
            this.menu = menu;
            this.userMenu = userMenu;
        }
        public void PrintGenre()
        {
            int i = 1;
            foreach(Genre genre in menu.GenreList)
            {
                Console.WriteLine("{0}. {1}", i, genre.CombinedGenre);
                i++;
            }
        }
    }
}
