using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Individual_Project_Part_B.Run;

namespace Individual_Project_Part_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("INDIVIDUAL PROJECT PART B");
                Console.WriteLine("@copyright: science_technofreak@yahoo.com");
                Console.WriteLine("Press Any Key to Continue...");
                Console.ReadKey();
                Console.Clear();

                MainController mainController = new MainController();
                mainController.Menu();
            }
        }
    }
}
