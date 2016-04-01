using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetflixCatalog;

namespace UserInput
{
    public class Menu
    {
        View viewMenu = new View();
        UserMovie userMovie;
        UserShow userShow; 
        UserTitle userTitle;  
        UserGenre userGenre; 
        public Menu()
        {
            userMovie = new UserMovie(viewMenu, this);
            userShow = new UserShow(viewMenu, this);
            userTitle = new UserTitle(viewMenu, this);
            userGenre = new UserGenre(viewMenu, this);
        }
        public void RunProgram()
        {
            PrintMainMenu();
            SwitchForMenuChoice(NumbersOnlyCheck(10, 1, 10));
        }
        public void PrintMainMenu()
        {
            Console.WriteLine("Please select an option\n");
            Console.WriteLine("1. Add movie");
            Console.WriteLine("2. Add null movie");
            Console.WriteLine("3. Add show");
            Console.WriteLine("4. Add null show");
            Console.WriteLine("5. Add episode to show");
            Console.WriteLine("6. Combine two titles");
            Console.WriteLine("7. Combine two genres");
            Console.WriteLine("8. Combine a genre and a title");
            Console.WriteLine("9. Print a genre");
            Console.WriteLine("10. Exit program");
        }
        public int NumbersOnlyCheck(int exitOption, int lowEnd, int highEnd)
        {
            Console.WriteLine("Select a corresponding number");
            int userChoice = 0;
            while (userChoice != exitOption)
            {
                try
                {
                    userChoice = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (userChoice < lowEnd || userChoice > highEnd)
                    {
                        Console.WriteLine("[ERROR} Number does not match critera");
                        return NumbersOnlyCheck(exitOption, lowEnd, highEnd);
                    }
                    return userChoice;
                }
                catch (FormatException)
                {
                    Console.WriteLine("[ERROR] Only numbers");
                    return NumbersOnlyCheck(exitOption, lowEnd, highEnd);
                }
            }
            return userChoice;//worried about the recycle
        }
        public void SwitchForMenuChoice(int validMenuChoice)
        {
            switch (validMenuChoice)
            {
                case 1:
                    viewMenu.AddMovieToMovieList(userMovie.CreateMovie());
                    break;
                case 2:
                    viewMenu.AddMovieToMovieList(new Movie());
                    break;
                case 3:
                    viewMenu.AddShowtoShowList(userShow.CreateShow());
                    break;
                case 4:
                    viewMenu.AddShowtoShowList(new Show());
                    break;
                case 5:
                    Show holdShow = userShow.SelectShow();
                    Episode holdEpisode = userShow.CreateEpisode();
                    holdShow.AddEpisode(holdEpisode);
                    break;
                case 6:
                    userTitle.PrintTitle();
                    Title title1 = userTitle.SelectTitle();
                    userTitle.PrintTitle();
                    Title title2 = userTitle.SelectTitle();
                    viewMenu.AddGenreToGenreList(title1 + title2);
                    break;
                case 7:
                    userGenre.PrintGenre();
                    Genre genre1 = userGenre.SelectGenre();
                    userGenre.PrintGenre();
                    Genre genre2 = userGenre.SelectGenre();
                    viewMenu.AddGenreToGenreList(genre1 + genre2);
                    break;
                case 8:
                    userGenre.PrintGenre();
                    Genre genre = userGenre.SelectGenre();
                    userTitle.PrintTitle();
                    Title title = userTitle.SelectTitle();
                    viewMenu.AddGenreToGenreList(genre + title);
                    break;
                case 9:
                    userGenre.PrintGenre();
                    break;
                case 10:
                    Environment.Exit(1);
                    break;
                default:
                    break;
            }
        }
    }
}
