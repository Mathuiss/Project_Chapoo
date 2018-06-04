using System;
using System.Collections.Generic;

namespace Chapoo.Model
{
    public struct Rekening
    {
        public int RekeningNummer { get; set; }
        public int Tafel { get; set; }
        public List<Gerecht> Bestelling { get; set; }
        public float TotaalPrijs { get; set; }

        public Rekening(int _rekeningNummer, int _tafel, List<Gerecht> _bestelling, float _totaalPrijs)
        {
            RekeningNummer = _rekeningNummer;
            Tafel = _tafel;
            Bestelling = _bestelling;
            TotaalPrijs = _totaalPrijs;
        }
    }
}
