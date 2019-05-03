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
            Tournoi tournoi = new Tournoi();
            Console.WriteLine(tournoi);
            Equipe vainqueur = tournoi.TournerJeux();
            if(vainqueur is EquipeReelle)
            {
                Console.WriteLine("Votre équipe a gagné !");
            }
            else
            {
                Console.WriteLine("L'équipe vainqueur est l'équipe numéro " + vainqueur.Numero);
            }
            Console.ReadKey();
        }
    }
}
