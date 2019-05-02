﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedojo
{
    class Pokemon
    {
        private string _nom;
        private int _pv;
        private int _puissance;
        private string _type;
        private string _faiblesse;
        private string _attaqueSpe;

        public Pokemon(string nom, int pv, int puissance, string type, string faiblesse, string attaqueSpe)
        {
            _nom = nom;
            _pv = pv;
            _puissance = puissance;
            _type = type;
            _faiblesse = faiblesse;
            _attaqueSpe = attaqueSpe;
        }

        public Pokemon(string nom, int pv, int puissance, string type, string faiblesse): this(nom, pv, puissance, type, faiblesse, "")
        { } 
    }
}
