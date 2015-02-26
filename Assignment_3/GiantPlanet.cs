using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class GiantPlanet : Planet
    {
        //PRIVATE INSTANCE VARIABLE++++++++++++++++++++++++++++++++++++++==
        private string _type = "Gas", "Ice";

        //CONSTRUCTOR METHODS++++++++++++++++++++++++++++++++++++++++++++
        public GiantPlanet(string name, double diameter, double mass, string type)
            :base( name, diameter, mass)
        {
            this._type = type;
        }

        //IMPLEMENT HasMoon METHOD
       public override bool HasMoons()
       {
           if (MoonCount > 0)
           {
               return true;
               }
           else 
           {
              return false;
           }
       }
        public override bool HasRings()
       {
           if (RingCount > 0)
           {
               return true;
               }
           else 
           {
              return false;
           }
       }
    }
}
