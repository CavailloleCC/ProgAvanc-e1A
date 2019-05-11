using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedojo
{
    class Equipe
    {
        public List<List<Pokemon>> ListEquipe { get; set; }
        public int NbPokemon { get; set; }
        public Random _alea = new Random();
        protected static int _numeroEquipe = 0;
        public BaseDeDonnees BddPokemon { get; set; }
        public int Numero { get; protected set; }

        /// <summary>
        /// Constructeur de la classe Equipe
        /// </summary>
        /// <param name="bddPokemon"></param>
        public Equipe(BaseDeDonnees bddPokemon)
        {
            NbPokemon = 3;
            BddPokemon = bddPokemon;
            Numero = ++_numeroEquipe;
            ListEquipe = new List<List<Pokemon>>();
            int index;
            for(int i=0; i<3; i++)
            {
                index = _alea.Next(BddPokemon.NbPokemonDispo);
                int b = BddPokemon.NbPokemonDispo;
                ListEquipe.Add(BddPokemon.ListeBddPokemon[index]);
                BddPokemon.SupprimerPokemon(BddPokemon.ListeBddPokemon[index]);
            }
        }

        public bool PossederPokemon(Pokemon pokemon)
        {
            int i = 0;
            while(i<ListEquipe.Count && ListEquipe[i][0]!=pokemon)
            {
                i++;
            }
            if(i==ListEquipe.Count)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Choix aléatoire du Pokémon actif parmi les Pokémons de l'équipe : retourne le nom du Pokémon actif
        /// </summary>
        /// <returns></returns>
        public virtual void ChoisirActif(out Pokemon actif)
        {
            int numero = _alea.Next(NbPokemon);
            actif = ListEquipe[numero][0];
        }

        /// <summary>
        /// Choix d'un Pokémon de façon intelligente
        /// </summary>
        /// <param name="adverse"></param>
        /// <returns></returns>
        public virtual void ChoisirActif(ref Pokemon attaquant, Pokemon adverse)
        {
            bool choix = false;
            Pokemon actif = ListEquipe[0][0];
            int i = 0;
            //Choix d'un Pokémon ayant une puissance d'attaque minimale supérieure au nombre de PV de l'adversaire si possible
            while (i < ListEquipe.Count)
            {
                if (adverse.Pv <= ListEquipe[i][0].Puissance)
                {
                    if (choix == true && ListEquipe[i][0].Puissance < actif.Puissance)
                    {
                        actif = ListEquipe[i][0];
                    }
                    else
                    {
                        if (choix == false)
                        {
                            actif = ListEquipe[i][0];
                            choix = true;
                        }
                    }
                }
                i++;
            }
            i = 0;
            //Si pas possible : choix d'un Pokémon ayant un nombre le point de vie minimal supérieur à la puissance d'attaque de l'adversaire (pour éviter qu'il nous mette KO au tour suivant)
            if (choix == false)
            {
                if (attaquant.Pv <= adverse.Puissance)
                {
                    while (i < ListEquipe.Count)
                    {
                        if (adverse.Puissance < ListEquipe[i][0].Pv)
                        {
                            if (choix == true && ListEquipe[i][0].Pv < actif.Pv)
                            {
                                actif = ListEquipe[i][0];
                            }
                            else
                            {
                                if (choix == false)
                                {
                                    actif = ListEquipe[i][0];
                                    choix = true;
                                }
                            }
                        }
                        i++;
                    }
                }
            }
            //Si aucune des deux possibilités : choix aléatoire
            if (choix == false)
            {
                ChoisirActif(out actif);
            }
            attaquant = actif;
        }
        /// <summary>
        /// Suppression d'un Pokémon KO de la liste des Pokémons de l'équipe
        /// </summary>
        /// <param name="pokemon"></param>
        public void SupprimerPokemonKO(Pokemon pokemon)
        {
            int i = 0;
            while(i<ListEquipe.Count && ListEquipe[i][0]!=pokemon)
            if(pokemon.Pv <= 0)
            {
                while(i<ListEquipe.Count && ListEquipe[i][0]!=pokemon)
                {
                    i++;
                }
                ListEquipe.Remove(ListEquipe[i]);
                NbPokemon = NbPokemon-1;
            }
        }

        public virtual void BattreEnRetraite(ref Pokemon attaquant, ref Pokemon adverse)
        {
            bool changement = false;
            int k = 0;
            //Si l'équipe est attaquante
            if(PossederPokemon(attaquant)==true)
            {
                if(attaquant.Puissance<adverse.Pv)
                {
                    while (k < ListEquipe.Count)
                    {
                        if (adverse.Pv <= ListEquipe[k][0].Puissance)
                        {
                            if (changement == true && ListEquipe[k][0].Puissance < attaquant.Puissance)
                            {
                                attaquant = ListEquipe[k][0];
                            }
                            else
                            {
                                if (changement == false)
                                {
                                    attaquant = ListEquipe[k][0];
                                    changement = true;
                                }
                            }
                        }
                        k++;
                    }
                }
                if(changement==true)
                {
                    Console.WriteLine("Votre adversaire a fait battre en retraite son pokémon, son nouveau pokémon actif est " + attaquant);
                }
            }
            //Si l'équipe est adverse : Si son nombre de PV est inférieur à la puissance d'attaque de l'adversaire, on change 
            else
            {
                if(adverse.Pv<attaquant.Puissance)
                {
                    while(k<ListEquipe.Count)
                    {
                        if(ListEquipe[k][0].Pv>attaquant.Puissance)
                        {
                            if (changement == true && ListEquipe[k][0].Pv < adverse.Pv)
                            {
                                adverse = ListEquipe[k][0];
                                changement = true;
                            }
                            else
                            {
                                if (changement == false)
                                {
                                    adverse = ListEquipe[k][0];
                                    changement = true;
                                }
                            }
                        }
                        k++;
                    }
                }
                if (changement == true)
                {
                    Console.WriteLine("Votre adversaire a fait battre en retraite son pokémon, son nouveau pokémon actif est " + adverse);
                }
            }
        }

        public override string ToString()
        {
            string chRes = "";
            chRes = "Equipe numéro " + Numero +"\n";
            chRes = chRes + "---------------------------------------\n";
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
