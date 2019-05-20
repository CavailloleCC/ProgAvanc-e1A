using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedojo
{
    abstract class AttaqueSpecifique
    {
        public string AttaqueSpe { get; protected set; }

        /// <summary>
        /// Constructeur de la classe AttaqueSpecifique
        /// </summary>
        /// <param name="attaqueSpe"></param>
        public AttaqueSpecifique(string attaqueSpe)
        {
            AttaqueSpe = attaqueSpe;
        }

        /// <summary>
        /// Attaque spécifique à définir en fonction de l'attaque spécifique du Pokémon
        /// </summary>
        /// <param name="adverse"></param>
        /// <returns></returns>
        public abstract void AttaquerSpe(Pokemon adverse);

        
    }
}
