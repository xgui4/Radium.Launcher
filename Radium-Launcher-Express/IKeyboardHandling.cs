using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radium_Launcher_Express
{
    public interface IKeyboardHandling
    {
        /// <summary>
        /// Cette méthode de l'interface permet de géré les touches 
        /// </summary>
        /// <param name="yes"></param>
        /// <param name="no"></param>
        public void HandleInput(ConsoleKey yes, ConsoleKey no);
    }
}
