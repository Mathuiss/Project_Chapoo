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
            string A = "Robbin";
            string B = "robbbin";

            var login = new UsersDAO();

            try
            {
                login.IsLoggedIn(A);
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
