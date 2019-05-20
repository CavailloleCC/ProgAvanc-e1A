using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedojo
{
    class BaseDeDonnees
    {
        public List<List<Pokemon>> ListeBddPokemon{ get; set; } //Liste de listes des Pokémons avec leurs évolutions 

        public int NbPokemonDispo { get; set; }

        /// <summary>
        /// Constructeur de la classe BaseDeDonnees :
        /// Construction d'une liste de liste de Pokémons, constituée de 48 Pokémons (et de leur 2 évolutions)
        /// NbPokemonDispo est donc initialisé à 48 (longueur de la liste)
        /// </summary>
        public BaseDeDonnees()
        {
            ListeBddPokemon = new List<List<Pokemon>>();

            Pokemon bulbizarre = new Pokemon("bulbizarre", 45, 49, "plante", "feu");
            Pokemon herbizarre = new Pokemon("herbizarre", 60, 62, "plante", "feu");
            Pokemon florizarre = new Pokemon("florizarre", 80, 82, "plante", "feu");
            ListeBddPokemon.Add(new List<Pokemon> { bulbizarre, herbizarre, florizarre });

            Pokemon salameche = new Pokemon("salameche", 39, 52, "feu", "eau", "brulure");
            Pokemon reptincel = new Pokemon("reptincel", 58, 64, "feu", "eau", "brulure");
            Pokemon dracaufeu = new Pokemon("dracaufeu", 78, 84, "feu", "roche", "brulure");
            ListeBddPokemon.Add(new List<Pokemon> { salameche, reptincel, dracaufeu });

            Pokemon carapuce = new Pokemon("carapuce", 44, 48, "eau", "electrik");
            Pokemon carabaffe = new Pokemon("carabaffe", 59, 63, "eau", "electrik");
            Pokemon tortank = new Pokemon("tortank", 79, 83, "eau", "electrik");
            ListeBddPokemon.Add(new List<Pokemon> { carapuce, carabaffe, tortank });

            Pokemon chenipan = new Pokemon("chenipan", 45, 30, "insecte", "feu", "gel");
            Pokemon chrysacier = new Pokemon("chrysacier", 50, 20, "insecte", "feu", "gel");
            Pokemon papilusion = new Pokemon("papilusion", 60, 45, "insecte", "feu", "gel");
            ListeBddPokemon.Add(new List<Pokemon> { chenipan, chrysacier, papilusion });

            Pokemon nidoranf = new Pokemon("nidoranf", 55, 47, "poison", "sol");
            Pokemon nidorina = new Pokemon("nidorina", 70, 62, "poison", "sol", "brulure");
            Pokemon nidoqueen = new Pokemon("nidorina", 90, 92, "poison", "sol", "brulure");
            ListeBddPokemon.Add(new List<Pokemon> { nidoranf, nidorina, nidoqueen });

            Pokemon aspicot = new Pokemon("aspicot", 40, 35, "insecte", "feu");
            Pokemon coconfort = new Pokemon("coconfort", 45, 25, "insecte", "feu");
            Pokemon dardargnan = new Pokemon("dardargnan", 65, 90, "insecte", "feu");
            ListeBddPokemon.Add(new List<Pokemon> { aspicot, coconfort, dardargnan });

            Pokemon pikachu = new Pokemon("pikachu", 35, 55, "electrik", "sol", "brulure");
            Pokemon raichuAlola = new Pokemon("raichuAlola", 60, 85, "electrik", "sol", "gel");
            Pokemon raichu = new Pokemon("raichu", 60, 90, "electrik", "sol", "gel");
            ListeBddPokemon.Add(new List<Pokemon> { pikachu, raichuAlola, raichu });

            Pokemon nidoranm = new Pokemon("nidoranm", 46, 57, "poison", "sol", "brulure");
            Pokemon nidorino = new Pokemon("nidorino", 61, 72, "poison", "sol", "brulure");
            Pokemon nidoking = new Pokemon("nidoking", 81, 102, "poison", "sol", "brulure");
            ListeBddPokemon.Add(new List<Pokemon> { nidoranm, nidorino, nidoking });

            Pokemon melo = new Pokemon("melo", 50, 25, "fee", "acier", "gel");
            Pokemon melofee = new Pokemon("melofee", 70, 45, "fee", "acier", "gel");
            Pokemon melodelfe = new Pokemon("melodelfe", 95, 70, "fee", "acier", "gel");
            ListeBddPokemon.Add(new List<Pokemon> { melo, melofee, melodelfe });

            Pokemon germignon = new Pokemon("germignon", 45, 49, "plante", "insecte");
            Pokemon macronium = new Pokemon("macronium", 60, 62, "plante", "insecte");
            Pokemon meganium = new Pokemon("meganium", 80, 82, "plante", "insecte");
            ListeBddPokemon.Add(new List<Pokemon> { germignon, macronium, meganium });

            Pokemon minidraco = new Pokemon("minidraco", 41, 64, "dragon", "dragon");
            Pokemon draco = new Pokemon("draco", 61, 84, "dragon", "dragon");
            Pokemon dracolosse = new Pokemon("dracolosse", 91, 134, "dragon", "dragon");
            ListeBddPokemon.Add(new List<Pokemon> { minidraco, draco, dracolosse });

            Pokemon ptitard = new Pokemon("ptitard", 40, 50, "eau", "electrik");
            Pokemon tetarte = new Pokemon("tetarte", 65, 65, "eau", "electrik");
            Pokemon tartard = new Pokemon("tartard", 90, 95, "eau", "electrik", "gel");
            ListeBddPokemon.Add(new List<Pokemon> { ptitard, tetarte, tartard });

            Pokemon sorbebe = new Pokemon("sorbebe", 36, 50, "glace", "roche");
            Pokemon sorboul = new Pokemon("sorboul", 51, 65, "glace", "roche");
            Pokemon sorbouboul = new Pokemon("sorbouboul", 71, 95, "glace", "roche");
            ListeBddPokemon.Add(new List<Pokemon> { sorbebe, sorboul, sorbouboul });

            Pokemon machoc = new Pokemon("machoc", 70, 80, "combat", "psy");
            Pokemon machopeur = new Pokemon("machopeur", 80, 100, "combat", "fee");
            Pokemon mackogneur = new Pokemon("mackogneur", 90, 130, "combat", "psy");
            ListeBddPokemon.Add(new List<Pokemon> { machoc, machopeur, mackogneur });

            Pokemon racaillou = new Pokemon("racaillou", 40, 80, "roche", "plante");
            Pokemon gravalanch = new Pokemon("gravalanch", 55, 95, "roche", "plante");
            Pokemon grolem = new Pokemon("grolem", 80, 120, "roche", "plante");
            ListeBddPokemon.Add(new List<Pokemon> { racaillou, gravalanch, grolem });

            Pokemon chetiflor = new Pokemon("chetiflor", 50, 75, "plante", "feu", "gel");
            Pokemon boustiflor = new Pokemon("boustiflor", 65, 90, "plante", "feu", "gel");
            Pokemon empiflor = new Pokemon("empiflor", 80, 105, "plante", "feu", "gel");
            ListeBddPokemon.Add(new List<Pokemon> { chetiflor, boustiflor, empiflor });

            Pokemon hypotrempe = new Pokemon("hypotrempe", 30, 40, "eau", "dragon", "gel");
            Pokemon hypocean = new Pokemon("hypocean", 55, 65, "eau", "feu", "gel");
            Pokemon hyporoi = new Pokemon("hyporoi", 75, 95, "eau", "feu", "gel");
            ListeBddPokemon.Add(new List<Pokemon> { hypotrempe, hypocean, hyporoi });

            Pokemon porygon = new Pokemon("porygon", 65, 60, "normal", "combat");
            Pokemon porygon2 = new Pokemon("porygon2", 85, 80, "normal", "combat");
            Pokemon porygonZ = new Pokemon("porygonZ", 85, 85, "normal", "combat");
            ListeBddPokemon.Add(new List<Pokemon> { porygon, porygon2, porygonZ });

            Pokemon hericendre = new Pokemon("hericendre", 39, 52, "feu", "sol");
            Pokemon feurisson = new Pokemon("feurisson", 58, 64, "feu", "sol", "brulure");
            Pokemon typhlosion = new Pokemon("typhlosion", 78, 84, "feu", "sol", "brulure");
            ListeBddPokemon.Add(new List<Pokemon> { hericendre, feurisson, typhlosion });

            Pokemon kaiminus = new Pokemon("kaiminus", 50, 65, "feu", "electrik");
            Pokemon crocodil = new Pokemon("crocodil", 65, 80, "feu", "electrik");
            Pokemon aligatueur = new Pokemon("aligatueur", 85, 105, "feu", "electrik", "brulure");
            ListeBddPokemon.Add(new List<Pokemon> { kaiminus, crocodil, aligatueur });

            Pokemon nosferapti = new Pokemon("nosferapti", 40, 45, "poison", "psy");
            Pokemon nosferalto = new Pokemon("nosferalto", 75, 80, "poison", "psy");
            Pokemon nostenfer = new Pokemon("nostenfer", 85, 90, "poison", "psy", "gel");
            ListeBddPokemon.Add(new List<Pokemon> { nosferapti, nosferalto, nostenfer });

            Pokemon toudoudou = new Pokemon("toudoudou", 90, 30, "fee", "poison");
            Pokemon rondoudou = new Pokemon("rondoudou", 115, 45, "fee", "poison", "gel");
            Pokemon grodoudou = new Pokemon("grodoudou", 140, 70, "fee", "poison", "gel");
            ListeBddPokemon.Add(new List<Pokemon> { toudoudou, rondoudou, grodoudou });

            Pokemon wattouat = new Pokemon("wattouat", 55, 40, "electrik", "sol");
            Pokemon lainergie = new Pokemon("lainergie", 70, 55, "electrik", "sol");
            Pokemon pharamp = new Pokemon("pharamp", 90, 75, "electrik", "sol", "brulure");
            ListeBddPokemon.Add(new List<Pokemon> { wattouat, lainergie, pharamp });

            Pokemon mystherbe = new Pokemon("mystherbe", 45, 50, "plante", "feu");
            Pokemon ortide = new Pokemon("ortide", 60, 65, "plante", "feu");
            Pokemon rafflesia = new Pokemon("rafflesia", 75, 80, "plante", "feu");
            ListeBddPokemon.Add(new List<Pokemon> { mystherbe, ortide, rafflesia });

            Pokemon azurill = new Pokemon("azurill", 75, 80, "eau", "electik");
            Pokemon marill = new Pokemon("marill", 70, 20, "eau", "electik");
            Pokemon azumarill = new Pokemon("azumarill", 100, 50, "eau", "electik", "gel");
            ListeBddPokemon.Add(new List<Pokemon> { azurill, marill, azumarill });

            Pokemon granivol = new Pokemon("granivol", 35, 35, "plante", "glace");
            Pokemon floravol = new Pokemon("floravol", 55, 45, "plante", "glace");
            Pokemon cotovol = new Pokemon("cotovol", 75, 55, "plante", "glace");
            ListeBddPokemon.Add(new List<Pokemon> { granivol, floravol, cotovol });

            Pokemon magby = new Pokemon("magby", 45, 75, "feu", "sol", "brulure");
            Pokemon magmar = new Pokemon("magmar", 65, 95, "feu", "sol", "brulure");
            Pokemon maganon = new Pokemon("maganon", 75, 95, "feu", "sol", "brulure");
            ListeBddPokemon.Add(new List<Pokemon> { magby, magmar, maganon });

            Pokemon poussifeu = new Pokemon("poussifeu", 45, 60, "feu", "sol", "brulure");
            Pokemon galifeu = new Pokemon("galifeu", 60, 85, "feu", "sol", "brulure");
            Pokemon brasegali = new Pokemon("brasegali", 80, 120, "feu", "sol", "brulure");
            ListeBddPokemon.Add(new List<Pokemon> { poussifeu, galifeu, brasegali });

            Pokemon arcko = new Pokemon("arcko", 45, 55, "plante", "insecte");
            Pokemon massko = new Pokemon("massko", 50, 65, "plante", "insecte");
            Pokemon jungko = new Pokemon("jungko", 70, 85, "plante", "insecte");
            ListeBddPokemon.Add(new List<Pokemon> { arcko, massko, jungko });

            Pokemon bebecaille = new Pokemon("bebecaille", 60, 50, "combat", "dragon");
            Pokemon ecaid = new Pokemon("ecaid", 55, 75, "combat", "dragon");
            Pokemon ekaiser = new Pokemon("ekaiser", 75, 110, "combat", "dragon");
            ListeBddPokemon.Add(new List<Pokemon> { bebecaille, ecaid, ekaiser });

            Pokemon gobou = new Pokemon("gobou", 50, 70, "eau", "plante");
            Pokemon flobio = new Pokemon("flobio", 70, 85, "eau", "plante");
            Pokemon laggron = new Pokemon("laggron", 100, 110, "eau", "plante", "gel");
            ListeBddPokemon.Add(new List<Pokemon> { gobou, flobio, laggron });

            Pokemon chenipotte = new Pokemon("chenipotte", 45, 45, "insecte", "feu");
            Pokemon armulys = new Pokemon("armulys", 50, 35, "insecte", "feu");
            Pokemon charmillon = new Pokemon("charmillon", 60, 70, "insecte", "feu");
            ListeBddPokemon.Add(new List<Pokemon> { chenipotte, armulys, charmillon });

            Pokemon grainipiot = new Pokemon("grainipiot", 40, 40, "plante", "insecte");
            Pokemon pifeuil = new Pokemon("pifeuil", 70, 70, "plante", "insecte");
            Pokemon tengalice = new Pokemon("tengalice", 90, 100, "plante", "insecte");
            ListeBddPokemon.Add(new List<Pokemon> { grainipiot, pifeuil, tengalice });

            Pokemon tarsal = new Pokemon("tarsal", 28, 25, "psy", "poison");
            Pokemon kirlia = new Pokemon("kirlia", 38, 35, "psy", "poison", "gel");
            Pokemon gardevoir = new Pokemon("gardevoir", 68, 65, "psy", "poison", "gel");
            ListeBddPokemon.Add(new List<Pokemon> { tarsal, kirlia, gardevoir });

            Pokemon parecool = new Pokemon("parecool", 60, 60, "normal", "combat");
            Pokemon vigoroth = new Pokemon("vigoroth", 80, 80, "normal", "combat");
            Pokemon monaflemit = new Pokemon("monaflemit", 150, 160, "normal", "combat");
            ListeBddPokemon.Add(new List<Pokemon> { parecool, vigoroth, monaflemit });

            Pokemon kraknoix = new Pokemon("kraknoix", 45, 100, "sol", "glace");
            Pokemon vibraninf = new Pokemon("vibraninf", 50, 70, "sol", "glace");
            Pokemon libegon = new Pokemon("libegon", 80, 100, "sol", "glace", "gel");
            ListeBddPokemon.Add(new List<Pokemon> { kraknoix, vibraninf, libegon });

            Pokemon draby = new Pokemon("draby", 45, 75, "dragon", "fee");
            Pokemon drackhaus = new Pokemon("drackhaus", 65, 95, "dragon", "fee");
            Pokemon drattak = new Pokemon("drattak", 95, 135, "dragon", "fee");
            ListeBddPokemon.Add(new List<Pokemon> { draby, drackhaus, drattak });

            Pokemon terhal = new Pokemon("terhal", 40, 55, "acier", "feu", "brulure");
            Pokemon metang = new Pokemon("metang", 60, 75, "acier", "feu", "brulure");
            Pokemon metalosse = new Pokemon("metalosse", 80, 135, "acier", "feu", "brulure");
            ListeBddPokemon.Add(new List<Pokemon> { terhal, metang, metalosse });

            Pokemon tortipouss = new Pokemon("tortipouss", 55, 68, "plante", "insecte");
            Pokemon boskara = new Pokemon("boskara", 75, 89, "plante", "insecte");
            Pokemon torterra = new Pokemon("torterra", 95, 109, "plante", "glace");
            ListeBddPokemon.Add(new List<Pokemon> { tortipouss, boskara, torterra });

            Pokemon obalie = new Pokemon("obalie", 70, 40, "glace", "plante", "gel");
            Pokemon phogleur = new Pokemon("phogleur", 90, 60, "glace", "plante", "gel");
            Pokemon kaimorse = new Pokemon("kaimorse", 110, 80, "glace", "plante", "gel");
            ListeBddPokemon.Add(new List<Pokemon> { obalie, phogleur, kaimorse });

            Pokemon griknot = new Pokemon("griknot", 58, 70, "dragon", "glace");
            Pokemon carmache = new Pokemon("carmache", 68, 90, "dragon", "glace");
            Pokemon carchacrok = new Pokemon("carchacrok", 108, 130, "dragon", "glace", "brulure");
            ListeBddPokemon.Add(new List<Pokemon> { griknot, carmache, carchacrok });

            Pokemon chuchmur = new Pokemon("chuchmur", 64, 51, "normal", "combat");
            Pokemon ramboum = new Pokemon("ramboum", 84, 71, "normal", "combat");
            Pokemon brouhabam = new Pokemon("brouhabam", 104, 91, "normal", "combat");
            ListeBddPokemon.Add(new List<Pokemon> { chuchmur, ramboum, brouhabam });

            Pokemon galekid = new Pokemon("galekid", 50, 70, "acier", "combat");
            Pokemon galegon = new Pokemon("galegon", 60, 90, "acier", "combat");
            Pokemon galeking = new Pokemon("galeking", 70, 110, "acier", "combat");
            ListeBddPokemon.Add(new List<Pokemon> { galekid, galegon, galeking });

            Pokemon etourmi = new Pokemon("etourmi", 40, 55, "normal", "electrik");
            Pokemon etourvol = new Pokemon("etourvol", 55, 75, "normal", "electrik");
            Pokemon etouraptor = new Pokemon("etouraptor", 85, 120, "normal", "electrik");
            ListeBddPokemon.Add(new List<Pokemon> { etourmi, etourvol, etouraptor });

            Pokemon lixy = new Pokemon("lixy", 45, 65, "electrik", "sol", "brulure");
            Pokemon luxio = new Pokemon("luxio", 60, 85, "electrik", "sol", "brulure");
            Pokemon luxray = new Pokemon("luxray", 80, 120, "electrik", "sol", "brulure");
            ListeBddPokemon.Add(new List<Pokemon> { lixy, luxio, luxray });

            Pokemon ptiravi = new Pokemon("ptiravi", 100, 5, "normal", "combat");
            Pokemon leveinard = new Pokemon("leveinard", 250, 5, "normal", "combat");
            Pokemon leuphorie = new Pokemon("leuphorie", 255, 10, "normal", "combat");
            ListeBddPokemon.Add(new List<Pokemon> { ptiravi, leveinard, leuphorie });

            Pokemon mascaiman = new Pokemon("mascaiman", 50, 72, "sol", "eau");
            Pokemon escroco = new Pokemon("escroco", 60, 82, "sol", "eau");
            Pokemon crocorible = new Pokemon("crocorible", 95, 117, "sol", "eau");
            ListeBddPokemon.Add(new List<Pokemon> { mascaiman, escroco, crocorible });


            Pokemon marcacrin = new Pokemon("marcacrin", 50, 50, "sol", "acier");
            Pokemon cochignon = new Pokemon("cochignon", 100, 100, "sol", "acier");
            Pokemon mammochon = new Pokemon("mammochon", 110, 130, "sol", "acier");
            ListeBddPokemon.Add(new List<Pokemon> { marcacrin, cochignon, mammochon });


            NbPokemonDispo = ListeBddPokemon.Count;
        }
        

        /// <summary>
        /// Suppression d'un Pokémon (et de ses évolutions) de la liste de la base de données :
        /// Sera utilisé pour supprimer un Pokémon une fois celui-ci attribué à une équipe
        /// </summary>
        /// <param name="pokemon"></param>
        public void SupprimerPokemon(List<Pokemon> ListePokemon)
        {
            ListeBddPokemon.Remove(ListePokemon);
            NbPokemonDispo = NbPokemonDispo - 1;
        }


    }
}
