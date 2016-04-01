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
    public class MovieTests
    {
        [TestMethod()]
        public void ToStringTest()
        {
            //arrange
            Movie movie = new Movie("Test", 5, Title.GenreType.Action, 120);
            //act
            string actual = movie.ToString();
            string notExpected = movie.Name;
            //assert
            Assert.AreNotEqual<string>(notExpected, actual);
        }

        [TestMethod()]
        public void MovieNullConstructorTest()
        {
            //arrange
            Movie nullMovie = new Movie();
            //act
            //assert
            Assert.IsNull(nullMovie.Name);
        }
        [TestMethod()]
        public void MovieNonNullConstructorTest()
        {
            //arrange
            Movie movie = new Movie("Test", 5, Title.GenreType.Action, 120);
            //act
            //assert
            Assert.IsNotNull(movie.Name);
        }
    }
}