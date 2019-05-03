using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedojo
{
    class EquipeReelle : Equipe
    {
        public string NomEquipe { get; private set; }

        public EquipeReelle(BaseDeDonnees bddPokemon)
            :base(bddPokemon)
        {
            Console.WriteLine("Veuillez saisir un nom d'équipe : ");
            string nomEquipe = Convert.ToString(Console.ReadLine());
            NomEquipe = nomEquipe;
        }

        public override Pokemon ChoisirActif()
        {
            bool trouve = false;
            string nomPokemon;
            int i;
            do
            {
                Console.WriteLine("Quel Pokémon voulez-vous faire combattre ?");
                nomPokemon = Convert.ToString(Console.ReadLine());
                i = 0;
                while (i < ListEquipe.Count && ListEquipe[i].Nom != nomPokemon)
                {
                    i++;
                }
                if (i == (ListEquipe.Count-1))
                {
                    Console.WriteLine("Le Pokémon choisi ne fait pas parti de votre équipe.");
                }
                else
                {
                    trouve = true;
                }
            } while (trouve == false);
            return ListEquipe[i];
        }
    }
}
