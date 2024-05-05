namespace Radium_Launcher_Express; 
public class Program
{
    public static void Main(string[] args) {

       MainMenu menu = new MainMenu(); 

       bool shouldProgramContinue = true; 
       while (shouldProgramContinue) {

            menu.ShowHeader(); 

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Choose a Option"); 

            Console.WriteLine("""
                1. Minecraft Launcher.
                2. Setting.
                3. Connect To Server.
                """);

            String output = Console.ReadLine(); 

            if (output == "1")
            {
                Console.WriteLine("Are you sure ? If you write y. The Minecraft Launcher will launch. Else the programs will continue to the main menu...");
                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {
                        Console.Clear();
                        menu.ShowError("Not implemented yet!"); 
                    } 
            }

            if (output == "2")
            {
                Console.WriteLine("Are you sure you want to open the setting page ? Press Y to continue. Or N to cancel.");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    Console.Clear();
                    menu.ShowError("Not implemented yet!");
                }
            }

            if (output == "3")
            {
                Console.WriteLine("Other");
                Console.WriteLine("Coming soon!");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    Console.Clear();
                    menu.ShowError("Not implemented yet!");
                }
            }
        }
    }
}
