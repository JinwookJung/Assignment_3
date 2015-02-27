/*the Author's name: Jinwook Jung
 * Date last Modified: 26 FEB 2015
 * Program description: Feb 24, 2015 Initial commit to add default .gitIgnore and .gitAttribute files.
 *                                   Added Classes
 *                      Feb 25, 2015 Revised version
 *                      Feb 26, 2015 revision
Revision
History*/

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
        }
    }
}
