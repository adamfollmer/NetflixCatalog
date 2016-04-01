using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetflixCatalog;

namespace UserInput
{
    class UserShow
    {
        View menu;
        Menu userMenu;
        public UserShow(View menu, Menu userMenu)
        {
            this.menu = menu;
            this.userMenu = userMenu;
        }
        public Show CreateShow()
        {
            return new Show();
        }
        public void PrintShow()
        {
            int i = 1;
            foreach(Show show in menu.ShowList)
            {
                Console.WriteLine("{0}. {1}", i, show.ToString());
                i++;
            }
        }
        public Show SelectShow()
        {
            int selectedShow = userMenu.NumbersOnlyCheck(5654, 1, menu.ShowList.Count);
            return menu.ShowList.ElementAt(selectedShow);
        }
        public Episode CreateEpisode()
        {
            Console.WriteLine("Enter in the episode name, then a rating 1-5");
            string episodeName = Console.ReadLine();
            int rating = userMenu.NumbersOnlyCheck(56865, 1, 5);
            return new Episode(rating, episodeName);
        }
    }
}
