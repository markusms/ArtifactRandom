using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtifactRandom
{
    /// <summary>
    /// Class that contains all the cards in the game.
    /// </summary>
    public class Cards
    {
        public List<int> redHeroes = new List<int>();
        public List<int> greenHeroes = new List<int>();
        public List<int> blueHeroes = new List<int>();
        public List<int> blackHeroes = new List<int>();
        public List<int> redCards = new List<int>();
        public List<int> greenCards = new List<int>();
        public List<int> blueCards = new List<int>();
        public List<int> blackCards = new List<int>();
        public List<int> items = new List<int>();

        public Cards()
        {
            AddRedHeroes();
            AddGreenHeroes();
            AddBlueHeroes();
            AddBlackHeroes();
            AddRedCards();
            AddGreenCards();
            AddBlueCards();
            AddBlackCards();
            AddItems();
        }

        private void AddRedHeroes()
        {
            int Keefe = 4003;
            int Axe = 10020;
            int Centaur = 10021;
            int Timbersaw = 10022;
            int Tidehunter = 10024;
            int Beastmaster = 10029;
            int Bristleback = 10030;
            int Pugna = 10048;
            int Mazzie = 10052;
            int Sven = 10054;
            int Legion = 10069;
            int Ursa = 10070;

            redHeroes.Add(Keefe);
            redHeroes.Add(Axe);
            redHeroes.Add(Centaur);
            redHeroes.Add(Timbersaw);
            redHeroes.Add(Tidehunter);
            redHeroes.Add(Beastmaster);
            redHeroes.Add(Bristleback);
            redHeroes.Add(Pugna);
            redHeroes.Add(Mazzie);
            redHeroes.Add(Sven);
            redHeroes.Add(Legion);
            redHeroes.Add(Ursa);
        }

        private void AddGreenHeroes()
        {
            int Fahrvhan = 4000;
            int Lycan = 10014;
            int Abaddon = 10016;
            int Chen = 10017;
            int Rix = 10026;
            int Viper = 10028;
            int Drow = 10032;
            int Enchantress = 10036;
            int Omniknight = 10044;
            int Treant = 10056;
            int Magnus = 10067;
            int Dark = 10068;
            
            greenHeroes.Add(Fahrvhan);
            greenHeroes.Add(Lycan);
            greenHeroes.Add(Abaddon);
            greenHeroes.Add(Chen);
            greenHeroes.Add(Rix);
            greenHeroes.Add(Viper);
            greenHeroes.Add(Drow);
            greenHeroes.Add(Enchantress);
            greenHeroes.Add(Omniknight);
            greenHeroes.Add(Treant);
            greenHeroes.Add(Magnus);
            greenHeroes.Add(Dark);
        }

        private void AddBlueHeroes()
        {
            int JMuy = 4008;
            int Venomancer = 10001;
            int Meepo = 10004;
            int Luna = 10006;
            int Kanna = 10031;
            int Earthshaker = 10033;
            int Ogre = 10043;
            int Outworld = 10046;
            int Prellex = 10053;
            int Skywrath = 10062;
            int Crystal = 10064;
            int Zeus = 10065;

            blueHeroes.Add(JMuy);
            blueHeroes.Add(Venomancer);
            blueHeroes.Add(Meepo);
            blueHeroes.Add(Luna);
            blueHeroes.Add(Kanna);
            blueHeroes.Add(Earthshaker);
            blueHeroes.Add(Ogre);
            blueHeroes.Add(Outworld);
            blueHeroes.Add(Prellex);
            blueHeroes.Add(Skywrath);
            blueHeroes.Add(Crystal);
            blueHeroes.Add(Zeus);
        }

        private void AddBlackHeroes()
        {
            int Debbi = 4005;
            int Wyvern = 10010;
            int Bloodseeker = 10018;
            int Bounty = 10023;
            int Tinker = 10025;
            int Lich = 10038;
            int Phantom = 10047;
            int Sniper = 10050;
            int Sorla = 10058;
            int Necrophos = 10059;
            int Lion = 10060;
            int Storm = 10536;

            blackHeroes.Add(Debbi);
            blackHeroes.Add(Wyvern);
            blackHeroes.Add(Bloodseeker);
            blackHeroes.Add(Bounty);
            blackHeroes.Add(Tinker);
            blackHeroes.Add(Lich);
            blackHeroes.Add(Phantom);
            blackHeroes.Add(Sniper);
            blackHeroes.Add(Sorla);
            blackHeroes.Add(Necrophos);
            blackHeroes.Add(Lion);
            blackHeroes.Add(Storm);
        }

        private void AddRedCards()
        {
            redCards.Add(10076);
            redCards.Add(10084);
            redCards.Add(10087);
            redCards.Add(10094);
            redCards.Add(10095);
            redCards.Add(10097);
            redCards.Add(10103);
            redCards.Add(10104);
            redCards.Add(10114);
            redCards.Add(10118);
            redCards.Add(10127);
            redCards.Add(10131);
            redCards.Add(10132);
            redCards.Add(10153);
            redCards.Add(10172);
            redCards.Add(10174);
            redCards.Add(10178);
            redCards.Add(10183);
            redCards.Add(10191);
            redCards.Add(10297);
            redCards.Add(10300);
            redCards.Add(10305);
            redCards.Add(10306);
            redCards.Add(10313);
            redCards.Add(10316);
            redCards.Add(10326);
            redCards.Add(10327);
            redCards.Add(10342);
            redCards.Add(10344);
            redCards.Add(10349);
            redCards.Add(10350);
            redCards.Add(10366);
            redCards.Add(10367);
            redCards.Add(10370);
            redCards.Add(10385);
            redCards.Add(10417);
            redCards.Add(10421);
            redCards.Add(10425);
        }

        private void AddGreenCards()
        {
            greenCards.Add(10079);
            greenCards.Add(10080);
            greenCards.Add(10091);
            greenCards.Add(10096);
            greenCards.Add(10102);
            greenCards.Add(10107);
            greenCards.Add(10108);
            greenCards.Add(10111);
            greenCards.Add(10113);
            greenCards.Add(10119);
            greenCards.Add(10133);
            greenCards.Add(10134);
            greenCards.Add(10149);
            greenCards.Add(10152);
            greenCards.Add(10155);
            greenCards.Add(10168);
            greenCards.Add(10169);
            greenCards.Add(10170);
            greenCards.Add(10181);
            greenCards.Add(10192);
            greenCards.Add(10142);
            greenCards.Add(10299);
            greenCards.Add(10303);
            greenCards.Add(10311);
            greenCards.Add(10317);
            greenCards.Add(10324);
            greenCards.Add(10334);
            greenCards.Add(10338);
            greenCards.Add(10347);
            greenCards.Add(10358);
            greenCards.Add(10365);
            greenCards.Add(10368);
            greenCards.Add(10373);
            greenCards.Add(10378);
            greenCards.Add(10379);
            greenCards.Add(10382);
            greenCards.Add(10396);
            greenCards.Add(10403);
        }

        private void AddBlueCards()
        {
            blueCards.Add(10090);
            blueCards.Add(10106);
            blueCards.Add(10137);
            blueCards.Add(10138);
            blueCards.Add(10148);
            blueCards.Add(10151);
            blueCards.Add(10157);
            blueCards.Add(10171);
            blueCards.Add(10175);
            blueCards.Add(10180);
            blueCards.Add(10187);
            blueCards.Add(10194);
            blueCards.Add(10196);
            blueCards.Add(10198);
            blueCards.Add(10298);
            blueCards.Add(10302);
            blueCards.Add(10307);
            blueCards.Add(10312);
            blueCards.Add(10315);
            blueCards.Add(10319);
            blueCards.Add(10331);
            blueCards.Add(10335);
            blueCards.Add(10336);
            blueCards.Add(10352);
            blueCards.Add(10353);
            blueCards.Add(10355);
            blueCards.Add(10359);
            blueCards.Add(10360);
            blueCards.Add(10374);
            blueCards.Add(10376);
            blueCards.Add(10377);
            blueCards.Add(10391);
            blueCards.Add(10402);
            blueCards.Add(10411);
            blueCards.Add(10412);
            blueCards.Add(10418);
            blueCards.Add(10422);
            blueCards.Add(10424);
        }

        private void AddBlackCards()
        {
            blackCards.Add(10077);
            blackCards.Add(10078);
            blackCards.Add(10083);
            blackCards.Add(10085);
            blackCards.Add(10086);
            blackCards.Add(10092);
            blackCards.Add(10115);
            blackCards.Add(10116);
            blackCards.Add(10128);
            blackCards.Add(10129);
            blackCards.Add(10141);
            blackCards.Add(10150);
            blackCards.Add(10154);
            blackCards.Add(10156);
            blackCards.Add(10161);
            blackCards.Add(10162);
            blackCards.Add(10164);
            blackCards.Add(10165);
            blackCards.Add(10176);
            blackCards.Add(10182);
            blackCards.Add(10184);
            blackCards.Add(10185);
            blackCards.Add(10268);
            blackCards.Add(10270);
            blackCards.Add(10273);
            blackCards.Add(10295);
            blackCards.Add(10310);
            blackCards.Add(10314);
            blackCards.Add(10322);
            blackCards.Add(10328);
            blackCards.Add(10332);
            blackCards.Add(10354);
            blackCards.Add(10361);
            blackCards.Add(10399);
            blackCards.Add(10404);
            blackCards.Add(10410);
            blackCards.Add(10413);
            blackCards.Add(10415);
        }

        private void AddItems()
        {
            items.Add(3002);
            items.Add(3001);
            items.Add(3000);
            items.Add(10202);
            items.Add(10203);
            items.Add(10205);
            items.Add(10206);
            items.Add(10207);
            items.Add(10208);
            items.Add(10210);
            items.Add(10211);
            items.Add(10212);
            items.Add(10213);
            items.Add(10214);
            items.Add(10215);
            items.Add(10216);
            items.Add(10217);
            items.Add(10218);
            items.Add(10220);
            items.Add(10222);
            items.Add(10223);
            items.Add(10224);
            items.Add(10225);
            items.Add(10226);
            items.Add(10230);
            items.Add(10231);
            items.Add(10232);
            items.Add(10234);
            items.Add(10235);
            items.Add(10236);
            items.Add(10237);
            items.Add(10238);
            items.Add(10241);
            items.Add(10242);
            items.Add(10243);
            items.Add(10248);
            items.Add(10252);
            items.Add(10253);
            items.Add(10255);
            items.Add(10256);
            items.Add(10259);
            items.Add(10260);
            items.Add(10262);
            items.Add(10263);
        }
    }
}
