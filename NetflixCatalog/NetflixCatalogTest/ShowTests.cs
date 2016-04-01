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
    public class ShowTests
    {
        Show show = new Show("Test", 5, Title.GenreType.Action);
        [TestMethod()]
        public void AddEpisodeTest()
        {
            //Arrange
            Episode episode = new Episode(4, "Epi One");
            //Act
            show.AddEpisode(episode);
            //Assert
            Assert.IsNotNull(show.EpisodeList);
        }

        [TestMethod()]
        public void RatingOverrideTwoEpisodesTest()
        {
            //Arrange
            Episode episode = new Episode(3, "Epi One");
            Episode episode2 = new Episode(2, "Epi One");
            show.AddEpisode(episode);
            show.AddEpisode(episode2);
            //Act
            show.Rating = show.Rating;
            double actual = show.Rating;
            double expected = ((episode.Rating + episode2.Rating) / 2);
            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void RatingOverrideOneEpisodeTest()
        {
            Episode episode = new Episode(3, "Epi One");
            show.AddEpisode(episode);
            //Act
            show.Rating = show.Rating;
            double actual = show.Rating;
            double expected = episode.Rating;
            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void ToStringNotOriginalNameTest()
        {
            //arrange
            Episode episode = new Episode(3, "Epi One");
            Episode episode2 = new Episode(2, "Epi One");
            show.AddEpisode(episode);
            show.AddEpisode(episode2);
            //act
            string actual = show.ToString();
            string notExpected = show.Name;
            //assert
            Assert.AreNotEqual(notExpected, actual);
        }

        [TestMethod()]
        public void ShowNullConstructorTest()
        {
            //arrange
            Show nullShow = new Show();
            //act
            //assert
            Assert.IsNull(nullShow.Name);
        }
        [TestMethod()]
        public void ShowNonNullConstructorTest()
        {
            //arrange
            Show show = new Show("Test", 5, Title.GenreType.Action);
            //act
            //assert
            Assert.IsNotNull(show.Name);
        }
    }
}