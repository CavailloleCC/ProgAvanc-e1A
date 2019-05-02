using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedojo
{
    class BaseDeDonnees
    {
        private List<Pokemon> listePokemon = new List<Pokemon>();
        //listePokemon.Add(new Pokemon("bulbizarre", 45, 49, "plante", "feu", "paralysie"));

        Pokemon bulbizarre = new Pokemon("bulbizarre", 45, 49, "plante", "feu", "paralysie");
        Pokemon salameche= new Pokemon ("salameche",39,52,"feu","eau","brulure");
        Pokemon reptincel = new Pokemon("reptincel", 58, 64 , "feu", "eau", "brulure"); 
        Pokemon dracaufeu = new Pokemon("dracaufeu", 78, 84 , "feu", "roche", "brulure"); 
        Pokemon carapuce = new Pokemon ("carapuce", 44, 48, "eau", "electrik", "sommeil" );
        Pokemon carabaffe = new Pokemon("carabaffe", 59, 63, "eau", "electrik", "");
        Pokemon chenipan = new Pokemon("chenipan", 45, 30, "feu", "eau", "brulure");
        Pokemon chrysacier = new Pokemon("chrysacier", 50, 20, "insecte", "feu", "gel");
        Pokemon rattatta = new Pokemon("rattatta", 30, 56, "normal", "combat", "");
        Pokemon rattattac = new Pokemon("rattattac", 55, 81, "normal", "combat", "");
        Pokemon abo = new Pokemon("abo", 35, 60, "poison", "sol", "empoisonnement");
        Pokemon arbok = new Pokemon("arbok",60,95,"poison", "sol", "empoisonnement");
        Pokemon pikachu = new Pokemon("pikachu", 35, 55, "electrik", "sol","gel");
        Pokemon raichu = new Pokemon("raichu", 60, 90, "electrik", "sol", "paralysie");
        Pokemon sabelette = new Pokemon("sabelette", 50, 75, "sol", "glace", "paralysie");
        Pokemon sablaireau = new Pokemon("sablaireau", 75, 100, "sol", "glace", "sommeil");
        Pokemon nidorina = new Pokemon("nidorina", 70, 62, "poison", "sol", "empoisonnement");
        Pokemon nidoranm = new Pokemon("nidoranm", 46, 57, "poison", "sol", "empoisonnement");
        Pokemon nidorino = new Pokemon("nidorino",61,72,"poison","sol","empoisonnement");
        Pokemon melo = new Pokemon("melo", 50, 25, "fee", "poison", "sommeil");
        Pokemon melodelfe = new Pokemon("melodelfe", 95, 70, "fee", "acier", "gel");
        Pokemon goupix = new Pokemon("goupix", 38, 41, "feu", "roche", "brulure");
        Pokemon goupixAlola = new Pokemon("goupixAlola", 38, 41, "glace", "combat", "gel");
        Pokemon feunard = new Pokemon("feunard", 73, 76, "feu", "sol", "brulure");
        Pokemon taupiqueur = new Pokemon("taupiqueur", 10, 55, "sol", "glace", "sommeil");
        Pokemon triopikeur = new Pokemon("triopikeur", 35, 100, "sol", "glace", "");
        Pokemon persian = new Pokemon("persian", 65, 70, "normal", "combat", "");
        Pokemon perisanAlola = new Pokemon("persianAlola", 65, 60, "tenebres", "insecte", "empoisonnement");
        Pokemon psykokwak = new Pokemon("psykokwak", 50, 52, "eau", "electrik", "paralysie");
        Pokemon ferosinge = new Pokemon("ferosinge", 40, 80, "combat", "fee", "");
        Pokemon colossinge = new Pokemon("colossinge", 65, 105, "combat", "fee", "");
        Pokemon caninos = new Pokemon("caninos", 55, 70, "feu", "roche", "brulure");
        Pokemon arcanin = new Pokemon("arcanin", 90, 110, "feu", "sol", "brulure");
        Pokemon ptitard = new Pokemon("ptitard", 40, 50, "eau", "electrik", "");
        Pokemon tetarte = new Pokemon("tetarte", 65, 65, "eau", "electrik", "sommeil");
        Pokemon abra = new Pokemon("abra", 25, 20, "psy", "tenebres", "");
        Pokemon kadabra = new Pokemon("kadabra", 40, 35, "psy", "insecte", "empoisonnement");
        Pokemon alakazam = new Pokemon("alakazam", 55, 50, "psy", "tenebres", "paralysie");
        Pokemon machoc = new Pokemon("machoc", 70, 80, "combat", "psy", "gel");
        Pokemon machopeur = new Pokemon("machopeur", 80, 100, "combat", "fee", "paralysie");
        Pokemon mackogneur = new Pokemon("mackogneur", 90, 130, "combat", "psy");
        Pokemon voltorbe = new Pokemon("voltorbe", 40, 30, "electrik", "sol", "gel");
        Pokemon saquedeneu = new Pokemon("saquedeneu", 65, 55, "plante", "insecte", "sommeil");
        Pokemon scarabrute = new Pokemon("scarabrute", 65, 125, "insecte", "feu", "");
        Pokemon voltali = new Pokemon("voltali", 65, 65, "electrik", "sol", "gel");
        Pokemon ronflex = new Pokemon("ronflex", 160, 110, "normal", "combat", "paralysie");
        Pokemon mewtwo = new Pokemon("mewtwo", 106, 110, "psy", "insecte", "paralysie");
        Pokemon mew = new Pokemon("mew", 100, 100, "psy", "insecte", "sommeil");
        Pokemon macronium = new Pokemon("macronium", 60, 62, "plante", "insecte", "");

        


    }
}
