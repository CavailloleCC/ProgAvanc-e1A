using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedojo
{
    class Equipe
    {
        public List<Pokemon> ListEquipe { get; set; }
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
            ListEquipe = new List<Pokemon>();
            int index;
            for(int i=0; i<3; i++)
            {
                index = _alea.Next(BddPokemon.NbPokemonDispo);
                ListEquipe.Add(BddPokemon.ListePokemon[index]);
                BddPokemon.SupprimerPokemon(BddPokemon.ListePokemon[index]);
            }
        }

        /// <summary>
        /// Choix aléatoire du Pokémon actif parmi les Pokémons de l'équipe : retourne le nom du Pokémon actif
        /// </summary>
        /// <returns></returns>
        public virtual Pokemon ChoisirActif()
        {
            int numero = _alea.Next(NbPokemon);
            return ListEquipe[numero];
        }


        /// <summary>
        /// Suppression d'un Pokémon KO de la liste des Pokémons de l'équipe
        /// </summary>
        /// <param name="pokemon"></param>
        public void SupprimerPokemonKO(Pokemon pokemon)
        {
            if(pokemon.Pv <= 0)
            {
                ListEquipe.Remove(pokemon);
                NbPokemon = NbPokemon-1;
            }
        }

        public virtual void BattreEnRetraite(ref Pokemon attaquant, ref Pokemon adverse)
        {
            bool changement = false;
            //Si le l'équipe est attaquante
            if(ListEquipe.Contains(attaquant))
            {
                if(attaquant.Puissance<adverse.Pv)
                {
                    foreach(Pokemon pok in ListEquipe)
                    {
                        if(pok.Puissance>adverse.Pv)
                        {
                            if(changement==true && pok.Puissance<attaquant.Puissance)
                            {
                                attaquant = pok;
                                changement = true;
                            }
                            else
                            {
                                if(changement==false)
                                {
                                    attaquant = pok;
                                    changement = true;
                                }
                            }
                        }
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
                    foreach(Pokemon pok in ListEquipe)
                    {
                        if(changement==true && pok.Pv<adverse.Pv)
                        {
                            adverse = pok;
                            changement = true;
                        }
                        else
                        {
                            if(changement ==false)
                            {
                                adverse = pok;
                                changement = true;
                            }
                        }
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
            foreach(Pokemon pokemon in ListEquipe)
            {
                chRes = chRes + pokemon.ToString();
                chRes = chRes + "---------------------------------------\n";
            }
            return chRes;
        }
    }
}
