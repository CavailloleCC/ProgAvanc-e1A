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

        public Tournoi()
        {
            BddPokemon = new BaseDeDonnees();
            ListeTournoi = new List<Equipe>();
            Equipe equipeTournoi;
            for(int i=0;i<16;i++)
            {
                equipeTournoi = new Equipe(BddPokemon);
                ListeTournoi.Add(equipeTournoi);
            }
        }


    }
}
