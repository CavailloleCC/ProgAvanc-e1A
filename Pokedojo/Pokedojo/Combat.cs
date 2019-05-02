using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedojo
{
    class Combat
    {
        private Equipe _equipe1;
        private Equipe _equipe2;
        private Random _alea;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="equipe1"></param>
        /// <param name="equipe2"></param>
        public Combat(Equipe equipe1, Equipe equipe2)
        {
            _equipe1 = equipe1;
            _equipe2 = equipe2;
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
                return _equipe1;
            }
            else
            {
                return _equipe2;
            }
        }

        //Simule un combat entre deux équipes et retourne l'équipe vainqueur
        public Equipe Attaquer()
        {
            Equipe equipeAttaquante = TirerPremierJoueur();
            Equipe equipeAdverse;
            if (equipeAttaquante == _equipe1)
            {
                equipeAdverse = _equipe2;
            }
            else
            {
                equipeAdverse = _equipe1;
            }
            Pokemon attaquant = equipeAttaquante.ChoisirActif();
            Pokemon adverse = equipeAdverse.ChoisirActif();

            while (equipeAdverse.GetListEquipe().Count != 0 && equipeAttaquante.GetListEquipe().Count != 0)
            {
                if(attaquant.GetType() == adverse.GetFaiblesse())
                {
                    adverse.SetPv(adverse.GetPv() - (2 * attaquant.GetPuissance()));
                }
                else
                {
                    adverse.SetPv(adverse.GetPv() - attaquant.GetPuissance());
                }
                if(adverse.GetPv()<=0)
                {
                    equipeAdverse.SupprimerPokemonKO(adverse);
                }
                if(equipeAdverse.GetListEquipe().Count != 0 && equipeAttaquante.GetListEquipe().Count != 0)
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
