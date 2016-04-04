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
            viewMenu.AddPremadeGenresToGenreList();
            viewMenu.AddPremadeTitlesToLists();
            while (true)
            {
                PrintMainMenu();
                SwitchForMenuChoice(NumbersOnlyCheck(10, 1, 10));
            } 
        }
        public void PrintMainMenu()
        {
            Console.WriteLine("Please select an option\n");
            Console.WriteLine("1. Add movie");
            Console.WriteLine("2. Print All Movies");
            Console.WriteLine("3. Add show");
            Console.WriteLine("4. Print All Shows");
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
            return userChoice;
        }
        public void SwitchForMenuChoice(int validMenuChoice)
        {
            switch (validMenuChoice)
            {
                case 1:
                    viewMenu.AddMovieToMovieList(userMovie.CreateMovie());
                    break;
                case 2:
                    userMovie.PrintMovie();
                    break;
                case 3:
                    viewMenu.AddShowtoShowList(userShow.CreateShow());
                    break;
                case 4:
                    userShow.PrintShowAndEpisode();
                    break;
                case 5:
                    userShow.PrintShow();
                    Show holdShow = userShow.SelectShow();
                    Episode holdEpisode = userShow.CreateEpisode();
                    holdShow.AddEpisode(holdEpisode);
                    Console.WriteLine("{0} added to {1}", holdEpisode.Name, holdShow.Name);
                    break;
                case 6:
                    userTitle.PrintTitle();
                    Title title1 = userTitle.SelectTitle();
                    userTitle.PrintTitle();
                    Title title2 = userTitle.SelectTitle();
                    viewMenu.AddTitlesToAggregatedGenre(title1, title2);
                    Console.Write("{0} and {1} added to ",title1._Name, title2._Name );
                    viewMenu.AddGenreToGenreList(title1 + title2);
                    break;
                case 7:
                    userGenre.PrintGenre();
                    Genre genre1 = userGenre.SelectGenre();
                    userGenre.PrintGenre();
                    Genre genre2 = userGenre.SelectGenre();
                    viewMenu.AddTitlesToAggregatedGenre(genre1, genre2);
                    Console.Write("{0} and {1} added to ", genre1.CombinedGenre, genre2.CombinedGenre);
                    viewMenu.AddGenreToGenreList(genre1 + genre2);
                    break;
                case 8:
                    userGenre.PrintGenre();
                    Genre genre = userGenre.SelectGenre();
                    userTitle.PrintTitle();
                    Title title = userTitle.SelectTitle();
                    viewMenu.AddTitlesToAggregatedGenre(title, genre);
                    Console.Write("{0} and {1} added to ", title._Name, genre.CombinedGenre);
                    viewMenu.AddGenreToGenreList(genre + title);
                    break;
                case 9:
                    userGenre.PrintGenre();
                    viewMenu.PrintGenre(userGenre.SelectGenre());

                    break;
                case 10:
                    Environment.Exit(1);
                    break;
                default:
                    break;
            }
        }
        public string GetUserInputTitle()
        {
            Console.WriteLine("Please enter in the title");
            return Console.ReadLine();
        }
        public void PrintGenreOptions()
        {
            Console.WriteLine("Select a genre for title:");
            Console.Write("1. Romance\n2. Action\n3. Comedy\n");
        }
        public Title.GenreType GetGenreType()
        {
            PrintGenreOptions();
            int genreTypeHold = NumbersOnlyCheck(4849, 0, 4);
            switch (genreTypeHold)
            {
                case 1:
                    return Title.GenreType.Romance;
                case 2:
                    return Title.GenreType.Action;
                default:
                    return Title.GenreType.Comedy;
            }
        }
    }
}
