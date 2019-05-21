using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedojo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool chiffre = false;
            int nouvellePartie = 1;
            do
            {
                Tournoi tournoi = new Tournoi();
                Console.WriteLine(tournoi);
                Equipe vainqueur = tournoi.TournerJeux();
                if (vainqueur is EquipeReelle)
                {
                    Console.WriteLine("Votre équipe a gagné !");
                }
                else
                {
                    Console.WriteLine("L'équipe vainqueur est l'équipe numéro " + vainqueur.Numero+"\n\n");
                }
                do
                {
                    do
                    {
                        Console.WriteLine("Voulez-vous recommencer une nouvelle partie ? (1 pour oui, 0 pour non)");
                        try
                        {
                            nouvellePartie = Convert.ToInt32(Console.ReadLine());
                            chiffre = true;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Vous devez rentrer un entier (0 ou 1).");
                        }

                    } while (chiffre == false);
                    if (nouvellePartie != 0 && nouvellePartie != 1)
                    {
                        Console.WriteLine("Attention! Repondre 1 pour oui ou 0 pour non!");
                    }
                    if(nouvellePartie==1)
                    {
                        Console.Clear();
                    }
                } while (nouvellePartie != 0 && nouvellePartie != 1);
            } while (nouvellePartie == 1);
            Console.WriteLine("A bientôt !");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
