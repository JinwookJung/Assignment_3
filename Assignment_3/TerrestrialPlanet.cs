using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class TerrestrialPlanet : Planet
    {
        //PRIVATE INSTANCE VARIALBE +++++++++++++++++++++++++++++++++++++++++
        private bool _oxyzen;

        //CONSTRUCTOR METHOD +++++++++++++++++++++++++++++++++++++++++++++++
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxyzen)
            : base(name, diameter, mass)
        {
            this._oxyzen = oxyzen;
        }

        
        //INTERFACE IHasRings METHOD
        interface IHasRings
        {
            void HasRings()
            {
                return bool 
            }
        }
        //INTERFACE IHabitable METHOD
        interface IHabitable
        {
            void Habitable()
            {
            }
        }
    }
}
