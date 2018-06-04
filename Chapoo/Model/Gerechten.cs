using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapoo.Data;

namespace Chapoo.Model
{
    public struct Gerechten
    {
        int id;
        string naam;
        int prijs;
        Gerecht categorie;

        public Gerechten(int id, string naam, int prijs, Gerecht categorie)
        {
            this.id = id;
            this.naam = naam;
            this.prijs = prijs;
            this.categorie = categorie;
        }
        
        public int Id { get => id; set => id = value; }
        public string Naam {get => naam; set => naam = value;}
        public int Prijs {get => prijs ; set => prijs= value;}
        public Gerecht Catogorie { get => categorie; set => categorie= value; }
    }
}
