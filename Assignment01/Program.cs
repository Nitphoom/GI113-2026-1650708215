// Student ID: [1650708215] / Name: Nitiphoom Chuepet / Section: 129A / No: 

using System;

namespace Assignment01
{
    class Program
    {
        static void Main(string[] args)
        {

            const string GameTitle = "Mobile Legends: Bang Bang";
            const string HeroRole = "Assassin / Fighter";


            string heroName = "Suyou";
            char heroTier = 'S';
            int baseHealth = 2758;
            float physicalAttack = 125.5f;
            double criticalChance = 15.75;
            bool isMetaBanned = true;


            var lanePosition = "EXP Lane";
            var damageType = "Physical Burst";


            int baseMovementSpeed = 260;
            float actualMovementSpeed = baseMovementSpeed;


            double magicDefenseBase = 38.8;
            int castedMagicDef = (int)magicDefenseBase;
            int convertedMagicDef = Convert.ToInt32(magicDefenseBase);


            Console.WriteLine($"=================================================");
            Console.WriteLine($"           {GameTitle}           ");
            Console.WriteLine($"=================================================");
            Console.WriteLine($" [ HERO STAT CARD ] ");
            Console.WriteLine($" Name: {heroName} | Tier: {heroTier}");
            Console.WriteLine($" Role: {HeroRole} | Lane: {lanePosition}");
            Console.WriteLine($" Damage: {damageType} | Banned in Rank: {isMetaBanned}");
            Console.WriteLine($"-------------------------------------------------");
            Console.WriteLine($" [ COMBAT ATTRIBUTES ] ");
            Console.WriteLine($" HP: {baseHealth}");
            Console.WriteLine($" Physical Attack: {physicalAttack}");
            Console.WriteLine($" Critical Chance: {criticalChance}%");
            Console.WriteLine($" Movement Speed (Implicit Float): {actualMovementSpeed}");
            Console.WriteLine($"-------------------------------------------------");
            Console.WriteLine($" [ MAGIC DEFENSE ANALYSIS ] ");
            Console.WriteLine($" Base Magic Defense: {magicDefenseBase}");
            Console.WriteLine($" Defense after Cast (int): {castedMagicDef} ");
            Console.WriteLine($" Defense after Convert: {convertedMagicDef} ");
            Console.WriteLine($"=================================================");
            Console.WriteLine($" Thank you for using the Hero Stat Card Generator! ");
           Console.WriteLine($"=================================================");
        }
    }
}