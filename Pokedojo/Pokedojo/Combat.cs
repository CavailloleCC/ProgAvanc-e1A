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
        private Random _alea;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="equipe1"></param>
        /// <param name="equipe2"></param>
        public Combat(Equipe equipe1, Equipe equipe2)
        {
            Equipe1 = equipe1;
            Equipe2 = equipe2;
        }

        /// <summary>
        /// Choix aléatoire de l'équipe jouant en premier
        /// </summary>
        /// <returns></returns>
        public Equipe TirerPremierJoueur()
        {
            int premierEquipe = _alea.Next(1, 3);
            if(premierEquipe == 1)
            {
                return Equipe1;
            }
            else
            {
                return Equipe2;
            }
        }

        //Simule un combat entre deux équipes et retourne l'équipe vainqueur
        public Equipe Attaquer()
        {
            Equipe equipeAttaquante = TirerPremierJoueur();
            Equipe equipeAdverse;
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

            while (equipeAdverse.ListEquipe.Count != 0 && equipeAttaquante.ListEquipe.Count != 0)
            {
                if(attaquant.Type == adverse.Faiblesse)
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
                }
                if(equipeAdverse.ListEquipe.Count != 0 && equipeAttaquante.ListEquipe.Count != 0)
                {
                    equipeAdverse = equipeAttaquante;
                    equipeAttaquante = equipeAdverse;
                    adverse = attaquant;
                    attaquant = equipeAttaquante.ChoisirActif();
                }
            }
            return equipeAttaquante;

            
        }
        
    }
}
