using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Diagnostics;
using System;

namespace Radium_Launcher_Resharped
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void ClickHandler(object sender, RoutedEventArgs args)
        {
            message.Text = "Hello World";
        }

        public void ClickMinecraftJava(object sender, RoutedEventArgs args)
        {
            message.Text = "Minecraft Java";

        }

        public void ClickMinecraftBedrock(object sender, RoutedEventArgs args)
        {
            message.Text = "Minecraft Bedrock Launcher (Windows Only)";
        }

        public void ClickMinecraftModrinth(object sender, RoutedEventArgs args)
        {
            message.Text = "Modrinth App";
        }
        public void ClickMinecraftAmythyst(object sender, RoutedEventArgs args)
        {
            message.Text = "Amethyst Launcher (Windows Only)";
        }
    }
}