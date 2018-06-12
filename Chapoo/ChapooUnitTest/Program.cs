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
            var t = new GerechtenDAO();

            try
            {
                t.UpdateVoorraad((int)1, (int)12);
                Console.WriteLine("Geen Errors");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
            Console.ReadKey();
        }
    }
}
