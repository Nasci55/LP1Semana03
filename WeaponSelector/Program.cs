﻿using System;
using System.Net;

namespace WeaponSelector
{
    public class Program
    {
        /// <summary>
        /// Main method. Do not change it!
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        private static void Main(string[] args)
        {
            // DO NOT CHANGE THIS METHOD!
            EnemyType enemy = Enum.Parse<EnemyType>(args[0]);
            Weapons weapon = ParseWeapons(args);
            bool dies = WeaponsKillEnemy(enemy, weapon);
            DisplayResult(enemy, dies);
            // DO NOT CHANGE THIS METHOD!
        }

        /// <summary>
        /// Parse the command line arguments to get the weapon.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        /// <returns>The weapons.</returns>
        private static Weapons ParseWeapons(string[] args)
        {
            Weapons weapon = 0;

            foreach (string weap in args)
            {
                switch (weap)
                {
                    case "SilverBullet":
                        weapon |= Weapons.SilverBullet;
                        break;

                    case "HolyWater":
                        weapon |= Weapons.HolyWater;
                        break;

                    case "Garlic":
                        weapon |= Weapons.Garlic;
                        break;

                    default:
                        weapon |= Weapons.None;
                        break;

                }





            }
            return weapon;
        }

        /// <summary>
        /// Is the enemy killed with any of the weapons?
        /// </summary>
        /// <param name="enemy">The enemy we're trying to kill.</param>
        /// <param name="weapons">The weapons used to try and kill the enemy.</param>
        /// <returns>Wether the enemy was killed or not.</returns>
        private static bool WeaponsKillEnemy(EnemyType enemy, Weapons weapons)
        {
            bool dies = false;

            if (enemy == EnemyType.Zombie)
            {
                if ((weapons & Weapons.SilverBullet) == Weapons.SilverBullet)
                {
                    dies = true;

                }
            }
            if (enemy == EnemyType.Vampire)
            {
                if ((weapons & Weapons.Garlic) == Weapons.Garlic ||
                (weapons & Weapons.HolyWater) == Weapons.HolyWater)
                {
                    dies = true;
                }
            }

            if (enemy == EnemyType.Werewolf)
            {
                if ((weapons & Weapons.SilverBullet) == Weapons.SilverBullet)
                {
                    dies = true;
                }
            }
            if (enemy == EnemyType.Ghost)
            {
                if ((weapons & Weapons.HolyWater) == Weapons.HolyWater)
                {
                    dies = true;
                }
            }

            return dies;
        }

        /// <summary>
        /// Display information on wether the enemy was killed or not.
        /// </summary>
        /// <param name="enemy">The enemy we're trying to kill.</param>
        private static void DisplayResult(EnemyType enemy, bool survives)
        {

            if (survives == false)
            {
                System.Console.WriteLine($"{enemy} survives ");
            }
            else
            {
                System.Console.WriteLine($"{enemy} dies");
            }
        }
    }
}
