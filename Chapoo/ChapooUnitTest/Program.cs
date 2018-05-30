using System;
using Chapoo.Logic;

namespace ChapooUnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var encryptor = new Encryptor();
                string msg = encryptor.Encrypt("patatjes");

                Console.WriteLine(msg);

                int index = msg.IndexOf(',');
                msg = msg.Remove(index);
                string key = msg.Substring(index);
                key = key.Remove(0, 1);

                string passwd = encryptor.Decrypt(msg, key);
                Console.WriteLine(passwd);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.ReadKey();
        }
    }
}
