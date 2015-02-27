using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        //PRIVATE INSTANCE VARIABLE++++++++++++++++++++++++++++++++++++++==
        private string _type;

        //CONSTRUCTOR METHODS++++++++++++++++++++++++++++++++++++++++++++
        public GiantPlanet(string name, double diameter, double mass, string type)
            :base( name, diameter, mass)
        {
            this._type = type;
        }
        //PROPERTY
        public string Type
        {
            get 
            {
                return this._type;
            }
            set 
            {
                this._type = value;
            }
        
        }
        //IMPLEMENT HasMoon METHOD
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
        //IMPLEMENT HasRings METHOD
        public bool HasRings()
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
