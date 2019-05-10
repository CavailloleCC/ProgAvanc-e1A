using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedojo
{
    class BaseDeDonnees
    {
        public List<Pokemon> ListePokemonEvolue0 { get; set; }
        public List<Pokemon> ListePokemonEvolue1 { get; set; }
        public List<Pokemon> ListePokemonEvolue2 { get; set; }

        public int NbPokemonDispo { get; set; }

        public BaseDeDonnees()
        {
            Pokemon bulbizarre = new Pokemon("bulbizarre", 45, 49, "plante", "feu", "");
            Pokemon herbizarre = new Pokemon("herbizarre", 60, 62, "plante", "feu", "");
            Pokemon florizarre = new Pokemon("florizarre", 80, 82, "plante", "feu", "");

            Pokemon salameche = new Pokemon("salameche", 39, 52, "feu", "eau", "brulure");
            Pokemon reptincel = new Pokemon("reptincel", 58, 64, "feu", "eau", "brulure");
            Pokemon dracaufeu = new Pokemon("dracaufeu", 78, 84, "feu", "roche", "brulure");

            Pokemon carapuce = new Pokemon("carapuce", 44, 48, "eau", "electrik", "");
            Pokemon carabaffe = new Pokemon("carabaffe", 59, 63, "eau", "electrik", "");
            Pokemon tortank = new Pokemon("tortank", 79, 83, "eau", "electrik", "");

            Pokemon chenipan = new Pokemon("chenipan", 45, 30, "insecte", "feu", "gel");
            Pokemon chrysacier = new Pokemon("chrysacier", 50, 20, "insecte", "feu", "gel");
            Pokemon papilusion = new Pokemon("papilusion", 60, 45, "insecte", "feu", "gel");

            Pokemon nidoranf = new Pokemon("nidoranf", 55, 47, "poison", "sol", "");
            Pokemon nidorina = new Pokemon("nidorina", 70, 62, "poison", "sol", "brulure");
            Pokemon nidoqueen = new Pokemon("nidorina", 90, 92, "poison", "sol", "brulure");

            Pokemon aspicot = new Pokemon("aspicot", 40, 35, "insecte", "feu", "");
            Pokemon coconfort = new Pokemon("coconfort", 45, 25, "insecte", "feu", "");
            Pokemon dardargnan = new Pokemon("dardargnan", 65, 90, "insecte", "feu", "");

            Pokemon pikachu = new Pokemon("pikachu", 35, 55, "electrik", "sol", "brulure");
            Pokemon raichuAlola = new Pokemon("raichuAlola", 60, 85, "electrik", "sol", "gel");
            Pokemon raichu = new Pokemon("raichu", 60, 90, "electrik", "sol", "gel");

            Pokemon nidoranm = new Pokemon("nidoranm", 46, 57, "poison", "sol", "brulure");
            Pokemon nidorino = new Pokemon("nidorino", 61, 72, "poison", "sol", "brulure");
            Pokemon nidoking = new Pokemon("nidorino", 81, 102, "poison", "sol", "brulure");

            Pokemon melo = new Pokemon("melo", 50, 25, "fee", "acier", "gel");
            Pokemon melofee = new Pokemon("melofee", 70, 45, "fee", "acier", "gel");
            Pokemon melodelfe = new Pokemon("melodelfe", 95, 70, "fee", "acier", "gel");

            Pokemon germignon = new Pokemon("germignon", 45, 49, "plante", "insecte", "");
            Pokemon macronium = new Pokemon("macronium", 60, 62, "plante", "insecte", "");
            Pokemon meganium = new Pokemon("meganium", 80, 82, "plante", "insecte", "");

            Pokemon minidraco = new Pokemon("minidraco", 41, 64, "dragon", "dragon", "");
            Pokemon draco = new Pokemon("draco", 61, 84, "dragon", "dragon", "");
            Pokemon dracolosse = new Pokemon("dracolosse", 91, 134, "dragon", "dragon", "");

            Pokemon ptitard = new Pokemon("ptitard", 40, 50, "eau", "electrik", "");
            Pokemon tetarte = new Pokemon("tetarte", 65, 65, "eau", "electrik", "");
            Pokemon tartard = new Pokemon("tartard", 90, 95, "eau", "electrik", "gel");

            Pokemon sorbebe = new Pokemon("sorbebe", 36, 50, "glace", "roche", "");
            Pokemon sorboul = new Pokemon("sorboul", 51, 65, "glace", "roche", "");
            Pokemon sorbouboul = new Pokemon("sorbouboul", 71, 95, "glace", "roche", "");

            Pokemon machoc = new Pokemon("machoc", 70, 80, "combat", "psy", "");
            Pokemon machopeur = new Pokemon("machopeur", 80, 100, "combat", "fee", "");
            Pokemon mackogneur = new Pokemon("mackogneur", 90, 130, "combat", "psy", "");

            Pokemon racaillou = new Pokemon("racaillou", 40, 80, "roche", "plante", "");
            Pokemon gravalanch = new Pokemon("gravalanch", 55, 95, "roche", "plante", "");
            Pokemon grolem = new Pokemon("grolem", 80, 120, "roche", "plante", "");

            Pokemon chetiflor = new Pokemon("chetiflor", 50, 75, "plante", "feu", "gel");
            Pokemon boustiflor = new Pokemon("boustiflor", 65, 90, "plante", "feu", "gel");
            Pokemon empiflor = new Pokemon("empiflor", 80, 105, "plante", "feu", "gel");

            Pokemon hypotrempe = new Pokemon("hypotrempe", 30, 40, "eau", "dragon", "gel");
            Pokemon hypocean = new Pokemon("hypocean", 55, 65, "eau", "feu", "gel");
            Pokemon hyporoi = new Pokemon("hyporoi", 75, 95, "eau", "feu", "gel");

            Pokemon porygon = new Pokemon("porygon", 65, 60, "normal", "combat", "");
            Pokemon porygon2 = new Pokemon("porygon", 85, 80, "normal", "combat", "");
            Pokemon porygonZ = new Pokemon("porygon", 85, 85, "normal", "combat", "");

            Pokemon hericendre = new Pokemon("hericendre", 39, 52, "feu", "sol", "");
            Pokemon feurisson = new Pokemon("hericendre", 58, 64, "feu", "sol", "brulure");
            Pokemon typhlosion = new Pokemon("hericendre", 78, 84, "feu", "sol", "brulure");

            Pokemon kaiminus = new Pokemon("kaiminus", 50, 65, "feu", "electrik", "");
            Pokemon crocodil = new Pokemon("crocrodil", 65, 80, "feu", "electrik", "");
            Pokemon aligatueur = new Pokemon("aligatueur", 85, 105, "feu", "electrik", "brulure");

            Pokemon nosferapti = new Pokemon("nosferapti", 40, 45, "poison", "psy", "");
            Pokemon nosferalto = new Pokemon("nosferalto", 75, 80, "poison", "psy", "");
            Pokemon nostenfer = new Pokemon("nostenfer", 85, 90, "poison", "psy", "gel");

            Pokemon toudoudou = new Pokemon("toudoudou", 90, 30, "fee", "poison", "");
            Pokemon rondoudou = new Pokemon("rondoudou", 115, 45, "fee", "poison", "gel");
            Pokemon grodoudou = new Pokemon("grodoudou", 140, 70, "fee", "poison", "gel");

            Pokemon wattouat = new Pokemon("wattouat", 55, 40, "electrik", "sol", "");
            Pokemon lainergie = new Pokemon("lainergie", 70, 55, "electrik", "sol", "");
            Pokemon pharamp = new Pokemon("pharamp", 90, 75, "electrik", "sol", "brulure");

            Pokemon mystherbe = new Pokemon("mystherbe", 45, 50, "plante", "feu", "");
            Pokemon ortide = new Pokemon("ortide", 60, 65, "plante", "feu", "");
            Pokemon rafflesia = new Pokemon("rafflesia", 75, 80, "plante", "feu", "");

            Pokemon azurill = new Pokemon("azurill", 75, 80, "eau", "electik", "");
            Pokemon marill = new Pokemon("marill", 70, 20, "eau", "electik", "");
            Pokemon azumarill = new Pokemon("azumarill", 100, 50, "eau", "electik", "gel");

            Pokemon granivol = new Pokemon("granivol", 35, 35, "plante", "glace", "");
            Pokemon floravol = new Pokemon("floravol", 55, 45, "plante", "glace", "");
            Pokemon cotovol = new Pokemon("cotovol", 75, 55, "plante", "glace", "");

            Pokemon magby = new Pokemon("magby", 45, 75, "feu", "sol", "brulure");
            Pokemon magmar = new Pokemon("magmar", 65, 95, "feu", "sol", "brulure");
            Pokemon maganon = new Pokemon("maganon", 75, 95, "feu", "sol", "brulure");

            Pokemon poussifeu = new Pokemon("poussifeu", 45, 60, "feu", "sol", "brulure");
            Pokemon galifeu = new Pokemon("galifeu", 60, 85, "feu", "sol", "brulure");
            Pokemon brasegali = new Pokemon("brasegali", 80, 120, "feu", "sol", "brulure");

            Pokemon arcko = new Pokemon("arcko", 45, 55, "plante", "insecte", "");
            Pokemon massko = new Pokemon("massko", 50, 65, "plante", "insecte", "");
            Pokemon jungko = new Pokemon("jungko", 70, 85, "plante", "insecte", "");

            Pokemon bebecaille = new Pokemon("bebecaille", 60, 50, "combat", "dragon", "");
            Pokemon ecaid = new Pokemon("ecaid", 55, 75, "combat", "dragon", "");
            Pokemon ekaiser = new Pokemon("ekaiser", 75, 110, "combat", "dragon", "");

            Pokemon gobou = new Pokemon("gobou", 50, 70, "eau", "plante", "");
            Pokemon flobio = new Pokemon("flobio", 70, 85, "eau", "plante", "");
            Pokemon laggron = new Pokemon("laggron", 100, 110, "eau", "plante", "gel");

            Pokemon chenipotte = new Pokemon("chenipotte", 45, 45, "insecte", "feu", "");
            Pokemon armulys = new Pokemon("armulys", 50, 35, "insecte", "feu", "");
            Pokemon charmillon = new Pokemon("charmillon", 60, 70, "insecte", "feu", "");

            Pokemon grainipiot = new Pokemon("grainipiot", 40, 40, "plante", "insecte", "");
            Pokemon pifeuil = new Pokemon("pifeuil", 70, 70, "plante", "insecte", "");
            Pokemon tengalice = new Pokemon("tengalice", 90, 100, "plante", "insecte", "");

            Pokemon tarsal = new Pokemon("tarsal", 28, 25, "psy", "poison", "");
            Pokemon kirlia = new Pokemon("kirlia", 38, 35, "psy", "poison", "gel");
            Pokemon gardevoir = new Pokemon("gardevoir", 68, 65, "psy", "poison", "gel");

            Pokemon parecool = new Pokemon("parecool", 60, 60, "normal", "combat", "");
            Pokemon vigoroth = new Pokemon("vigoroth", 80, 80, "normal", "combat", "");
            Pokemon monaflemit = new Pokemon("monaflemit", 150, 160, "normal", "combat", "");

            Pokemon kraknoix = new Pokemon("kraknoix", 45, 100, "sol", "glace", "");
            Pokemon vibraninf = new Pokemon("vibraninf", 50, 70, "sol", "glace", "");
            Pokemon libegon = new Pokemon("libegon", 80, 100, "sol", "glace", "gel");

            Pokemon draby = new Pokemon("draby", 45, 75, "dragon", "fee", "");
            Pokemon drackhaus = new Pokemon("drackhaus", 65, 95, "dragon", "fee", "");
            Pokemon drattak = new Pokemon("drattak", 95, 135, "dragon", "fee", "");

            Pokemon terhal = new Pokemon("terhal", 40, 55, "acier", "feu", "brulure");
            Pokemon metang = new Pokemon("metang", 60, 75, "acier", "feu", "brulure");
            Pokemon metalosse = new Pokemon("metalosse", 80, 135, "acier", "feu", "brulure");

            Pokemon tortipouss = new Pokemon("tortipouss", 55, 68, "plante", "insecte", "");
            Pokemon boskara = new Pokemon("boskara", 75, 89, "plante", "insecte", "");
            Pokemon torterra = new Pokemon("torterra", 95, 109, "plante", "glace", "");

            Pokemon obalie = new Pokemon("obalie", 70, 40, "glace", "plante", "gel");
            Pokemon phogleur = new Pokemon("phogleur", 90, 60, "glace", "plante", "gel");
            Pokemon kaimorse = new Pokemon("kaimorse", 110, 80, "glace", "plante", "gel");

            Pokemon griknot = new Pokemon("griknot", 58, 70, "dragon", "glace", "");
            Pokemon carmache = new Pokemon("carmache", 68, 90, "dragon", "glace", "");
            Pokemon carchacrok = new Pokemon("carchacrok", 108, 130, "dragon", "glace", "brulure");

            Pokemon chuchmur = new Pokemon("chuchmur", 64, 51, "normal", "combat", "");
            Pokemon ramboum = new Pokemon("ramboum", 84, 71, "normal", "combat", "");
            Pokemon brouhabam = new Pokemon("brouhabam", 104, 91, "normal", "combat", "");

            Pokemon galekid = new Pokemon("galekid", 50, 70, "acier", "combat", "");
            Pokemon galegon = new Pokemon("galegon", 60, 90, "acier", "combat", "");
            Pokemon galeking = new Pokemon("galeking", 70, 110, "acier", "combat", "");

            Pokemon etourmi = new Pokemon("etourmi", 40, 55, "normal", "electrik", "");
            Pokemon etourvol = new Pokemon("etourvol", 55, 75, "normal", "electrik", "");
            Pokemon etouraptor = new Pokemon("etouraptor", 85, 120, "normal", "electrik", "");

            Pokemon lixy = new Pokemon("lixy", 45, 65, "electrik", "sol", "brulure");
            Pokemon luxio = new Pokemon("luxio", 60, 85, "electrik", "sol", "brulure");
            Pokemon luxray = new Pokemon("luxray", 80, 120, "electrik", "sol", "brulure");

            Pokemon ptiravi = new Pokemon("ptiravi", 100, 5, "normal", "combat", "");
            Pokemon leveinard = new Pokemon("leveinard", 250, 5, "normal", "combat", "");
            Pokemon leuphorie = new Pokemon("leuphorie", 255, 10, "normal", "combat", "");


            ListePokemonEvolue0 = new List<Pokemon> { bulbizarre, salameche, carapuce, chenipan, nidoranf, aspicot, pikachu, nidoranm, melo, germignon, minidraco, ptitard, sorbebe, machoc, racaillou, chetiflor, hypotrempe, porygon, hericendre, kaiminus, nosferapti, toudoudou, wattouat, mystherbe, azurill, granivol, magby, poussifeu, arcko, bebecaille, gobou, chenipotte, grainipiot, tarsal, parecool, kraknoix, draby, terhal, tortipouss, obalie, griknot, chuchmur, galekid, etourmi, lixy, ptiravi };
            ListePokemonEvolue1 = new List<Pokemon> { herbizarre, reptincel, carabaffe, chrysacier, nidorina, coconfort, raichuAlola, nidorino, melofee, macronium, draco, tetarte, sorboul, machopeur, gravalanch, boustiflor, hypocean, porygon2, feurisson, crocodil, nosferalto, rondoudou, lainergie, ortide, marill, floravol, magmar, galifeu, massko, ecaid, flobio, armulys, pifeuil, kirlia, vigoroth, vibraninf, drackhaus, metang, boskara, phogleur, carmache, ramboum, galegon, etourvol, luxio, leveinard };
            ListePokemonEvolue2 = new List<Pokemon> { florizarre, dracaufeu, tortank, papilusion, nidoqueen, dardargnan, raichu, nidoking, melodelfe, meganium, dracolosse, tartard, sorbouboul, mackogneur, grolem, empiflor, hyporoi, porygonZ, typhlosion, aligatueur, nostenfer, grodoudou, pharamp, rafflesia, azumarill, cotovol, maganon, brasegali, jungko, ekaiser, laggron, charmillon, tengalice, gardevoir, monaflemit, libegon, drattak, metalosse, torterra, kaimorse, carchacrok, brouhabam, galeking, etouraptor, luxray, leuphorie };

        NbPokemonDispo = ListePokemonEvolue0.Count + ListePokemonEvolue1.Count + ListePokemonEvolue2.Count;
        }
        

        /// <summary>
        /// Supprimer le Pokémon de la liste lorsqu'il a été attribué à une équipe 
        /// </summary>
        /// <param name="pokemon"></param>
        public void SupprimerPokemon(Pokemon pokemon)
        {
            ListePokemonEvolue0.Remove(pokemon);
            NbPokemonDispo = NbPokemonDispo - 1;
        }


    }
}
