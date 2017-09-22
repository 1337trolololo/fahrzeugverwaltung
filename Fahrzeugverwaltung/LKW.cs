using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBW.Fahrzeugverwaltung
{
    /// <summary>
    /// Klasse, die einen LKW näher beschreibt
    /// </summary>
    class LKW : Fahrzeug
    {
        public uint betriebsstunden;

        public Motor Motor { get; set; }


        /// <summary>
        /// Betriebsstunden des LKWs in Stunden
        /// </summary>
        public uint Betriebsstunden
        {
            get { return betriebsstunden; }
            private set { betriebsstunden = value; }
        }


        public LKW() : this(6, 3, 12000, new Motor())
        {

        }

        public LKW(uint radanzahl, uint sitzplaetze, uint betriebsstunden, Motor motor) : base(radanzahl, sitzplaetze)
        {
            Betriebsstunden = betriebsstunden;
            Motor = motor;
        }

    }
}
