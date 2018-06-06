using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapoo.Data;

namespace ChapooUnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new GerechtenDAO();

            try
            {
                t.Voorraad(2);
                Console.WriteLine("Geen Errors");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadKey();
        }
    }
}
