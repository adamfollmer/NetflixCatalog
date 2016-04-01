using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetflixCatalog;

namespace UserInput
{
    class UserTitle
    {
        View menu;
        Menu userMenu;
        public UserTitle(View menu, Menu userMenu)
        {
            this.menu = menu;
            this.userMenu = userMenu;
        }
        public void PrintTitle()
        {
            int i = 1;
            foreach(Title title in menu.MasterTitleList)
            {
                Console.WriteLine("{0}. {1}",i, title._Name);
                i++;
            }
        }
        public Title SelectTitle()
        {
            int selectedTitle = userMenu.NumbersOnlyCheck(8956, 1, menu.MasterTitleList.Count);
            return menu.MasterTitleList.ElementAt(selectedTitle);
        }
    }
}
