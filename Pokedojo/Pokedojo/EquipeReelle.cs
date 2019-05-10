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

        /// <summary>
        /// Choix par le joueur du Pokémon actif parmi les Pokémons de l'équipe : Choix au début de la partie
        /// </summary>
        /// <param name="equipe"></param>
        /// <returns></returns>
        public override Pokemon ChoisirActif()
        {
            bool trouve = false;
            string nomPokemon;
            int i;
            do
            {
                Console.WriteLine("Quel Pokémon voulez-vous faire combattre ?");
                nomPokemon = Convert.ToString(Console.ReadLine());
                Console.WriteLine();
                i = 0;
                while (i < ListEquipe.Count && ListEquipe[i].Nom != nomPokemon)
                {
                    i++;
                }
                if (i == ListEquipe.Count)
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

        /// <summary>
        /// Choix d'un Pokémon au cours de la partie
        /// </summary>
        /// <param name="adverse"></param>
        /// <returns></returns>
        public override Pokemon ChoisirActif(Pokemon adverse)
        {
            Console.WriteLine("Votre adversaire est " + adverse.Nom);
            return ChoisirActif();
        }

        public override void BattreEnRetraite(ref Pokemon attaquant, ref Pokemon adverse)
        {
            bool chiffre = false;
            int rep = 0;
            do
            {
                do
                {
                    Console.WriteLine("Voulez-vous faire battre en retraite votre Pokémon actif ?(1 pour oui, 0 pour non)");
                    try
                    {
                        rep = Convert.ToInt32(Console.ReadLine());
                        chiffre = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Vous devez rentrer un entier (0 ou 1).");
                    }
                } while (chiffre == false);
                chiffre = false;
                if (rep != 0 && rep != 1)
                {
                    Console.WriteLine("Attention! Repondre 1 pour oui ou 0 pour non!");
                }
            } while (rep != 0 && rep != 1);
            if (rep == 1)
            {
                if(ListEquipe.Contains(attaquant))
                {
                    attaquant = ChoisirActif();
                }
                else
                {
                    adverse = ChoisirActif();
                }
            }
        }

        public override string ToString()
        {
            string chRes = "";
            chRes = chRes + "Equipe " + NomEquipe+" : Equipe "+Numero;
            chRes = chRes + "\n---------------------------------------\n";
            foreach (Pokemon pokemon in ListEquipe)
            {
                chRes = chRes + pokemon.ToString();
                chRes = chRes + "---------------------------------------\n";
            }
            return chRes;
        }
    }
}
