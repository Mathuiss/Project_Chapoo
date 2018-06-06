using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chapoo.Model;
using Chapoo.Data;

namespace ChapooUnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var tafel = new TafelDAO();

            try
            {
                var data = new GerechtenDAO();
                List<Gerechten> bestelling = data.BesteldeGerechten(1);

                foreach (Gerechten g in bestelling)
                {
                    Console.WriteLine("{0}{1}{2}{3}{4}", g.Id, g.Naam, g.Prijs, g.Catogorie.ToString(), g.Voorraad);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
            Console.ReadKey();
        }
    }
}
