using System;
using System.Linq;
using HeroPerk;
using System.Collections.Generic;

namespace HeroPerk
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string stealth = "s";
            char stealthChar = char.Parse(stealth);

            string warpShift = "d";
            char warpShiftChar = char.Parse(warpShift);

            string doubleJump = "w";
            char doubleJumpChar = char.Parse(doubleJump);

            string autoHeal = "a";
            char autoHealChar = char.Parse(autoHeal);

            Perks perk = 0;

            foreach (string c in args)
            {
                foreach (char s in c)
                {
                    switch (s)
                    {
                        case 'd':
                            perk ^= Perks.DoubleJump;
                            break;
                        case 'w':
                            perk ^= Perks.WarpShift;
                            break;
                        case 'a':
                            perk ^= Perks.AutoHeal;
                            break;
                        case 's':
                            perk ^= Perks.Stealth;
                            break;
                        default:
                            System.Console.WriteLine("!Unknown perk!");
                            return;


                    }

                }


            }



            List<string> activePerks = new List<string>();

            foreach (Perks n in Enum.GetValues(typeof(Perks)))
            {
                if ((perk & n) == n)
                {
                    activePerks.Add(Enum.GetName(typeof(Perks), n));
                }
            }

            if (perk == 0)
            {
                System.Console.WriteLine("!No perks at all!");
            }
            else
            {
                Console.WriteLine(string.Join(", ", activePerks));
            }


            if ((perk & Perks.DoubleJump) != 0 &&
                (perk & Perks.Stealth) != 0)
            {
                System.Console.WriteLine("!Silent jumper!");
            }



            if ((perk & Perks.AutoHeal) != Perks.AutoHeal)
            {
                System.Console.WriteLine("!Not gonna make it!");
            }

        }
    }
}
