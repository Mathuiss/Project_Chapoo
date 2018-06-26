using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapoo.Data;
using Chapoo.Model;

namespace Chapoo.Logic
{
    public class KeukenManager
    {
        KeukenDAO keuken = new KeukenDAO();
        public List<BestellingOverzicht> GetBestellingen()
        {
            return keuken.GetBestellingen();
        }

        public List<BestellingOverzicht> GetBestellingDrinken()
        {
            return keuken.GetDrinken();
        }
    }
}
