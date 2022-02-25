using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FourInARowGame
{
    public class UIContent : IUIContent
    {
        public void InitializeBoradSizeOption()
        {
            Console.WriteLine("\nPlease choose the Board option: \n");
            Console.WriteLine("* 7 x 6\n" + "* 5 x 4\n" + "* 6 x 5\n" + "* 8 x 7\n" + "* 9 x 7\n" + "* 10 x 7\n" + "* 8 x 8\n");
            Console.WriteLine("The first number is the borad colum.\n");
            Console.WriteLine("The second number is the borad row.\n");
        }

        public void InitializeGameDescription()
        {
            Console.WriteLine("\nBlock your opponent and set up for a '4 in a row' win.\n");
        }

        public void InitializeGameMainScreen()
        {
            InitializeGameTitle();
            InitializeGameDescription();
            InitializeGameMenu();
        }

        public void InitializeGameMenu()
        {
            Console.WriteLine("\nPlease choose an option: \n");
            Console.WriteLine("\n************************\n");
            Console.WriteLine(" Game Menu: \n");
            Console.Write("* New Game - N key \n"
                          + "* Save Game - S key \n"
                          + "* Load Game - L key \n"
                          + "* Statistics - T key \n"
                          + "* Author - A key \n"
                          + "* Game rules - R key \n"
                          + "* Quit - Q key \n");
            Console.WriteLine("\n************************");
        }

        public void InitializeGameTitle()
        {
            Console.WriteLine("************************************************************************************************************************************************");
            Console.WriteLine("*                                                                                                                                              *");
            Console.WriteLine("*                                                                                                                                              *");
            Console.WriteLine("*   ********    ********     *      *    *********   |  ********    *      *   |      *      |  ********     ********     *                 *  *");
            Console.WriteLine("*   *           *      *     *      *    *   **  *   |     *        * *    *   |     * *     |  *  **  *     *      *      *               *   *");
            Console.WriteLine("*   *****       *  **  *     *      *    *********   |     *        *  *   *   |    *   *    |  ********     *  **  *       *       *     *    *");
            Console.WriteLine("*   *           *  **  *     *      *    *   *       |     *        *   *  *   |   *******   |  *   *        *  **  *        *     * *   *     *");
            Console.WriteLine("*   *           *      *     *      *    *     *     |     *        *    * *   |  *       *  |  *     *      *      *         *   *   * *      *");
            Console.WriteLine("*   *           ********     ********    *       *   |  ********    *     **   | *         * |  *       *    ********          **      **      *");
            Console.WriteLine("*                                                                                                                                              *");
            Console.WriteLine("*                                                                                                                                              *");
            Console.WriteLine("************************************************************************************************************************************************");
        }

        public void InitializeGetPlayerName()
        {
            Console.WriteLine("Please add your name: \n");
        }

        public void DrawGrid(Grid grid)
        {
            for (int i = 0; i < grid.Size[1]; i++)
            {
                for (int j = 0; j < grid.Size[0]; j++)
                {
                    Console.Write($" |{grid.PositionMatrix[j, i]}| ");
                }

                Console.Write("\n");
                Console.Write("\n");
            }
        }
    }
}
