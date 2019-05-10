using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedojo
{
    class BaseDeDonnees
    {
        public List<Pokemon> ListePokemon { get; set; }
        public int NbPokemonDispo { get; set; }

        public BaseDeDonnees()
        {
            Pokemon bulbizarre = new Pokemon("bulbizarre", 45, 49, "plante", "feu", "");
            Pokemon herbizarre = new Pokemon("herbizarre", 60, 62, "plante", "feu", "paralysie");
            Pokemon florizarre = new Pokemon("florizarre", 80, 82, "plante", "feu", "paralysie");
            Pokemon salameche = new Pokemon("salameche", 39, 52, "feu", "eau", "brulure");
            Pokemon reptincel = new Pokemon("reptincel", 58, 64, "feu", "eau", "brulure");
            Pokemon dracaufeu = new Pokemon("dracaufeu", 78, 84, "feu", "roche", "brulure");
            Pokemon carapuce = new Pokemon("carapuce", 44, 48, "eau", "electrik", "sommeil");
            Pokemon carabaffe = new Pokemon("carabaffe", 59, 63, "eau", "electrik", "");
            Pokemon tortank = new Pokemon("tortank", 79, 83, "eau", "electrik", "");
            Pokemon chenipan = new Pokemon("chenipan", 45, 30, "feu", "eau", "brulure");
            Pokemon chrysacier = new Pokemon("chrysacier", 50, 20, "insecte", "feu", "gel");
            Pokemon papilusion = new Pokemon("papilusion", 60, 45, "insecte", "feu", "gel");
            Pokemon nidoranf = new Pokemon("nidoranf", 55, 47, "poison", "sol", "");
            Pokemon nidorina = new Pokemon("nidorina", 70, 62, "poison", "sol", "empoisonnement");
            Pokemon nidoqueen = new Pokemon("nidorina", 90, 92, "poison", "sol", "empoisonnement");
            Pokemon aspicot = new Pokemon("aspicot", 40, 35, "insecte", "feu", "");
            Pokemon coconfort = new Pokemon("coconfort", 45, 25, "insecte", "feu", "");
            Pokemon dardargnan = new Pokemon("dardargnan", 65, 90, "insecte", "feu", "");
            Pokemon pikachu = new Pokemon("pikachu", 35, 55, "electrik", "sol", "gel");
            Pokemon raichuAlola = new Pokemon("raichuAlola", 60, 85, "electrik", "sol", "paralysie");
            Pokemon raichu = new Pokemon("raichu", 60, 90, "electrik", "sol", "paralysie");
            Pokemon nidoranm = new Pokemon("nidoranm", 46, 57, "poison", "sol", "empoisonnement");
            Pokemon nidorino = new Pokemon("nidorino", 61, 72, "poison", "sol", "empoisonnement");
            Pokemon nidoking = new Pokemon("nidorino", 81, 102, "poison", "sol", "empoisonnement");
            Pokemon melo = new Pokemon("melo", 50, 25, "fee", "poison", "sommeil");
            Pokemon melofee = new Pokemon("melofee", 70, 45, "fee", "poison OUUUUU acier", "");
            Pokemon melodelfe = new Pokemon("melodelfe", 95, 70, "fee", "acier", "gel");
            Pokemon germignon = new Pokemon("germignon", 45, 49, "plante", "insecte", "");
            Pokemon macronium = new Pokemon("macronium", 60, 62, "plante", "insecte", "");
            Pokemon meganium = new Pokemon("meganium", 80, 82, "plante", "insecte", "");
            Pokemon minidraco = new Pokemon("minidraco", 41, 64, "dragon", "dragon", "");
            Pokemon draco = new Pokemon("draco", 61, 84, "dragon", "dragon", "");
            Pokemon dracolosse = new Pokemon("dracolosse", 91, 134, "dragon", "dragon", "");
            Pokemon ptitard = new Pokemon("ptitard", 40, 50, "eau", "electrik", "");
            Pokemon tetarte = new Pokemon("tetarte", 65, 65, "eau", "electrik", "sommeil");
            Pokemon tartard = new Pokemon("tartard", 90, 95, "eau", "electrik", "sommeil");
            Pokemon abra = new Pokemon("abra", 25, 20, "psy", "tenebres", "");
            Pokemon kadabra = new Pokemon("kadabra", 40, 35, "psy", "insecte", "empoisonnement");
            Pokemon alakazam = new Pokemon("alakazam", 55, 50, "psy", "tenebres", "paralysie");
            Pokemon machoc = new Pokemon("machoc", 70, 80, "combat", "psy", "gel");
            Pokemon machopeur = new Pokemon("machopeur", 80, 100, "combat", "fee", "paralysie");
            Pokemon mackogneur = new Pokemon("mackogneur", 90, 130, "combat", "psy", "");
            Pokemon racaillou = new Pokemon("racaillou", 40, 80, "roche", "plante", "");
            Pokemon gravalanch = new Pokemon("gravalanch", 55, 95, "roche", "plante", "");
            Pokemon grolem = new Pokemon("grolem", 80, 120, "roche", "plante", "");
            Pokemon chetiflor = new Pokemon("chetiflor", 50, 75, "plante", "feu", "");
            Pokemon boustiflor = new Pokemon("boustiflor", 65, 90, "plante", "feu", "");
            Pokemon empiflor = new Pokemon("empiflor", 80, 105, "plante", "feu", "");
            Pokemon hypotrempe = new Pokemon("hypotrempe", 30, 40, "eau", "dragon OUUU feu", "");
            Pokemon hypocean = new Pokemon("hypocean", 55, 65, "eau", "dragon OUUU feu", "");
            Pokemon hyporoi = new Pokemon("hyporoi", 75, 95, "eau", "dragon OUUU feu", "");
            Pokemon porygon = new Pokemon("porygon", 65, 60, "normal", "combat", "");
            Pokemon porygon2 = new Pokemon("porygon", 85, 80, "normal", "combat", "");
            Pokemon porygonZ = new Pokemon("porygon", 85, 85, "normal", "combat", "");
            Pokemon hericendre = new Pokemon("hericendre", 39, 52, "feu", "sol", "");
            Pokemon feurisson = new Pokemon("hericendre", 58, 64, "feu", "sol", "");
            Pokemon typhlosion = new Pokemon("hericendre", 78, 84, "feu", "sol", "");
            Pokemon kaiminus = new Pokemon("kaiminus", 50, 65, "feu", "electrik", "");
            Pokemon crocrodil = new Pokemon("crocrodil", 65, 80, "feu", "electrik", "");
            Pokemon aligatueur = new Pokemon("aligatueur", 85, 105, "feu", "electrik", "");
            Pokemon nosferapti = new Pokemon("nosferapti", 40, 45, "poison", "psy", "");
            Pokemon nosferalto = new Pokemon("nosferalto", 75, 80, "poison", "psy", "");
            Pokemon nostenfer = new Pokemon("nostenfer", 85, 90, "poison", "psy", "");
            Pokemon toudoudou = new Pokemon("toudoudou", 90, 30, "fee", "acier OU poison", "");
            Pokemon rondoudou = new Pokemon("rondoudou", 115, 45, "fee", "acier OU poison", "");
            Pokemon grodoudou = new Pokemon("grodoudou", 140, 70, "fee", "acier OU poison", "");





            ListePokemon = new List<Pokemon> { bulbizarre, salameche, reptincel, dracaufeu, carapuce, carabaffe, chenipan, chrysacier, rattatta, rattattac, abo, arbok, pikachu, raichu, sabelette, sablaireau, nidorina, nidoranm, nidorino, melo, melodelfe, goupix, goupixAlola, feunard, taupiqueur, triopikeur, persian, perisanAlola, psykokwak, ferosinge, colossinge, caninos, arcanin, ptitard, tetarte , abra , kadabra , alakazam , machoc , machopeur , mackogneur , voltorbe , saquedeneu , scarabrute , voltali , ronflex , mewtwo, mew, macronium };
            NbPokemonDispo = ListePokemon.Count;
        }
        

        /// <summary>
        /// Supprimer le Pokémon de la liste lorsqu'il a été attribué à une équipe 
        /// </summary>
        /// <param name="pokemon"></param>
        public void SupprimerPokemon(Pokemon pokemon)
        {
            ListePokemon.Remove(pokemon);
            NbPokemonDispo = NbPokemonDispo - 1;
        }


    }
}
