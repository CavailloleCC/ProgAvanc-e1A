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
            BddPokemon = bddPokemon;
            NbPokemon = 3;
            Numero = ++_numeroEquipe;
            VictoiresConsecutives = 0;
            ListEquipe = new List<List<Pokemon>>();
            int index;
            //Attribution de 3 Pokémons (et leurs évolutions) disponibles dans la base de données
            for(int i=0; i<3; i++)
            {
                index = _alea.Next(BddPokemon.NbPokemonDispo);
                int b = BddPokemon.NbPokemonDispo;
                ListEquipe.Add(BddPokemon.ListeBddPokemon[index]);
                //Suppression du Pokémon de la base de données une fois attribué à l'équipe
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
        /// Choix du Pokémon actif en début de combat : comportement différent pour chaque classe dérivée
        /// </summary>
        /// <returns></returns>
        public abstract void ChoisirActif(out Pokemon actif);

        /// <summary>
        /// Choix d'un Pokémon actif au cours du combat : comportement différent pour chaque classe dérivée
        /// </summary>
        /// <param name="adverse"></param>
        /// <returns></returns>
        public abstract void ChoisirActif(ref Pokemon attaquant, Pokemon adverse);

        /// <summary>
        /// Suppression d'un Pokémon et des ses Pokémons évolués lorsque le Pokémon actif a été mis KO
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
        /// Fait battre en retraite le Pokmon actif : comportement différent pour chaque classe dérivée
        /// </summary>
        /// <param name="attaquant"></param>
        /// <param name="adverse"></param>
        /// <returns></returns>
        public abstract bool BattreEnRetraite(ref Pokemon attaquant, ref Pokemon adverse);

        /// <summary>
        /// Faire évoluer un Pokémon quand c'est possible (2 évolutions possibles par tournoi) : comportement différent pour chaque classe dérivée
        /// </summary>
        /// <param name="pokemon"></param>
        public abstract void Evoluer(ref Pokemon pokemon);

        /// <summary>
        /// Gère l'état de VictoiresConsecutives et les évolutions du Pokémon en cas de victoire de celui-ci
        /// </summary>
        /// <param name="attaquant"></param>
        public void GererVictoires(ref Pokemon attaquant)
        {
            //Si l'équipe attaquante a déjà fait une victoire au combat précédent et qu'elle n'a pas changé de Pokémon entre temps
            if (VictoiresConsecutives > 0)
            {
                VictoiresConsecutives += 1;
                if (VictoiresConsecutives > 1 && VictoiresConsecutives < 4)//Au bout de 3 victoires consécutives on arrive à l'évolution maximale du Pokémon
                {
                    Evoluer(ref attaquant);
                }
            }
            //Si c'est la première victoire consécutive du Pokémon actif
            else
            {
                VictoiresConsecutives += 1;
            }
        }

        /// <summary>
        /// Choix du joueur concernant l'utilisation ou non d'une attaque spécifique : comportement différent pour chaque classe dérivée
        /// </summary>
        /// <param name="attaquant"></param>
        /// <param name="adverse"></param>
        /// <returns></returns>
        public abstract bool UtiliserAttaqueSpe(Pokemon attaquant,Pokemon adverse);

        /// <summary>
        /// Attaque du Pokémon adverse par le Pokémon attaquant de l'équipe :
        /// -Attaque spécifique si l'équipe à décider d'utiliser l'attaque spécifique de son Pokémon
        ///  Lorsqu'une attaque spécifique est utilisée, elle est mise à null pour le Pokémon auquel elle appartient (une attaque spécifique ne peut être utilisée qu'une fois par tournoi)
        /// -Attaque normale sinon
        /// </summary>
        /// <param name="attaquant"></param>
        /// <param name="adverse"></param>
        public void Attaquer(Pokemon attaquant, Pokemon adverse)
        {
            //Si une attaque spécifique est utilisée 
            if(attaquant.TypeAttaque is AttaqueSpecifique && UtiliserAttaqueSpe(attaquant,adverse)==true)
            {
                attaquant.TypeAttaque.AttaquerSpe(adverse);
                //On retire l'attaque spécifique du Pokémon, il ne pourra plus l'utiliser au cours du tournoi
                attaquant.TypeAttaque = null;
                attaquant.AttaqueSpe = null;
            }
            //Si c'est une attaque normale
            else
            {
                attaquant.AttaquerNormal(adverse);
            }
        }

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
