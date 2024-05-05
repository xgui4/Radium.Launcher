using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radium_Launcher_Express
{
    public interface IErrorHandling
    {
        /// <summary>
        /// Cette méthode de l'interface permet de faire un message d'erreur avec une couleur personnalisé 
        /// </summary>
        /// <param name="errorMessage"></param>
        /// <param name="color"></param>
        public void ShowError(string errorMessage, ConsoleColor color = ConsoleColor.Red);
    }
}
