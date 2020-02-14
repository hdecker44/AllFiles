using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public class StreamingContentRepository
    {
        // Create Read Update Delete
        private readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();
        public bool AddContentToDirectory(StreamingContent content)
        {
            int directoryLength = _contentDirectory.Count();
            _contentDirectory.Add(content);
            bool wasAdded = directoryLength + 1 == _contentDirectory.Count();
            return wasAdded;
        }

        public List<StreamingContent> GetContents()
        {
            return _contentDirectory;
        }
        public StreamingContent GetContentByTitle(string title)
        {
            foreach(StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }
            return null;
        }
        /*Get by other parameters:
        Get All Content between StarRating Range*/
        public StreamingContent GetContentByRating(int low, int high)
        {
            foreach(StreamingContent content in _contentDirectory)
            {
                if(content.StarRating >= low)
                {
                    if (content.StarRating <= high)
                    {
                        return content;
                    }
                }
            }
            return null;
        }
        //Get All By MaturityRating
        //Get All By Family Friendly
        //Get All By Language
        //Refactor code to return lists in alphabetical order*/

        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle);
            if (oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.Genre = newContent.Genre;
                oldContent.StarRating = newContent.StarRating;
                oldContent.TypeOfMaturityRating = newContent.TypeOfMaturityRating;
                oldContent.TypeOfLanguage = newContent.TypeOfLanguage;
                oldContent.TypeOfStreamingQualityType = newContent.TypeOfStreamingQualityType;
                return true;
            }
                return false;
        }
        public bool DeleteExistingContent(string title)
        {
            StreamingContent foundContent = GetContentByTitle(title);
            bool deletedResult = _contentDirectory.Remove(foundContent);
            return deletedResult;
        }
          /* Get by other parameters:
          Get All Content between StarRating Range
          Get All By MaturityRating
          Get All By Family Friendly
          Get All By Language
          Refactor code to return lists in alphabetical order*/


    }
}
