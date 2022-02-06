using FourInARowGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARowGame.Classes
{
    public class UIContent : IUIContent
    {
        public void InitializeGameMainScreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.SetWindowSize(Console.LargestWindowHeight, Console.LargestWindowWidth);

            Console.WriteLine("***********************************************************************************************************************************************");
            Console.WriteLine("||                                                                                                                                           ||");
            Console.WriteLine("||                                                                                                                                           ||");
            Console.WriteLine("||                                                                                                                                           ||");
            Console.WriteLine("||                                                                                                                                           ||");
            Console.WriteLine("||                                                                                                                                           ||");
            Console.WriteLine("||                                                                                                                                           ||");
            Console.WriteLine("||                                                                                                                                           ||");
            Console.WriteLine("||                                                                                                                                           ||");
            Console.WriteLine("||                                                                                                                                           ||");
            Console.WriteLine("||                                                                                                                                           ||");
            Console.WriteLine("***********************************************************************************************************************************************");
            

            Console.ReadLine();
        }
    }
}
