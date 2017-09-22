using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBW.Fahrzeugverwaltung
{
    /// <summary>
    /// Klasse, die einen PKW näher beschreibt
    /// </summary>
    public class PKW : Fahrzeug
    {


        public uint gefahreneKilometer;

        public Motor Motor { get; set; }

        /// <summary>
        /// gefahrene Kilometer des PKWs
        /// </summary>
        public uint GefahreneKilometer
        {
            get { return gefahreneKilometer; }
            private set { gefahreneKilometer = value; }
        }

        public PKW(uint radanzahl, uint sitzplaetze, uint gefahreneKilometer, Motor motor) : base(radanzahl, sitzplaetze)
        {
            GefahreneKilometer = gefahreneKilometer;
            Motor = motor;
        }


    }
}
