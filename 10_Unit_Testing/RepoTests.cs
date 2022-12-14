using _08_Inheritance.People;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _10_Unit_Testing
{
    // Annotations are special modifiers in square brackets
    [TestClass]
    public class RepoTests
    {
        [TestMethod]
        public void CustomerUnder5Years_ShouldNotBePremium()
        {
            // AAA Testing Pattern:
            // Arrange
            Customer customer = new Customer();
            DateTime fourYearsAgo = DateTime.Now - new TimeSpan(4 * 365, 0, 0, 0, 0);
            customer.CustomerSince = fourYearsAgo;
            // Act
            bool actual = customer.IsPremium;
            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void CustomerOver5Years_ShouldBePremium()
        {
            // Arrange
            Customer customer = new Customer();
            DateTime sixYearsAgo = DateTime.Now - new TimeSpan(6 * 365, 0, 0, 0, 0);
            customer.CustomerSince = sixYearsAgo;
            // Act
            bool actual = customer.IsPremium;
            // Assert
            Assert.IsTrue(actual);
        }

        // TDD Test-Driven Development

        // "User Stories" describe all desired functionality
        // Come up with Unit Tests first
        // Build until tests pass

        [TestMethod]
        // Unit test methods should be named like:
        // Given X, should expect Y
        // X_ShouldY
        public void AddContent_ShouldBeAdded()
        {
            // Arrange
            string title = "Big";
            Movie movie = new Movie(
                title,
                "A kid wakes up as Tom Hanks for a while",
                4,
                Maturity.PG,
                Genre.Bromance,
                104
            );
            StreamingRepo repo = new StreamingRepo();
            // Act
            repo.AddContentToDirectory(movie);

            // Assert
            Movie content = repo.GetMovieByTitle(title);
            Assert.AreNotEqual(content, null);
            if (content != null)
                Assert.AreEqual(content.Title, title);
        }

        [TestMethod]
        public void MovieRatedR_ShouldNotBeFamilyFriendly()
        {
            // CHALLENGE: Complete and run these two tests

            // ARRANGE your data
            //   (a movie)
            Movie movie = new Movie("sfd", "dsfdhgfjh", 1, Maturity.R, Genre.Horror, 120);
            StreamingContent content = new StreamingContent();
            content.MaturityRating = Maturity.R;
            // Perform an ACTion
            //   Make it rated R
            movie.MaturityRating = Maturity.R;
            //   (Sometimes the action is just setting up the data)
            // ASSERT the result you expect
            //   IsFamilyFriendly is false
            Assert.IsFalse(movie.IsFamilyFriendly);
        }

        /*
        // Data Test Method
        [DataTestMethod]
        [DataRow(Maturity.G, true)]
        [DataRow(Maturity.PG, true)]
        [DataRow(Maturity.PG_13, false)]
        [DataRow(Maturity.R, false)]
        [DataRow(Maturity.TV_G, true)]
        [DataRow(Maturity.TV_MA, false)]
        public void SetMaturity_ShouldGetCorrectIsFamilyFriendly(Maturity maturity, bool isFamilyFriendly)
        {
            StreamingContent content = new StreamingContent();
            content.MaturityRating = maturity;

            bool actual = content.IsFamilyFriendly;

            Assert.AreEqual(isFamilyFriendly, actual);
        }
        */



        [TestMethod]
        public void ShowWithTwoEpisodes_ShouldGetEpisodeCountOfTwo()
        {
            // Arrange
            Show show = new Show();
            Episode episodeOne = new Episode();
            Episode episodeTwo = new Episode();
            show.Episodes.Add(episodeOne);
            show.Episodes.Add(episodeTwo);
            // Act
            int expected = 2;
            int actual = show.EpisodeCount;
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}