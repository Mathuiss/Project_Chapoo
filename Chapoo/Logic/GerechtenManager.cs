using System;
using System.Collections.Generic;
using Chapoo.Model;
using Chapoo.Data;

namespace Chapoo.Logic
{
    public class GerechtenManager
    {
        public List<Gerechten> GetBesteldeGerechten(int orderId)
        {
            var productManager = new GerechtenDAO();
            return productManager.BesteldeGerechten(orderId);
        }

        public void AddToOrder(int orderId, int gerechtId)
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
