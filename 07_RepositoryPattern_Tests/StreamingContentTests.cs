using System;
using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void SetTitle_ShouldSetCorrectString()
        {
            StreamingContent content = new StreamingContent();

            content.Title = "Old School";

            string expected = "Old School";
            string actual = content.Title;

            Assert.AreEqual(expected, actual);

            content.Genre = "Comedy";
            content.StarRating = 4;
        }
        [DataTestMethod]
        [DataRow(MaturityRating.NR, false)]
        public void SetMaturityRating_ShouldGetCorrectIsFamilyFriendly(MaturityRating rating, bool isFamilyFriendly)
        {
            StreamingContent content = new StreamingContent("Action", "Iron Man", 4, StreamingQualityType.UHD4K, "Marvel Film", Language.English, rating);

            /* content.Title = "Iron Man";
             content.Genre = "Action";
             content.Description = "Marvel Film";
             content.StarRating = 4;
             content.TypeOfLanguage = Language.English;
             content.TypeOfStreamingQualityType = StreamingQualityType.UHD4K;
             int expected = 4;
             int actual = content.StarRating; */

            bool actual = content.IsFamilyFriendly;
            bool expected = isFamilyFriendly;

            Assert.AreEqual(expected, actual);
        }
    }
}
