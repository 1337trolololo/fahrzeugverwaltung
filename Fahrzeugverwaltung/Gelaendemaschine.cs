using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBW.Fahrzeugverwaltung
{
    class Gelaendemaschine : Motorrad
    {
        private double bodenfreiheit;

        public double Bodenfreiheit
        {
            get { return bodenfreiheit; }
            set { bodenfreiheit = value; }
        }

    }
}
