using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System;
using Microsoft.VisualBasic;
using MessageBox = System.Windows.MessageBox;
using System.Linq.Expressions;
using Application = System.Windows.Forms.Application;
using Microsoft.Extensions.Logging;
using System.Security.Cryptography;

namespace Radium_Launcher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SystemManagement sys;
        }

        private void mcLauncherSelected(object sender, MouseButtonEventArgs e)
        {
            try
            {
                var processInfo = new ProcessStartInfo("launch.bat");

                var process = Process.Start(processInfo);

                process.Start();

                process.WaitForExit();
            }
            catch
            {
                MessageBox.Show("Radium Launcher n'a pas pu executer le fichier launch.bat", "Une erreur inentendu c'est produite");
            }

        }

        private void mcBedrockSelected(object sender, MouseButtonEventArgs e)
        {
            var launcher = new AppLauncher("C:\\Program Files\\BedrockLauncher\\app\\BedrockLauncher.exe\"", "Bedrock Launcher");
            launcher.LaunchWithElevatedPrivileged();
        }

        private void launchAmethyst(object sender, MouseButtonEventArgs e)
        {
            try
            {
                var process = Process.Start("C:\\Program Files\\Amethyst Launcher\\Amethyst Launcher.exe");
                process.WaitForExit(); 
            }
            catch
            {
                MessageBox.Show("Radium Launcher n'a pas pu executer le fichier Amethyst Launcher.exe", "Une erreur inentendu c'est produite");
            }
        }

        private void launchModrinth(object sender, MouseButtonEventArgs e)
        {
            try
            {
                var process = Process.Start("C:\\Program Files\\Modrinth App\\Modrinth App.exe");
                process.WaitForExit();
            }
            catch
            {
                MessageBox.Show("Radium Launcher n'a pas pu executer le fichier Modrinth App.exe", "Une erreur inentendu c'est produite");
            }
        }

        private void openSetting(object sender, MouseButtonEventArgs e)
        {
            Setting settingWindow = new Setting();
            settingWindow.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var db = new Server();
            string output = db.Connect();
            MessageBox.Show(output);
        }
    }
}       