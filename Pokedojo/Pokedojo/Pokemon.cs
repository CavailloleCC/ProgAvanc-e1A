using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedojo
{
    class Pokemon
    {
        public string Nom { get; protected set; }
        public int Pv { get; set; }
        public int Puissance { get; protected set; }
        public string Type { get; protected set; }
        public string Faiblesse { get; protected set; }
        public string AttaqueSpe { get; protected set; }

        public Pokemon(string nom, int pv, int puissance, string type, string faiblesse, string attaqueSpe)
        {
            Nom = nom;
            Pv = pv;
            Puissance = puissance;
            Type = type;
            Faiblesse = faiblesse;
            AttaqueSpe = attaqueSpe;
        }

        public Pokemon(string nom, int pv, int puissance, string type, string faiblesse) : this(nom, pv, puissance, type, faiblesse, "")
        { }

    }
}
