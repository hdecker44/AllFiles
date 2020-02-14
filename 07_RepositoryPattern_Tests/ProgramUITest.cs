using System;
using System.Collections.Generic;
using _07_RepositoryPattern_ConsoleUI.UI;
using _07_RepositoryPattern_Tests.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class ProgramUITest
    {
        [TestMethod]
        public void AddToList_ShouldSeeItemInOutput()
        {
            // Arrange
            List<string> commandList = new List<string>
            {
                "4", "Title", "Genre", "Description", "8", "2", "4", "1", "7"
            };
            MockConsole console = new MockConsole(commandList);
            ProgramUI ui = new ProgramUI(console);

            // Act
            ui.Run();
            Console.WriteLine(console.Output);
        }
    }
}
