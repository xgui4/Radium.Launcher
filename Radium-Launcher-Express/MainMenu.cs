using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radium_Launcher_Express
{
    public class MainMenu : IKeyboardHandling, IErrorHandling
    {
        private const String TITLE = "Radium Launcher"; 

        public MainMenu()
        {

        }

        /// <summary>
        /// Cette méthode permet d'afficher l'entête dans la console
        /// </summary>
        public void ShowHeader()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to Radium Launcher Express!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("This version is a work in Progess");
        }

        public void HandleInput(ConsoleKey yes, ConsoleKey no)
        {
            throw new NotImplementedException();
        }

        public void ShowError(string errorMessage, ConsoleColor color = ConsoleColor.Red)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(errorMessage);
        }
    }
}
