using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBW.Fahrzeugverwaltung
{
    class Strassenmaschine : Motorrad
    {
        private uint vmax;

        public uint Vmax
        {
            get { return vmax; }
            set { vmax = value; }
        }

    }
}
