using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBW.Fahrzeugverwaltung
{
    /// <summary>
    /// Klasse die Eigenschaften und Methoden für einen Motor definiert
    /// </summary>
    public class Motor
    {

        // Attribute
        private uint leistung;
        private uint hubraum;

        // Eigenschaften

        /// <summary>
        /// Leistung in PS
        /// </summary>
        public uint Leistung { get; set; }

        /// <summary>
        /// Hubraum in cm³
        /// </summary>
        public uint Hubraum { get; set; }

        // Konstruktoren
        public Motor() : this(100, 1600)
        {

        }

        public Motor(uint leistung, uint hubraum)
        {
            Leistung = leistung;
            Hubraum = hubraum;
        }
        
    }
}
