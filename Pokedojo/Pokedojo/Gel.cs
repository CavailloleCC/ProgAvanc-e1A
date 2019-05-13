using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedojo
{
    class Gel : AttaqueSpecifique
    {
        /// <summary>
        /// Constructeur de la classe Gel
        /// </summary>
        /// <param name="attaqueSpe"></param>
        public Gel(string attaqueSpe) : base(attaqueSpe)
        { }

        /// <summary>
        /// Attaque spécifique Gel :
        /// -Le Pokémon adverse ne peut plus attaquer : sa puissance d'attaque vaut 0
        /// </summary>
        /// <param name="adverse"></param>
        public override void AttaquerSpe(Pokemon adverse)
        {
            adverse.Puissance = 0;
        }
    }
}
