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
            throw new NotImplementedException();
        }

        public void InitializeGameMainScreen()
        {
            InitializeGameTitle();
            InitializeGameDescription();
            InitializeGameMenu();
        }

        public void InitializeGameMenu()
        {
            Console.Write("Game mode - G key " + " Board options - O key" + "Game rules - R key" + "Quit - Q key");

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
