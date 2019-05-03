using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedojo
{
    class Equipe
    {
        public List<Pokemon> ListEquipe { get; set; }
        public int NbPokemon { get; set; }
        private Random _alea;
        protected static int _numeroEquipe = 0;
        public BaseDeDonnees BddPokemon { get; set; }
        public int Numero { get; protected set; }

        /// <summary>
        /// Constructeur de la classe Equipe
        /// </summary>
        /// <param name="bddPokemon"></param>
        public Equipe(BaseDeDonnees bddPokemon)
        {
            NbPokemon = 3;
            BddPokemon = bddPokemon;
            Numero = ++_numeroEquipe;
            ListEquipe = new List<Pokemon>();
            int index;
            for(int i=0; i<3; i++)
            {
                index = _alea.Next(BddPokemon.ListePokemon.Count);
                ListEquipe.Add(BddPokemon.ListePokemon[index]);
                BddPokemon.SupprimerPokemon(BddPokemon.ListePokemon[index]);
            }
        }
        /// <summary>
        /// Choix aléatoire du Pokémon actif parmi les Pokémons de l'équipe : retourne le nom du Pokémon actif
        /// </summary>
        /// <returns></returns>
        public virtual Pokemon ChoisirActif()
        {
            int numero = _alea.Next(ListEquipe.Count);
            return ListEquipe[numero];
        }
        /// <summary>
        /// Suppression d'un Pokémon KO de la liste des Pokémons de l'équipe
        /// </summary>
        /// <param name="pokemon"></param>
        public void SupprimerPokemonKO(Pokemon pokemon)
        {
            if(pokemon.Pv <= 0)
            {
                ListEquipe.Remove(pokemon);
                NbPokemon = NbPokemon - 1;
            }
        }

        public List<Pokemon> GetListEquipe()
        {
            return ListEquipe;
        }
    }
}
