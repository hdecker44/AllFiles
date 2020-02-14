using _07_RepositoryPattern_ConsoleUI.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            RealConsole console = new RealConsole(); // Call in new instance of console
            ProgramUI ui = new ProgramUI(console);
            ui.Run();
        }
    }
}
