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
        private Random _alea = new Random();
        protected static int _numeroCombat = 0;
        public int NumeroCombat { get; protected set;}

        /// <summary>
        /// Constructeur
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
        /// Choix aléatoire de l'équipe jouant en premier
        /// </summary>
        /// <returns></returns>
        public Equipe TirerPremierJoueur()
        {
            Equipe premiereEquipe;
            int premierEquipe = _alea.Next(1, 3);
            if(premierEquipe == 1)
            {
                premiereEquipe = Equipe1;
            }
            else
            {
                premiereEquipe = Equipe2;
            }
            if(Equipe1 is EquipeReelle || Equipe2 is EquipeReelle)
            {
                if(premiereEquipe is EquipeReelle)
                {
                    Console.WriteLine("C'est à votre équipe d'attaquer en premier.");
                }
                else
                {
                    Console.WriteLine("C'est à l'équipe adverse d'attaquer en premier");
                }
            }
            return premiereEquipe;

        }

        public void Attaquer(Equipe equipeAttaquante,Equipe equipeAdverse, Pokemon attaquant, Pokemon adverse)
        {
            if (attaquant.Type == adverse.Faiblesse)
            {
                adverse.Pv = adverse.Pv - (2 * attaquant.Puissance);
            }
            else
            {
                adverse.Pv = adverse.Pv - attaquant.Puissance;
            }
            if (adverse.Pv <= 0)
            {
                equipeAdverse.SupprimerPokemonKO(adverse);
                if (equipeAdverse is EquipeReelle)
                {
                    Console.WriteLine("Votre Pokémon actif a été mis KO...");
                }
                else
                {
                    if (equipeAttaquante is EquipeReelle)
                    {
                        Console.WriteLine("Le Pokémon adverse a été mis KO !");
                    }
                }
            }
        }
        /// <summary>
        /// Simule un combat entre deux équipes et retourne l'équipe vainqueur
        /// </summary>
        /// <returns></returns>
        public Equipe Combattre()
        {
            //Affichage des caractéristiques des 2 équipes si l'équipe réelle fait partie du combat
            if (Equipe1 is EquipeReelle || Equipe2 is EquipeReelle)
            {
                Console.WriteLine(Equipe1);
                Console.WriteLine(Equipe2);
            }
            Equipe equipeAttaquante = TirerPremierJoueur();
            Equipe equipeAdverse;//équipe adverse correspond à l'équipe qui n'attaque pas
            if (equipeAttaquante == Equipe1)
            {
                equipeAdverse = Equipe2;
            }
            else
            {
                equipeAdverse = Equipe1;
            }
            Pokemon attaquant = equipeAttaquante.ChoisirActif();
            Pokemon adverse = equipeAdverse.ChoisirActif();
            Pokemon temp;

            while (equipeAdverse.NbPokemon != 0 && equipeAttaquante.NbPokemon != 0)
            {
                Attaquer(equipeAttaquante, equipeAdverse, attaquant, adverse);
                /*if(attaquant.Type == adverse.Faiblesse)
                {
                    adverse.Pv=adverse.Pv - (2 * attaquant.Puissance);
                }
                else
                {
                    adverse.Pv=adverse.Pv - attaquant.Puissance;
                }
                if(adverse.Pv<=0)
                {
                    equipeAdverse.SupprimerPokemonKO(adverse);
                    if(equipeAdverse is EquipeReelle)
                    {
                        Console.WriteLine("Votre Pokémon actif a été mis KO...");
                    }
                    else
                    {
                        if(equipeAttaquante is EquipeReelle)
                        {
                            Console.WriteLine("Le Pokémon adverse a été mis KO !");
                        }
                    }
                }*/
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
                    if (Equipe1 is EquipeReelle || Equipe2 is EquipeReelle)
                    {
                        Console.WriteLine(Equipe1);
                        Console.WriteLine(Equipe2);
                    }
                    if (temp.Pv <= 0)
                    {
                        attaquant = equipeAttaquante.ChoisirActif();
                    }
                    else
                    {
                        attaquant = temp;
                    }
                }
            }
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
            else
            {
                Console.WriteLine("L'équipe gagnante est l'équipe " + equipeAttaquante.Numero+"\n");
            }
            return equipeAttaquante;
        }

        public override string ToString()
        {
            string chRes = "";
            if(NumeroCombat==1)
            {
                chRes = chRes + "PREMIER TOUR\n\n";
            }
            else
            {
                if(NumeroCombat==9)
                {
                    chRes = chRes + "SECOND TOUR\n\n";
                }
                else
                {
                    if(NumeroCombat==13)
                    {
                        chRes = chRes + "TROISIEME TOUR\n\n";
                    }
                    else
                    {
                        if(NumeroCombat==15)
                        {
                            chRes = chRes + "FINALE\n\n";
                        }
                    }
                }
            }
            chRes = chRes + "Combat numéro "+NumeroCombat+"\nCombat entre les équipes " + Equipe1.Numero + " et " + Equipe2.Numero;
            return chRes;
        }
    }
}
