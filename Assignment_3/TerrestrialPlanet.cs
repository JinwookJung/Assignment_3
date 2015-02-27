using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        //PRIVATE INSTANCE VARIALBE +++++++++++++++++++++++++++++++++++++++++
        private bool _oxyzen;

        //CONSTRUCTOR METHOD +++++++++++++++++++++++++++++++++++++++++++++++
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxyzen)
            : base(name, diameter, mass)
        {
            this._oxyzen = oxyzen;
        }
        //PROPERTY
        public bool Oxyzen
        {
            get 
            {
                return this._oxyzen;
            }
            set 
            {
                this._oxyzen = value;
            }
        }
        
        //implement IHasRings METHOD
 
        public bool HasMoons()
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
        
        //implement IHabitable METHOD
        public bool Habitable()
        {
            if (this._oxyzen == true)
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
