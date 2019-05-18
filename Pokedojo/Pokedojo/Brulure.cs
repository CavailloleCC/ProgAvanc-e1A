using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedojo
{
    class Brulure : AttaqueSpecifique
    {
        /// <summary>
        /// Constructeur de la classe Brulure
        /// </summary>
        /// <param name="attaqueSpe"></param>
        public Brulure(string attaqueSpe) : base(attaqueSpe)
        { }

        /// <summary>
        /// Attaque spécifique Brulure : 
        /// -Réduit l'attaque adverse de moitié 
        /// -Le Pokémon adverse perd 1/6 de ses PvMax
        /// -Un Pokémon de type "feu" ne peut pas être brûlé
        /// </summary>
        /// <param name="adverse"></param>
        public override void AttaquerSpe(Pokemon adverse)
        {
            adverse.Puissance = adverse.Puissance / 2;
            adverse.Pv = adverse.Pv - (adverse.PvMax / 6);
        }
    }
}
