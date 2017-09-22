using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBW.Fahrzeugverwaltung
{
    /// <summary>
    /// abstrakte Basisklasse, die Eigenschaften und Methoden für ein Fahrzeug definiert
    /// </summary>
    public abstract class Fahrzeug
    {
        private uint radanzahl;
        /// <summary>
        /// Radanzahl des Fahrzeuges (ohne Ersatzräder)
        /// </summary>
        public uint Radanzahl
        {
            get { return radanzahl; }
            set { radanzahl = value; }
        }

        private uint sitzplaetze;
        /// <summary>
        /// Sitzplaetze des Fahrzeuges (ohne Notsitze)
        /// </summary>
        public uint Sitzplaetze
        {
            get { return sitzplaetze; }
            set { sitzplaetze = value; }
        }


        protected Fahrzeug(uint radanzahl, uint sitzplaetze)
        {
            Console.WriteLine("Fahrzeug(alle Parameter)");
            Radanzahl = radanzahl;
            Sitzplaetze = sitzplaetze;
        }

    }
}
