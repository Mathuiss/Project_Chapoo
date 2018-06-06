using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapoo.Model
{
    public struct Gerechten
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public float Prijs { get; set; }
        public Gerecht Catogorie { get; set; }
        public int Voorraad { get; set; }
        public Gerechten(int id, string naam, float prijs, Gerecht categorie, int voorraad)
        {
            Id = id;
            Naam = naam;
            Prijs = prijs;
            Catogorie = categorie;
            Voorraad = voorraad;
        }
    }
}
