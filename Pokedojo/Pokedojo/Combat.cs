using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedojo
{
    class Combat
    {
        public Equipe Equipe1 { get; set; }
        private Equipe Equipe2 { get; set; }
        private static Random _alea = new Random();
        protected static int _numeroCombat = 0;
        public int NumeroCombat { get; protected set;}

        /// <summary>
        /// Constructeur de la classe combat
        /// </summary>
        /// <param name="equipe1"></param>
        /// <param name="equipe2"></param>
        public Combat(Equipe equipe1, Equipe equipe2)
        {
            Equipe1 = equipe1;
            Equipe2 = equipe2;
            NumeroCombat = ++_numeroCombat;
        }

        /// <summary>
        /// Choix aléatoire de l'équipe jouant en premier : Attribue l'équipe qui attaque en premier à equipeAttaquante et l'autre équipe à equipeAdverse
        /// </summary>
        /// <returns></returns>
        public void TirerPremierJoueur(out Equipe equipeAttaquante, out Equipe equipeAdverse)
        {
            int premierEquipe = _alea.Next(1, 3);
            if(premierEquipe == 1)
            {
                equipeAttaquante = Equipe1;
                equipeAdverse = Equipe2;
            }
            else
            {
                equipeAttaquante = Equipe2;
                equipeAdverse = Equipe1;
            }
            if(Equipe1 is EquipeReelle || Equipe2 is EquipeReelle)
            {
                if(equipeAttaquante is EquipeReelle)
                {
                    Console.WriteLine("C'est à votre équipe d'attaquer en premier.\n");
                }
                else
                {
                    Console.WriteLine("C'est à l'équipe adverse d'attaquer en premier\n");
                }
            }
        }

        /// <summary>
        /// Simule une attaque entre deux Pokémons de deux équipes distinctes
        /// </summary>
        /// <param name="equipeAttaquante"></param>
        /// <param name="equipeAdverse"></param>
        /// <param name="attaquant"></param>
        /// <param name="adverse"></param>
        public void AttaquerEquipe(Equipe equipeAttaquante,Equipe equipeAdverse,ref Pokemon attaquant, Pokemon adverse)
        {
            equipeAttaquante.Attaquer(attaquant, adverse);
            if(adverse.Pv<=0)
            {
                equipeAdverse.SupprimerPokemonKO(adverse);
                if (equipeAdverse is EquipeReelle || equipeAttaquante is EquipeReelle)
                {
                    Console.WriteLine(adverse.Nom+" a été mis KO par "+attaquant.Nom+"\n");
                }
                equipeAttaquante.GererVictoires(ref attaquant);
            }
            //Si le Pokémon ne fait pas de KO, on met le nombre de victoire consécutives à 0
            else
            {
                equipeAttaquante.VictoiresConsecutives = 0;
            }
        }

        /// <summary>
        /// Démarrer le combat entre les deux équipes :
        /// Choix des Pokémons actifs, choix de l'équipe attaquant en premier, 
        /// attribution des rôles à chaque équipe (équipe attaquante ou adverse), attribution des rôles à chaque Pokémon actif (attaquant ou adverse)
        /// </summary>
        /// <param name="attaquant"></param>
        /// <param name="adverse"></param>
        /// <param name="equipeAttaquante"></param>
        /// <param name="equipeAdverse"></param>
        public void DemarrerCombat(out Pokemon attaquant, out Pokemon adverse, out Equipe equipeAttaquante, out Equipe equipeAdverse)
        {
            Pokemon temp;
            //Affichage des caractéristiques des 2 équipes si l'équipe réelle fait partie du combat
            if (Equipe1 is EquipeReelle || Equipe2 is EquipeReelle)
            {
                if (Equipe1 is EquipeReelle)
                {
                    Console.WriteLine("Vous combattez contre l'équipe " + Equipe2.Numero + "\n");
                }
                else
                {
                    Console.WriteLine("Vous combattez contre l'équipe " + Equipe1.Numero + "\n");
                }
                Console.WriteLine(Equipe1);
                Console.WriteLine(Equipe2);
            }
            //Choix des Pokémons actifs pour chaque équipe des Pokémons (attribution de leur rôle de façon arbitraire pour l'instant)
            Equipe1.ChoisirActif(out attaquant);
            Equipe2.ChoisirActif(out adverse);
            //Choix de l'équipe qui attaque en premier
            TirerPremierJoueur(out equipeAttaquante, out equipeAdverse);
            //Attribution des bons rôles des Pokémons actif de chaque équipe 
            if (Equipe1 == equipeAdverse)
            {
                temp = adverse;
                adverse = attaquant;
                attaquant = temp;
            }
        }

        /// <summary>
        /// Simulation d'un match entre deux équipes : succession de combat jusqu'à ce qu'une des deux équipes ait mis KO tous ses adversaires
        /// Retourne l'équipe vainqueur
        /// </summary>
        /// <returns></returns>
        public Equipe Combattre()
        {
            //Initialisation des variables
            Pokemon attaquant;
            Pokemon adverse;
            Pokemon temp;
            Equipe equipeAttaquante;
            Equipe equipeAdverse;//équipe adverse correspond à l'équipe qui n'attaque pas
            bool retraiteAdverse;
            bool retraiteAttaquant;
            //On démarre le combat entre les deux équipes
            DemarrerCombat(out attaquant, out adverse, out equipeAttaquante, out equipeAdverse);
            //Succession de combat jusqu'à ce qu'une des deux équipes ait mis tous ces adversaires KO
            while (equipeAdverse.NbPokemon != 0 && equipeAttaquante.NbPokemon != 0)
            {
                AttaquerEquipe(equipeAttaquante, equipeAdverse, ref attaquant, adverse);
                //On échange les rôles des équipes et des Pokémons si le combat n'est pas terminé
                if(equipeAdverse.NbPokemon != 0 && equipeAttaquante.NbPokemon != 0)
                {
                    equipeAdverse = equipeAttaquante;
                    if(equipeAdverse==Equipe1)
                    {
                        equipeAttaquante = Equipe2;
                    }
                    else
                    {
                        equipeAttaquante = Equipe1;
                    }
                    temp = adverse;
                    adverse = attaquant;
                    //Si le Pokémon qui était adverse a été mis KO, choix d'un nouveau Pokémon actif par l'équipe qui devient attaquante
                    if (temp.Pv <= 0)
                    {
                        if(equipeAttaquante is EquipeReelle)
                        {
                            Console.WriteLine(Equipe1);
                            Console.WriteLine(Equipe2);
                        }
                        //L'équipe dont le Pokémon a été mis KO doit choisir un nouveau Pokémon actif
                        equipeAttaquante.ChoisirActif(ref attaquant, adverse);
                        if(Equipe1 is EquipeReelle || Equipe2 is EquipeReelle)
                        {
                            Console.WriteLine("Le Pokémon attaquant est à présent " + attaquant.Nom + "\n" + adverse.Nom + " devient adverse\n");
                        }
                        //L'équipe qui devient attaquante a la possibilité de faire battre en retraite son Pokémon actif
                        retraiteAdverse = equipeAdverse.BattreEnRetraite(ref adverse, ref attaquant);
                        if(equipeAttaquante is EquipeReelle && retraiteAdverse==true)
                        {
                            Console.WriteLine("Votre adversaire a fait battre en retraite son pokémon, son nouveau pokémon actif est " + adverse.Nom);
                        }
                    }
                    //Sinon le Pokémon qui était adverse devient attaquant
                    else
                    {
                        attaquant = temp;
                        if (Equipe1 is EquipeReelle || Equipe2 is EquipeReelle)
                        {
                            Console.WriteLine(attaquant.Nom + " devient attaquant\n" + adverse.Nom + " devient adverse\n");
                        }
                        //Les équipes ont la possibilité de battre leur Pokémon actif en retraite
                        retraiteAdverse = equipeAdverse.BattreEnRetraite(ref attaquant, ref adverse);
                        retraiteAttaquant=equipeAttaquante.BattreEnRetraite(ref attaquant, ref adverse);
                        if (equipeAdverse is EquipeReelle && retraiteAttaquant == true)
                        {
                            Console.WriteLine("Votre adversaire a fait battre en retraite son pokémon, son nouveau pokémon actif est " + attaquant.Nom);
                        }
                        else
                        {
                            if(equipeAttaquante is EquipeReelle && retraiteAdverse==true)
                            {
                                Console.WriteLine("Votre adversaire a fait battre en retraite son pokémon, son nouveau pokémon actif est " + adverse.Nom);
                            }
                        }
                    }
                }
            }
            //Déclaration de l'équipe vainqueure 
            if(Equipe1 is EquipeReelle || Equipe2 is EquipeReelle)
            {
                if((Equipe1 is EquipeReelle && Equipe1==equipeAttaquante)||(Equipe2 is EquipeReelle && Equipe2==equipeAttaquante))
                {
                    Console.WriteLine("Votre équipe a gagné le combat !\n");
                }
                else
                {
                    Console.WriteLine("Votre équipe a perdu le combat, vous êtes éliminé...\n");
                }
            }
            return equipeAttaquante;
        }

        /// <summary>
        /// Affichage
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string chRes = "";
            if(NumeroCombat==1)
            {
                chRes = chRes + "###################################################################################\nPREMIER TOUR\n\n";
            }
            else
            {
                if(NumeroCombat==9)
                {
                    chRes = chRes + "###################################################################################\nSECOND TOUR\n\n";
                }
                else
                {
                    if(NumeroCombat==13)
                    {
                        chRes = chRes + "###################################################################################\nTROISIEME TOUR\n\n";
                    }
                    else
                    {
                        if(NumeroCombat==15)
                        {
                            chRes = chRes + "###################################################################################\nFINALE\n\n";
                        }
                    }
                }
            }
            return chRes;
        }
    }
}
