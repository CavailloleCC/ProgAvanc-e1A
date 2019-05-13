using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedojo
{
    class EquipeSimulee : Equipe
    {
        /// <summary>
        /// Constructeur de la classe EquipeSimulee
        /// </summary>
        /// <param name="bddPokemon"></param>
        public EquipeSimulee(BaseDeDonnees bddPokemon):base(bddPokemon)
        { }

        /// <summary>
        /// Choix aléatoire du Pokémon actif parmi les Pokémons de l'équipe en début de combat : retourne le nom du Pokémon actif
        /// </summary>
        /// <returns></returns>
        public override void ChoisirActif(out Pokemon actif)
        {
            int numero = _alea.Next(NbPokemon);
            actif = ListEquipe[numero][0];
            //Le nombre de victoire consécutives est remis à 0 lorsqu'on commence un nouveau combat
            VictoiresConsecutives = 0;
        }

        /// <summary>
        /// Choix d'un Pokémon de façon intelligente
        /// </summary>
        /// <param name="adverse"></param>
        /// <returns></returns>
        public override void ChoisirActif(ref Pokemon attaquant, Pokemon adverse)
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
        /// Fait battre en retraite le Pokémon actif de l'équipe si :
        /// -le joueur est attaquant et que sa puissance d'attaque est inférieure au nombre de PV de son adversaire mais qu'il possède un Pokémon dont la puissance est supérieur à ce nombre de PV
        /// -le joueur est adverse et que son nombre de PV est inférieur ou égal à la puissance d'attaque de son adversaire mais qu'il possède un Pokémon dont le nombre de PV est supérieur à cette puissance 
        /// Retourne true si le Pokémon a été mis en retraite, false sinon : Le nombre de victoires consécutives passe à 0 lorsque la fonction renvoie true
        /// 
        /// </summary>
        /// <param name="attaquant"></param>
        /// <param name="adverse"></param>
        /// <returns></returns>
        public override bool BattreEnRetraite(ref Pokemon attaquant, ref Pokemon adverse)
        {
            bool changement = false;
            if(NbPokemon>1)
            {
                int k = 0;
                //Si l'équipe est attaquante
                if (PossederPokemon(attaquant) == true)
                {
                    if (attaquant.Puissance < adverse.Pv)
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
                }
                //Si l'équipe est adverse : Si son nombre de PV est inférieur à la puissance d'attaque de l'adversaire, on change 
                else
                {
                    if (adverse.Pv < attaquant.Puissance)
                    {
                        while (k < ListEquipe.Count)
                        {
                            if (ListEquipe[k][0].Pv > attaquant.Puissance)
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
                }
                //Si on change de Pokémon, le nombre de victoires consécutives passe à 0
                if (changement == true)
                {
                    VictoiresConsecutives = 0;
                }
            }
            return changement;
        }

        /// <summary>
        /// Faire évoluer un Pokémon quand c'est possible (2 évolutions possibles par tournoi)
        /// </summary>
        /// <param name="pokemon"></param>
        public override void Evoluer(ref Pokemon pokemon)
        {
            int i = 0;
            while (i < ListEquipe.Count && ListEquipe[i][0] != pokemon)
            {
                i++;
            }
            //Si une évolution est encore possible pour le Pokémon
            if (i < ListEquipe.Count && ListEquipe[i].Count > 1)
            {
                ListEquipe[i].Remove(ListEquipe[i][0]);
                pokemon = ListEquipe[i][0];
            }
        }

        /// <summary>
        /// L'équipe simulée utilise l'attaque spécifique de son Pokémon actif si il en possède une dans le cas où sa puissance
        /// d'attaque n'est pas assez élevée pour mettre KO son adversaire et qu'il sait qu'il est susceptible de se faire tuer par
        /// son adversaire au tour suivant (puissance d'attaque de l'adversaire supérieure au nombre de Pv du Pokémon actif de l'équipe)
        /// Renvoie true si l'attaque est utilisée, false sinon
        /// </summary>
        /// <param name="attaquant"></param>
        /// <param name="adverse"></param>
        /// <returns></returns>
        public override bool UtiliserAttaqueSpe(Pokemon attaquant, Pokemon adverse)
        {
            bool choix = false;
            if(attaquant.AttaqueSpe != null)
            {
                if(attaquant.Puissance<adverse.Pv && attaquant.Pv <= adverse.Puissance)
                {
                    choix = true;
                }
            }
            return choix;
        }
    }
}
