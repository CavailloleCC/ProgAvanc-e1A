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
        public int Puissance { get; set; }
        public string Type { get; protected set; }
        public string Faiblesse { get; protected set; }
        public string AttaqueSpe { get; set; }
        public int PvMax { get; protected set; }
        public AttaqueSpecifique TypeAttaque { get; set; }

        /// <summary>
        /// Constructeur de Pokémon avec attaque spécifique 
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="pv"></param>
        /// <param name="puissance"></param>
        /// <param name="type"></param>
        /// <param name="faiblesse"></param>
        /// <param name="attaqueSpe"></param>
        public Pokemon(string nom, int pv, int puissance, string type, string faiblesse, string attaqueSpe)
        {
            Nom = nom;
            Pv = pv;
            Puissance = puissance;
            Type = type;
            Faiblesse = faiblesse;
            AttaqueSpe = attaqueSpe;
            PvMax = pv;
            if(AttaqueSpe=="brulure")
            {
                TypeAttaque = new Brulure("brulure");
            }
            else
            {
                if(AttaqueSpe=="gel")
                {
                    TypeAttaque = new Gel("gel");
                }
            }
        }

        /// <summary>
        /// Constructeur de Pokémon sans attaque spécifique 
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="pv"></param>
        /// <param name="puissance"></param>
        /// <param name="type"></param>
        /// <param name="faiblesse"></param>
        public Pokemon(string nom, int pv, int puissance, string type, string faiblesse) : this(nom, pv, puissance, type, faiblesse, "")
        { }

        public void AttaquerNormal(Pokemon adverse)
        {
            if (Type == adverse.Faiblesse)
            {
                adverse.Pv = adverse.Pv - (2 * Puissance);
            }
            else
            {
                adverse.Pv = adverse.Pv - Puissance;
            }
        }

        /// <summary>
        /// Affichage des caractéristiques du Pokémon 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string chRes = "";
            chRes = "Nom : " + Nom + "\nNombre de point de vie : " + Pv + "\nPuissance d'attaque : " + Puissance + "\nType : " + Type + "\nFaiblesse :" + Faiblesse +"\n";
            if(AttaqueSpe!="")
            {
                chRes = chRes + "Attaque spécifique : " + AttaqueSpe + "\n";
            }
            return chRes;
        }

    }
}
