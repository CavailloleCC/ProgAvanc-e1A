using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedojo
{
    class Equipe
    {
        protected List<Pokemon> _listEquipe;
        private int _nbPokemon;
        private Random _alea;
        protected static int _numeroEquipe = 0;
        BaseDeDonnees _bddPokemon;
        public int Numero { get; protected set; }

        /// <summary>
        /// Constructeur de la classe Equipe
        /// </summary>
        /// <param name="bddPokemon"></param>
        public Equipe(BaseDeDonnees bddPokemon)
        {
            _nbPokemon = 3;
            _bddPokemon = bddPokemon;
            Numero = ++_numeroEquipe;
            _listEquipe = new List<Pokemon>();
            int index;
            for(int i=0; i<3; i++)
            {
                index = _alea.Next(_bddPokemon.GetListe().Count);
                _listEquipe.Add(_bddPokemon.GetListe()[index]);
                _bddPokemon.SupprimerPokemon(index);
            }
        }
        /// <summary>
        /// Choix aléatoire du Pokémon actif parmi les Pokémons de l'équipe : retourne le nom du Pokémon actif
        /// </summary>
        /// <returns></returns>
        public virtual Pokemon ChoisirActif()
        {
            int numero = _alea.Next(_listEquipe.Count);
            return _listEquipe[numero];
        }
        /// <summary>
        /// Suppression d'un Pokémon KO de la liste des Pokémons de l'équipe
        /// </summary>
        /// <param name="pokemon"></param>
        public void SupprimerPokemonKO(Pokemon pokemon)
        {
            if(pokemon.GetPv() <= 0)
            {
                _listEquipe.Remove(pokemon);
                _nbPokemon = _nbPokemon - 1;
            }
        }
    }
}
