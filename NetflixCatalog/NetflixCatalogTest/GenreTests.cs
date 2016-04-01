using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetflixCatalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog.Tests
{
    [TestClass()]
    public class GenreTests
    {
        Genre genre = new Genre(Genre.CombinedGenreType.Action);
        [TestMethod()]
        public void AddShowTitlesListTest()
        {
            //Arrange
            Show show = new Show();
            //Act
            genre.AddTitles(show);
            //Assert
            Assert.IsNotNull(genre.titleList);
        }
        [TestMethod()]
        public void AddMovieTitlesListTest()
        {
            //Arrange
            Movie movie = new Movie();
            //Act
            genre.AddTitles(movie);
            //Assert
            Assert.IsNotNull(genre.titleList);
        }

        [TestMethod()]
        public void GetEnumeratorEqualToListTest()
        {
            //Arrange
            genre.AddTitles(new Movie()); genre.AddTitles(new Movie());
            genre.AddTitles(new Show()); genre.AddTitles(new Show());
            int actual = 0; int expected = 0;
            //Act
            foreach (Title title in genre)
            {
                actual++;
            }
            foreach (Title title in genre.titleList)
            {
                expected++;
            }
            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}