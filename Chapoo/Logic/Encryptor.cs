using System;

namespace Chapoo.Logic
{
    public class Encryptor
    {
        const string ALPHABET = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890.?!@#$%^&*()_+=-";

        public string Encrypt(string password)
        {
            string sleutel = MaakGeheimeSleutel(40);

            string bericht = password;
            return OneTimePad(bericht, sleutel, true);
        }

        public string Decrypt(string pwdHash, string sleutel)
        {
            return OneTimePad(pwdHash, sleutel, false);
        }

        string MaakGeheimeSleutel(int lengte)
        {
            string sleutel = string.Empty;
            var rand = new Random();

            for (int i = 0; i < lengte; i++)
            {
                sleutel += ALPHABET[rand.Next(0, ALPHABET.Length)];
            }

            return sleutel;
        }

        string OneTimePad(string bericht, string sleutel, bool encrypt)
        {
            string resultaat = string.Empty;

            for (int i = 0; i < bericht.Length; i++)
            {
                int berichtPos = ALPHABET.IndexOf(bericht[i]);
                int sleutelPos = ALPHABET.IndexOf(sleutel[i]);

                if (encrypt)
                {
                    resultaat += ALPHABET[(berichtPos + sleutelPos) % ALPHABET.Length];
                }
                else
                {
                    int temp = berichtPos - sleutelPos;

                    if (temp < 0)
                    {
                        temp += ALPHABET.Length;
                    }

                    resultaat += ALPHABET[temp];
                }
            }

            return resultaat + "," + sleutel;
        }
    }
}
