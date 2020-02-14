using _07_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_ConsoleUI.UI
{
    public class ProgramUI
    {
        private readonly StreamingRepository _streamingRepo = new StreamingRepository();
        private IConsole _console;
        public ProgramUI(IConsole console)
        {
            _console = console;
        }
        public void Run()
        {
            SeedContent();
            RunMenu();
        }
        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                _console.Clear();

                _console.WriteLine("Select an option number: \n" +
                    "1. Show all streaming content\n" +
                    "2. Display all shows\n" +
                    "3. Display all movies\n" +
                    "4. Add streaming content\n" +
                    "5. Update existing content\n" +
                    "6. Remove streaming content\n" +
                    "7. Exit");

                string userInput = _console.ReadLine();
                userInput = userInput.Replace(" ", "");

                switch (userInput)
                {
                    case "1":
                        // Show all content
                        ShowAllContent();
                        break;
                    case "2":
                        // Display all shows
                        ShowAllShows();
                        break;
                    case "3":
                        // Display all movies
                        ShowAllMovies();
                        break;
                    case "4":
                        // Add streaming content
                        AddNewStreamingContent();
                        break;
                    case "5":
                        // Update existing content
                        UpdateContent();
                        break;
                    case "6":
                        // Remove streaming content
                        break;
                    case "7":
                        // Exit
                        continueToRun = false;
                        break;
                    default:
                        break;
                }
            }
        }
        private void ShowAllContent()
        {
            _console.Clear();
            // Get all of our content
            List<StreamingContent> directory = _streamingRepo.GetContents();

            // Go through each item and display its properties
            foreach(StreamingContent content in directory)
            {
                _console.WriteLine($"Title: {content.Title}\n" +
                    $"Genre: {content.Genre}\n" +
                    $"Description: {content.Description}\n" +
                    $"Star Rating: {content.StarRating}\n" +
                    $"Maturity Rating: {content.TypeOfMaturityRating}\n" +
                    $"Family Friendly: {content.IsFamilyFriendly}\n" +
                    $"Language: {content.TypeOfLanguage}\n" +
                    $"Streaming Quality: {content.TypeOfStreamingQualityType}\n");
            }

            _console.WriteLine("Press any key to continue...");
            _console.ReadKey();
        }
        private void SeedContent()
        {
            StreamingContent toyStory = new StreamingContent("Bromance", "Toy Story", 10, StreamingQualityType.HD1080, "A good movie", Language.English, MaturityRating.G);
            _streamingRepo.AddContentToDirectory(toyStory);

            Movie rubber = new Movie("Drama", "Rubber", 6, StreamingQualityType.HD1080, "Mind Murder", Language.French, MaturityRating.R, 97.5);
            _streamingRepo.AddContentToDirectory(rubber);

            Show avatar = new Show("Action", "Avatar", 8, StreamingQualityType.HD720, "The Last Airbender", Language.English, MaturityRating.PG, new List<Episode>());
            _streamingRepo.AddContentToDirectory(avatar);
        }
        // Display all Shows
        // Make a list -> add to the list (shows)
        // Display the shows

        private void ShowAllShows()
        {
            List<Show> shows = new List<Show>();
            shows = _streamingRepo.GetAllShows();
            foreach (Show content in shows)
            {
                Console.WriteLine($"Title: {content.Title}\n" +
                    $"Genre: {content.Genre}\n" +
                    $"Stars: {content.StarRating}\n" +
                    $"Description: {content.Description}\n" +
                    $"Language: {content.TypeOfLanguage}\n" +
                    $"Maturity Rating: {content.TypeOfMaturityRating}\n" +
                    $"Quality: {content.TypeOfStreamingQualityType}\n" +
                    $"Family Friendly? {content.IsFamilyFriendly}\n" +
                    $"Average Run Time: {content.AverageRunTime}\n" +
                    $"Episode Count: {content.EpisodeCount}\n" +
                    $"Season Count: {content.SeasonCount}\n");
                foreach (Episode episode in content.Episodes)
                {
                    Console.WriteLine($"{episode.Title}");
                }
                
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        private void ShowAllMovies()
        {
            List<Movie> movies = new List<Movie>();
            movies = _streamingRepo.GetAllMovies();
            foreach (Movie content in movies)
            {
                Console.WriteLine($"Title: {content.Title}\n" +
                    $"Genre: {content.Genre}\n" +
                    $"Stars: {content.StarRating}\n" +
                    $"Description: {content.Description}\n" +
                    $"Language: {content.TypeOfLanguage}\n" +
                    $"Maturity Rating: {content.TypeOfMaturityRating}\n" +
                    $"Quality: {content.TypeOfStreamingQualityType}\n" +
                    $"Family Friendly? {content.IsFamilyFriendly}\n" +
                    $"Run Time: {content.RunTime}\n");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        //Access to streaming repo/ the add method
        //Prompt User
        //Take in content
        //Actually add the content through our add method
        private void AddNewStreamingContent()
        {
            StreamingContent content = new StreamingContent();
            _console.WriteLine("Hello there, please enter a title:");
            content.Title = _console.ReadLine();

            _console.WriteLine("Enter a genre:");
            content.Genre = _console.ReadLine();

            _console.WriteLine("Enter a description:");
            content.Description = _console.ReadLine();

            _console.WriteLine("Select a Maturity Rating:\n" +
                "1) G \n" +
                "2) PG \n" +
                "3) PG13 \n" +
                "4) R \n" +
                "5) NR \n");

            string maturityString = _console.ReadLine();
            int maturityratingID = int.Parse(maturityString);
            content.TypeOfMaturityRating = (MaturityRating)maturityratingID;

            _console.WriteLine("Enter Star Rating: ");
            content.StarRating = Convert.ToInt32(_console.ReadLine());

            _console.WriteLine("Select a Streaming Quality: \n" +
                "1) SD240 \n" +
                "2) SD480 \n" +
                "3) HD720 \n" +
                "4) HD1080 \n" +
                "5) UHD4K \n");

            string qualityInput = _console.ReadLine();
            switch (qualityInput)
            {
                case "1":
                    content.TypeOfStreamingQualityType = StreamingQualityType.SD240;
                    break;
                case "2":
                    content.TypeOfStreamingQualityType = StreamingQualityType.SD360;
                    break;
                case "3":
                    content.TypeOfStreamingQualityType = StreamingQualityType.HD720;
                    break;
                case "4":
                    content.TypeOfStreamingQualityType = StreamingQualityType.HD1080;
                    break;
                case "5":
                    content.TypeOfStreamingQualityType = StreamingQualityType.UHD4K;
                    break;
            }
            //int qualityID = int.Parse(qualityString);
            //content.TypeOfStreamingQualityType = (StreamingQualityType)qualityID;

            _console.WriteLine("Select Language: \n" +
                "1) English \n" +
                "2) French \n" +
                "3) Chinese \n" +
                "4) Korean \n" +
                "5) Spanish \n");

            string languageInput = _console.ReadLine();
            switch (languageInput)
            {
                case "1":
                    content.TypeOfLanguage = Language.English;
                    break;
                case "2":
                    content.TypeOfLanguage = Language.French;
                    break;
                case "3":
                    content.TypeOfLanguage = Language.Chinese;
                    break;
                case "4":
                    content.TypeOfLanguage = Language.Korean;
                    break;
                case "5":
                    content.TypeOfLanguage = Language.Spanish;
                    break;
            }
        }

        // Update Existing Content
        // Find Existing Content
        // Create an updated version
        // Pass the updated content to the repository Update method
        private void UpdateContent()
        {
            _console.WriteLine("Enter title of content you would like to update:");
            string titleInput = _console.ReadLine();
            StreamingContent existingContent = _streamingRepo.GetContentByTitle(titleInput);

            if (existingContent == null)
            {
                _console.WriteLine("There is no content with that Title.\n" +
                    "Press any key to continue...");
                _console.ReadLine();
            }
            else
            {
                StreamingContent content = new StreamingContent();
                _console.WriteLine($"Current title is {existingContent.Title}\n" +
                    $"Please enter a new title:");
                content.Title = _console.ReadLine();

                _console.WriteLine($"Current genre is {existingContent.Genre}\n" +
                    $"Please enter a new genre:");
                content.Genre = _console.ReadLine();

                _console.WriteLine($"Current description is {existingContent.Description}\n " +
                    $"Please enter a new description:");
                content.Description = _console.ReadLine();

                _console.WriteLine($" Current Maturity Rating is {existingContent.TypeOfMaturityRating}\n" +
                    $"Please  select a new Maturity Rating:\n" +
                    "1) G \n" +
                    "2) PG \n" +
                    "3) PG13 \n" +
                    "4) R \n" +
                    "5) NR \n");

                string maturityString = _console.ReadLine();
                int maturityratingID = int.Parse(maturityString);
                content.TypeOfMaturityRating = (MaturityRating)maturityratingID;

                _console.WriteLine($"Current Star Rating is {existingContent.StarRating}\n" +
                    $"Please enter a new Star Rating: ");
                content.StarRating = Convert.ToInt32(_console.ReadLine());

                _console.WriteLine($"Current Streaming Quality is {existingContent.TypeOfStreamingQualityType}\n" +
                    $"Please select a new Streaming Quality: \n" +
                    "1) SD240 \n" +
                    "2) SD480 \n" +
                    "3) HD720 \n" +
                    "4) HD1080 \n" +
                    "5) UHD4K \n");

                string qualityInput = _console.ReadLine();
                switch (qualityInput)
                {
                    case "1":
                        content.TypeOfStreamingQualityType = StreamingQualityType.SD240;
                        break;
                    case "2":
                        content.TypeOfStreamingQualityType = StreamingQualityType.SD360;
                        break;
                    case "3":
                        content.TypeOfStreamingQualityType = StreamingQualityType.HD720;
                        break;
                    case "4":
                        content.TypeOfStreamingQualityType = StreamingQualityType.HD1080;
                        break;
                    case "5":
                        content.TypeOfStreamingQualityType = StreamingQualityType.UHD4K;
                        break;
                }
                //int qualityID = int.Parse(qualityString);
                //content.TypeOfStreamingQualityType = (StreamingQualityType)qualityID;

                _console.WriteLine($"Current Language is {existingContent.TypeOfLanguage}\n" +
                    $"Please select a new Language: \n" +
                    "1) English \n" +
                    "2) French \n" +
                    "3) Chinese \n" +
                    "4) Korean \n" +
                    "5) Spanish \n");

                string languageInput = _console.ReadLine();
                switch (languageInput)
                {
                    case "1":
                        content.TypeOfLanguage = Language.English;
                        break;
                    case "2":
                        content.TypeOfLanguage = Language.French;
                        break;
                    case "3":
                        content.TypeOfLanguage = Language.Chinese;
                        break;
                    case "4":
                        content.TypeOfLanguage = Language.Korean;
                        break;
                    case "5":
                        content.TypeOfLanguage = Language.Spanish;
                        break;
                }

                _streamingRepo.UpdateExistingContent(existingContent.Title, content);
                _console.WriteLine("Your content has been updated/\n" +
                    "Press any key to continue...");
                _console.ReadKey();
            }
        }
    }
}