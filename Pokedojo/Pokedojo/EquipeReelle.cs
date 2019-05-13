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

        /// <summary>
        /// Constructeur de la classe EquipeReelle
        /// </summary>
        /// <param name="bddPokemon"></param>
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
        public override void ChoisirActif(out Pokemon actif)
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
                while (i < ListEquipe.Count && ListEquipe[i][0].Nom != nomPokemon)
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
            actif= ListEquipe[i][0];
            //Le nombre de victoires consécutives est remis à 0 losrqu'on commence un nouveau combat
            VictoiresConsecutives = 0; 
        }

        /// <summary>
        /// Choix d'un Pokémon au cours de la partie
        /// </summary>
        /// <param name="adverse"></param>
        /// <returns></returns>
        public override void ChoisirActif(ref Pokemon attaquant, Pokemon adverse)
        {
            Console.WriteLine("L'adversaire de votre Pokémon est " + adverse.Nom);
            ChoisirActif(out attaquant);
        }

        /// <summary>
        /// Demande au joueur s'il veut faire battre en retraite son Pokémon actif : renvoie true si il l'a fait battre en retraite, false sinon
        /// </summary>
        /// <param name="attaquant"></param>
        /// <param name="adverse"></param>
        /// <returns></returns>
        public override bool BattreEnRetraite(ref Pokemon attaquant, ref Pokemon adverse)
        {   
            bool chiffre = false;
            if(NbPokemon>1)
            {
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
                    chiffre = true;
                    //Si le joueur est attaquant 
                    if (PossederPokemon(attaquant) == true)
                    {
                        ChoisirActif(out attaquant);
                    }
                    //Si le joueur est adverse
                    else
                    {
                        ChoisirActif(out adverse);
                    }
                }
                if (chiffre == true)
                {
                    VictoiresConsecutives = 0;
                }
            }
            return chiffre;
        }

        /// <summary>
        /// Affichage des informations relatives à la classe EquipeReelle
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string chRes = "";
            chRes = chRes + "Equipe " + NomEquipe+" : Equipe "+Numero;
            chRes = chRes + "\n---------------------------------------\n";
            int i = 0;
            while(i<ListEquipe.Count)
            {
                chRes = chRes + ListEquipe[i][0].ToString();
                chRes = chRes + "---------------------------------------\n";
                i++;
            }
            return chRes;
        }
    }
}
