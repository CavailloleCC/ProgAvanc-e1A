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
        private Random _alea;

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
            List<Equipe> equipeDispo = new List<Equipe>();
            for(int i=0;i<ListeTournoi.Count;i++)
            {
                equipeDispo.Add(ListeTournoi[i]);
            }
            int index1; Equipe equipe1;
            int index2; Equipe equipe2;
            Combat combat;
            Equipe vainqueur;
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
                    vainqueur = combat.Attaquer();
                    if (vainqueur == equipe1)
                    {
                        ListeTournoi.Remove(equipe2);
                    }
                    else
                    {
                        ListeTournoi.Remove(equipe1);
                    }
                }
                for (int i = 0; i < ListeTournoi.Count; i++)
                {
                    equipeDispo.Add(ListeTournoi[i]);
                }

            }
            return ListeTournoi[0];
        }






    }
}
