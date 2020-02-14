using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTest
    {
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();

            bool addResult = repository.AddContentToDirectory(content);

            Assert.IsTrue(addResult);
        }
        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repo = new StreamingContentRepository();
            repo.AddContentToDirectory(content);

            List<StreamingContent> contents = repo.GetContents();

            bool directoryHasContent = contents.Contains(content);
            Assert.IsTrue(directoryHasContent);
        }
        private StreamingContentRepository _repo;
        private StreamingContent _content;
        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            _content = new StreamingContent("Drama","Rubber",3,StreamingQualityType.UHD4K,"Is a Movie",Language.French,MaturityRating.R);
            _repo.AddContentToDirectory(_content);
        }
        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            StreamingContent searchResult = _repo.GetContentByTitle("Rubber");
            Assert.AreEqual(_content, searchResult);

        }
        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            StreamingContent newContent = new StreamingContent("Drama", "Rubber", 100, StreamingQualityType.UHD4K, "Is a Movie", Language.English, MaturityRating.NR);
            bool updateResult = _repo.UpdateExistingContent("Rubber", newContent);
            Assert.IsTrue(updateResult);
        }
        [TestMethod]
        public void MyTestMethod()
        {
            bool removeResult = _repo.DeleteExistingContent("Rubber");
            Assert.IsTrue(removeResult);
        }
    }
}
