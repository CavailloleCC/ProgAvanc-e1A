using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedojo
{
    class Tournoi
    {
        public List<Equipe> ListeTournoi { get; set; }
        public BaseDeDonnees BddPokemon { get; set; }
        public Random _alea=new Random();

        /// <summary>
        /// Constructeur : Créer une liste de 16 équipes composées des Pokémon issues d'une base de données de 48 Pokémons
        /// </summary>
        public Tournoi()
        {
            BddPokemon = new BaseDeDonnees();
            ListeTournoi = new List<Equipe>();
            ListeTournoi.Add(new EquipeReelle(BddPokemon)); //Ajout de l'équipe réelle au tournoi
            Equipe equipeTournoi;
            //Ajout des 15 équipes simulées par ordinateur
            for(int i=0;i<15;i++)
            {
                equipeTournoi = new Equipe(BddPokemon);
                ListeTournoi.Add(equipeTournoi);
            }
        }

        public Equipe TournerJeux()
        {
            //Liste des équipes à attribuer à un combat (copie de la liste ListeTournoi)
            int num;
            List<Equipe> equipeDispo = new List<Equipe>();
            for(int i=0;i<ListeTournoi.Count;i++)
            {
                equipeDispo.Add(ListeTournoi[i]);
            }
            int index1; Equipe equipe1;
            int index2; Equipe equipe2;
            Combat combat;
            Equipe vainqueur;
            //Liste de liste d'équipe contenant les 2 équipes combattantes et l'équipe vainqueur du combat : servira pour l'affichage du tableau des résulats de chaque tour
            List<List<Equipe>> resultatsTour = new List<List<Equipe>>(); 
            while(ListeTournoi.Count>1)
            {
                while (equipeDispo.Count != 0)
                {
                    index1 = _alea.Next(equipeDispo.Count);
                    equipe1 = equipeDispo[index1];
                    equipeDispo.RemoveAt(index1);
                    index2 = _alea.Next(equipeDispo.Count);
                    equipe2 = equipeDispo[index2];
                    equipeDispo.RemoveAt(index2);
                    combat = new Combat(equipe1, equipe2);
                    vainqueur = combat.Combattre();
                    Console.Write(combat);
                    if (vainqueur == equipe1)
                    {
                        ListeTournoi.Remove(equipe2);
                    }
                    else
                    {
                        ListeTournoi.Remove(equipe1);
                    }
                    resultatsTour.Add(new List<Equipe> { equipe1, equipe2, vainqueur }); //Remplissage de la liste des résultats 
                }
                for (int i = 0; i < ListeTournoi.Count; i++)
                {
                    equipeDispo.Add(ListeTournoi[i]);
                }
                //Affichage du tableau des résultats des combats pour chaque tour
                for(int i=0; i<resultatsTour.Count;i++)
                {
                    num = i + 1;
                    if(resultatsTour[i][0].Numero<10 && resultatsTour[i][1].Numero<10 && resultatsTour[i][2].Numero < 10)
                    {
                        Console.WriteLine(" ----------------------------------------------------------");
                        Console.WriteLine("| Combat " + num + " | Equipe " + resultatsTour[i][0].Numero + "  / Equipe " + resultatsTour[i][1].Numero + "  | Vainqueur : Equipe " + resultatsTour[i][2].Numero + "  |");
                    }
                    else
                    {
                        if (resultatsTour[i][0].Numero < 10 && resultatsTour[i][1].Numero >= 10 && resultatsTour[i][2].Numero < 10 || resultatsTour[i][0].Numero >= 10 && resultatsTour[i][1].Numero < 10 && resultatsTour[i][2].Numero < 10)
                        {
                            if(resultatsTour[i][0].Numero<10)
                            {
                                Console.WriteLine(" ----------------------------------------------------------");
                                Console.WriteLine("| Combat " + num + " | Equipe " + resultatsTour[i][0].Numero + "  / Equipe " + resultatsTour[i][1].Numero + " | Vainqueur : Equipe " + resultatsTour[i][2].Numero + "  |");
                            }
                            else
                            {
                                Console.WriteLine(" ----------------------------------------------------------");
                                Console.WriteLine("| Combat " + num + " | Equipe " + resultatsTour[i][0].Numero + " / Equipe " + resultatsTour[i][1].Numero + "  | Vainqueur : Equipe " + resultatsTour[i][2].Numero + "  |");
                            }
                        }
                        else
                        {
                            if (resultatsTour[i][0].Numero < 10 && resultatsTour[i][1].Numero >= 10 && resultatsTour[i][2].Numero >= 10 || resultatsTour[i][0].Numero >= 10 && resultatsTour[i][1].Numero < 10 && resultatsTour[i][2].Numero >= 10)
                            {
                                if(resultatsTour[i][0].Numero<10)
                                {
                                    Console.WriteLine(" ----------------------------------------------------------");
                                    Console.WriteLine("| Combat " + num + " | Equipe " + resultatsTour[i][0].Numero + "  / Equipe " + resultatsTour[i][1].Numero + " | Vainqueur : Equipe " + resultatsTour[i][2].Numero + " |");
                                }
                                else
                                {
                                    Console.WriteLine(" ----------------------------------------------------------");
                                    Console.WriteLine("| Combat " + num + " | Equipe " + resultatsTour[i][0].Numero + " / Equipe " + resultatsTour[i][1].Numero + "  | Vainqueur : Equipe " + resultatsTour[i][2].Numero + " |");
                                }
                            }
                            else
                            {
                                Console.WriteLine(" ----------------------------------------------------------");
                                Console.WriteLine("| Combat " + num + " | Equipe " + resultatsTour[i][0].Numero + " / Equipe " + resultatsTour[i][1].Numero + " | Vainqueur : Equipe " + resultatsTour[i][2].Numero + " |");
                            }
                        }
                    }
                }
                Console.WriteLine(" ----------------------------------------------------------\n");
                resultatsTour.Clear(); //Tour terminé : on vide la liste des résultats du tour 

            }
            return ListeTournoi[0];
        }

        public override string ToString()
        {
            string chRes = "Tournoi de 16 équipes en trois tours\n\n";
            return chRes;
        }






    }
}
