using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    abstract class Planet
    {
        //PRIVATE INSTANCE VARIABLE ++++++++++++++++++++++++++++++++++++++++++

        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        //PUBLIC PROPERTIES+++++++++++++++++++++++++++++++++++++++++++++++++++

        public double Diameter
        {
            get
            { 
              return _diameter;
            }
        }
        public double Mass
        {
            get
            {
                return _mass;
            }
        }
        public double MoonCount
        {
            get
            {
                return _moonCount;
            }
            set
            {
                value = _moonCount;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public double OrbitalPeriod
        {
            get
            {
                return _orbitalPeriod;
            }
            set
            {
                value = _orbitalPeriod;
            }
        }
        public double RingCount
        {
            get
            {
                return _ringCount;
            }
            set
            {
                value = _ringCount;
            }
        }
        public double RotationPeriod
        {
            get
            {
                return _rotationPeriod;
            }
            set
            {
                value = _rotationPeriod;
            }
        }
        //CONSTRUCTOR METHOD +++++++++++++++++++++++++++++++++++++++++++++++++++
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }

        abstract public Tostring()
        {
        }
    }
}
