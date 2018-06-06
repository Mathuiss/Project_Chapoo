using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapoo.Data;

namespace Chapoo.Logic
{
    public class GerechtenManager
    {
        public void Add(int orderId, int gerechtId)
        {
            if (OpVoorraad(gerechtId, out int inStock))
            {
                MinVoorraad(gerechtId, inStock);
            }
            else
            {
                throw new Exception("Items out of stock");
            }
            //private methode aanroepen ==> check voorraad genoeg
            //vooraad afhalen,
            //bestelling tussentabel nieuw item toevoegen, bestelling id & gerecht id
        }

        private bool OpVoorraad(int gerechtId, out int inStock)
        {
            var gerecht = new GerechtenDAO();
            inStock = gerecht.Voorraad(gerechtId);

            if(inStock != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void MinVoorraad(int gerechtId, int inStock)
        {
            var gerecht = new GerechtenDAO();
            inStock--;
            gerecht.UpdateVoorraad(gerechtId, inStock);
        }
    }
}
