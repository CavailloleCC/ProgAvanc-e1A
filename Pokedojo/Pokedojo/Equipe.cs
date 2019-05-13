﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedojo
{
    abstract class Equipe
    {
        public List<List<Pokemon>> ListEquipe { get; set; }
        public int NbPokemon { get; set; }
        protected static Random _alea = new Random();
        protected static int _numeroEquipe = 0;
        public BaseDeDonnees BddPokemon { get; set; }
        public int Numero { get; protected set; }
        public int VictoiresConsecutives { get; set; }

        /// <summary>
        /// Constructeur de la classe Equipe
        /// </summary>
        /// <param name="bddPokemon"></param>
        public Equipe(BaseDeDonnees bddPokemon)
        {
            NbPokemon = 3;
            BddPokemon = bddPokemon;
            Numero = ++_numeroEquipe;
            VictoiresConsecutives = 0;
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

        /// <summary>
        /// Renvoie true si l'équipe possède le Pokémon, false sinon
        /// </summary>
        /// <param name="pokemon"></param>
        /// <returns></returns>
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
        /// Choix du Pokémon actif en début de combat
        /// </summary>
        /// <returns></returns>
        public abstract void ChoisirActif(out Pokemon actif);

        /// <summary>
        /// Choix d'un Pokémon actif au cours du combat
        /// </summary>
        /// <param name="adverse"></param>
        /// <returns></returns>
        public abstract void ChoisirActif(ref Pokemon attaquant, Pokemon adverse);

        /// <summary>
        /// Suppression d'un Pokémon KO et des ses Pokémons évolués 
        /// </summary>
        /// <param name="pokemon"></param>
        public void SupprimerPokemonKO(Pokemon pokemon)
        {
            //Lorsqu'un Pokémon est KO il ne pourra plus faire de victoires consécutives : le nombre de victoires consécutives passe à 0
            VictoiresConsecutives = 0;
            int i = 0;
            if(pokemon.Pv <= 0)
            {
                while(i<ListEquipe.Count && ListEquipe[i][0]!=pokemon)
                {
                    i++;
                }
                if(i<ListEquipe.Count)
                {
                    ListEquipe.Remove(ListEquipe[i]);
                    NbPokemon = NbPokemon - 1;
                }
            }
        }

        /// <summary>
        /// Fait battre en retraite le Pokmon actif 
        /// </summary>
        /// <param name="attaquant"></param>
        /// <param name="adverse"></param>
        /// <returns></returns>
        public abstract bool BattreEnRetraite(ref Pokemon attaquant, ref Pokemon adverse);

        /// <summary>
        /// Faire évoluer un Pokémon quand c'est possible (2 évolutions possibles par tournoi)
        /// </summary>
        /// <param name="pokemon"></param>
        public abstract void Evoluer(ref Pokemon pokemon);
        /*{
            int i = 0;
            while(i<ListEquipe.Count && ListEquipe[i][0]!=pokemon)
            {
                i++;
            }
            //Si une évolution est encore possible pour le Pokémon
            if(i<ListEquipe.Count && ListEquipe[i].Count>1)
            {
                ListEquipe[i].Remove(ListEquipe[i][0]);
                Console.WriteLine(pokemon.Nom + " a évolué en " + ListEquipe[i][0].Nom);
                pokemon = ListEquipe[i][0];
            }
        }*/

        /// <summary>
        /// Affichage des informations relatives à la classe Equipe
        /// </summary>
        /// <returns></returns>
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
