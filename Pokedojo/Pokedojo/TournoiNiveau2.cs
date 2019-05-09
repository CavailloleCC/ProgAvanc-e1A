using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedojo
{
    class TournoiNiveau2 : Tournoi
    {
        /// <summary>
        /// Constructeur : construit une liste composée de 1 EquipeReelle et 15 EquipeIntelligente
        /// </summary>
        public TournoiNiveau2()
        {
            BddPokemon = new BaseDeDonnees();
            ListeTournoi = new List<Equipe>();
            ListeTournoi.Add(new EquipeReelle(BddPokemon)); //Ajout de l'équipe réelle au tournoi
            EquipeIntelligente equipeTournoi;
            //Ajout des 15 équipes simulées par ordinateur
            for (int i = 0; i < 15; i++)
            {
                equipeTournoi = new EquipeIntelligente(BddPokemon);
                ListeTournoi.Add(equipeTournoi);
            }
        }

    }
}
