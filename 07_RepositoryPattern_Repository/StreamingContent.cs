using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public enum StreamingQualityType { SD240 = 1, SD360 = 2, HD720 = 3, HD1080 = 4, UHD4K = 5 }
    public enum Language { English, Spanish, French, Chinese, Korean }
    public enum MaturityRating { G = 1, PG = 2, PG13 = 3, R = 4, NR = 5 }
    public class StreamingContent
    {
        // Properties of StreamingContent Class //
        public string Genre { get; set; }
        public string Title { get; set; }
        public int StarRating { get; set; }
        public StreamingQualityType TypeOfStreamingQualityType { get; set; }
        public string Description { get; set; }
        public Language TypeOfLanguage { get; set; }
        public MaturityRating TypeOfMaturityRating { get; set; }
        public bool IsFamilyFriendly
        {
            get
            {
                switch (TypeOfMaturityRating)
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                    case MaturityRating.PG13:
                        return true;
                    case MaturityRating.R:
                    case MaturityRating.NR:
                        return false;
                    default:
                        return false;
                //return (maturityRating == "R") ? false : true;
                }
            }
        }

        // Constructor // 
        public StreamingContent() { }
        //Overloaded Constructor //
        public StreamingContent(string genre, string title, int starRating, StreamingQualityType
                typeOfQuality, string description, Language typeOfLanguage, MaturityRating typeOfMaturityRating)
        {
            Genre = genre;
            Title = title;
            StarRating = starRating;
            TypeOfStreamingQualityType = typeOfQuality;
            Description = description;
            TypeOfLanguage = typeOfLanguage;
            TypeOfMaturityRating = typeOfMaturityRating;            
        }

        /*Users have been complaining about their family friendly content.Some users have been reporting that when filtering for family friendly, they're getting some content with inappropriate maturity ratings. We need to fix this. Currently the maturity rating and family friendly bool are independent, we need to tie them together. If something is rated R (or another similar rating), it should never be able to have a IsFamilyFriendly of true. 
        We need you to refactor the code StreamingContent class. To help narrow down our problem, we want to replace the MaturityRating with a default set of options.Based on those options, we want our IsFamilyFriendly to return the appropriate true or false.
        */
    }
}
