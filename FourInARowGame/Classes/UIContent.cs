using FourInARowGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FourInARowGame.Classes
{
    public class UIContent : IUIContent
    {
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
            Console.Write("* Game mode - G key \n" + "* Board options - O key \n" + "* Game rules - R key \n" + "* Quit - Q key \n");
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
    }
}
