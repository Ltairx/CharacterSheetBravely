using System.ComponentModel;

namespace WebApplication1.Models
{
    public class Character
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Speed { get; set; }
        public int Health { get; set; }
        public int BulkBuffer { get; set; }
        public int CurrentHp { get; set; }
        public int MaxHp { get; set; }
        public int Defense { get; set; }
        public int Avoid { get; set; }
        public int Money { get; set; }
        public Class Class { get; set; }
        public ClassAdvancement ClassAdvancement { get; set; } = new();
        public Dictionary<Stats, int> BaseStats { get; set; } = new();
        public Dictionary<Skills, Ranks> Skills { get; set; } = new();
        public Dictionary<Weapons, Ranks> WeaponRanks { get; set; } = new();
        public Dictionary<string, int> Items { get; set; } = new();

        public Character() {
            foreach (Skills value in Enum.GetValues(typeof(Skills)))
            {
                Skills.Add(value, Ranks._);
            }

            foreach (Weapons value in Enum.GetValues(typeof(Weapons)))
            {
                WeaponRanks.Add(value, Ranks._);
            }

            foreach (Stats value in Enum.GetValues(typeof(Stats)))
            {
                BaseStats.Add(value, 0);
            }
        }
    }

    public enum Class
    {
        Berserker = 0,
        FortuneTeller = 1,
        Gravekeeper = 2,
        Guard = 3,
        Huntsman = 4,
        MagicallyAflicted = 5,
        Scholar = 6,
        Spearman = 7,
        Trickster = 8,
    }

    public enum ClassAdvancement
    {
        Base = 0,
        Advanced = 1,
        Ultimate = 2,
    }

    public enum Ranks
    {
        _ = 0,
        C = 1,
        B = 2,
        A = 3,
        S = 4,
    }

    public enum Stats
    {
        Mastery = 0,
        Bulk = 1,
        Memory = 2,
        imagination = 3,
        Leadership = 4,
        Luck = 5,
    }

    public enum Skills
    {
        Alchemy = 0,
        Athletics = 1,
        Crafting = 2,
        History = 3,
        Investigation = 4,
        Performing = 5,
        Religion = 6,
        Reputation = 7,
        Riding = 8,
        Spellworking = 9,
        Survival = 10,
        Thievery = 11,
        Understanding = 12,
    }

    public enum Weapons
    {
        Swords = 0,
        Axes = 1,
        Polearms = 2,
        Bowlike = 3,
        Firearms = 4,
        Magic = 5,
    }
}
