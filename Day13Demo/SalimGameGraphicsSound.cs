using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Demo
{
    public static class SalimGameGraphicsSound
    {
        public delegate void WaiItShootDelegate();

        public static void KillVillain(WaiItShootDelegate waiItShootDelegate)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Whooosh!!!!!");

            waiItShootDelegate();

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("AAAHHHHH BLOOD!!!!!");
        }
    }
}
