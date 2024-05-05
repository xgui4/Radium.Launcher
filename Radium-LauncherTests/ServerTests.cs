using Microsoft.VisualStudio.TestTools.UnitTesting;
using Radium_Launcher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radium_Launcher.Tests
{
    [TestClass()]
    public class ServerTests
    {
        [TestMethod()]
        public void ConnectTest()
        {
            //Arrange 
            var server = new Server(); 

            server.Connect();
        }
    }
}