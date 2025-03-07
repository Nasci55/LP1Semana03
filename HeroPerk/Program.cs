using System;
using HeroPerks;

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

            byte perk = 0b0000;

            foreach (string c in args)
            {
                foreach (char s in c)
                {
                    switch (s)
                    {
                        case 'w':
                            perk ^= (byte)Perks.DoubleJump;
                            break;
                        case 'd':
                            perk ^= (byte)Perks.WarpShift;
                            break;
                        case 'a':
                            perk ^= (byte)Perks.AutoHeal;
                            break;
                        case 's':
                            perk ^= (byte)Perks.Stealth;
                            break;
                        default:
                            System.Console.WriteLine("!Unknown perk!");
                            return;


                    }

                }


            }

            if (perk == 0)
            {
                System.Console.WriteLine("!No perks at all!");
                return;
            }






            if ((perk & (byte)Perks.AutoHeal) != (byte)Perks.AutoHeal)
            {
                System.Console.WriteLine("!Not gonna make it!");
            }

        }
    }
}
