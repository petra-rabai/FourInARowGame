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
        public void InitializeGameMainScreen()
        {
            InitializeGameTitle();

            Console.ReadLine();
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
