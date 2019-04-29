using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtifactRandom
{
    public interface ICard
    {
        int Id { get; set; }
    }

    public class HeroRef : ICard
    {
        public int Id { get; set; }
        public int Turn { get; set; }
    }

    public class CardRef : ICard
    {
        public int Id { get; set; }
        public int Count { get; set; }
    }

    public class Deck
    {
        public string Name { get; set; }
        public List<HeroRef> Heroes { get; set; }
        public List<CardRef> Cards { get; set; }
    }

    public class ColorChosen
    {
        public bool RedChosen { get; set; }
        public bool GreenChosen { get; set; }
        public bool BlueChosen { get; set; }
        public bool BlackChosen { get; set; }
        public bool BalancedChosen { get; set; }
        public int AmounOfCards { get; set; }
        public int AmounOfItems { get; set; }
        public int RedHeroes { get; set; }
        public int GreenHeroes { get; set; }
        public int BlueHeroes { get; set; }
        public int BlackHeroes { get; set; }
        public int ManaBalance { get; set; }

        public ColorChosen()
        {
            AmounOfCards = 40;
            AmounOfItems = 9;
            RedHeroes = 0;
            GreenHeroes = 0;
            BlueHeroes = 0;
            BlackHeroes = 0;
            ManaBalance = 8;
            RedChosen = false;
            GreenChosen = false;
            BlueChosen = false;
            BlackChosen = false;
            BalancedChosen = false;
        }

        public void SetHeroesToZero()
        {
            RedHeroes = 0;
            GreenHeroes = 0;
            BlueHeroes = 0;
            BlackHeroes = 0;
            ManaBalance = 8;
        }
    }
}
