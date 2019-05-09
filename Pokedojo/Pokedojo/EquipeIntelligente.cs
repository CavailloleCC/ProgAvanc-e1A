using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedojo
{
    class EquipeIntelligente : Equipe
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="bddPokemon"></param>
        public EquipeIntelligente(BaseDeDonnees bddPokemon):base(bddPokemon)
        { }

        /// <summary>
        /// Choix intelligent du Pokémon actif parmi les Pokémons de l'équipe : retourne le nom du Pokémon actif
        /// Choisi le Pokémon ayant le plus de puissance d'attaque (car premier choix, on ne sait pas si il attaque ou s'il est adverse mais pour tous les choix suivants il sera attaquant
        /// </summary>
        /// <returns></returns>
        public override Pokemon ChoisirActif()
        {
            int puissanceMax = 0;
            Pokemon actif = ListEquipe[0];
            foreach(Pokemon pok in ListEquipe )
            {
                if(pok.Puissance>=puissanceMax)
                {
                    puissanceMax = pok.Puissance;
                    actif = pok;
                }
            }
            return actif;
        }
    }
}
