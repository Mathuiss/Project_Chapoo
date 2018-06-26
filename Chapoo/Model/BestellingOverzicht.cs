using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapoo.Model
{
    public class BestellingOverzicht
    {
        public int BestellingId { get; set; }
        public string Gerecht { get; set; }
        public int Tafelnr { get; set; }         
        public string Aantekening { get; set; }

        public BestellingOverzicht(int bestellingId, string gerecht, int tafelnr, string aantekening)
        {
            BestellingId = bestellingId;
            Gerecht = gerecht;
            Tafelnr = tafelnr;
            Aantekening = aantekening;
        }
    }
}
