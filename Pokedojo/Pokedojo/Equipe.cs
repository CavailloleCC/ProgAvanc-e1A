using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedojo
{
    class Equipe
    {
        List<Pokemon> _listEquipe;
        private Random _alea;
        protected static int _numeroEquipe = 0;
        public int Numero { get; protected set; }

        public Equipe()
        {
            Numero = ++_numeroEquipe;
            _listEquipe = new List<Pokemon>;
            for(int i=0; i<3; i++)
            {
                _listEquipe.Add();
            }
        }
    }
}
