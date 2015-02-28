/*the Author's name: Jinwook Jung
 * Date last Modified: 27 FEB 2015
 * Program description: This program instatiate an giantPlanet object of GiantPlanet class as well as terrestrialPlanet in TerrestrialPlanet.
 *                      Also, display each planet instance variable.
 * Revision History: Feb 24, 2015 Initial commit to add default .gitIgnore and .gitAttribute files.
 *                                Added Classes
 *                      Feb 25, 2015 Revised version
 *                      Feb 26, 2015 revision
 *                                   Final
 *                      Feb 27, 2015 Final version
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implement giantPlanet object
            GiantPlanet giantPlanet = new GiantPlanet("Jinwook 2", 50000, 200, "Gas");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(giantPlanet.ToString() + " Type: " + giantPlanet.Type);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            
            //Implement terrestrialPlanet object
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Jinwook 1", 2220000, 31312, true);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(terrestrialPlanet.ToString() + " Oxyzen: " + terrestrialPlanet.Oxyzen);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");


            waitForAnyKey();
        }
        public static void waitForAnyKey()
        {
            Console.WriteLine("Press any key to continue...");

            Console.ReadKey();
        }
    }
}
