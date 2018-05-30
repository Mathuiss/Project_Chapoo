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
            string B = "robbin";

            var login = new UsersDAO();

            if(login.Login(A, B))
            {
                Console.WriteLine("gelukt");
            }
            else
            {
                Console.WriteLine("mislukt");
            }
            Console.ReadKey();
        }
    }
}
