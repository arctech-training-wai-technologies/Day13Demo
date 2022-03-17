using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Demo
{    
    public static class DelegateDemo2
    {
        public static void Test()
        {
            Console.WriteLine("-------");    
            SalimGameGraphicsSound.KillVillain(ShootRifle);
            SalimGameGraphicsSound.KillVillain(ShootGun);
            SalimGameGraphicsSound.KillVillain(ShootPistol);
            SalimGameGraphicsSound.KillVillain(ShootRifle);
            
            //Console.WriteLine("-------");
            //ShootRifle();
            //ShootGun();
            //ShootPistol();
            //ShootRifle();
            //Console.WriteLine("-------");
        }

        public static void ShootGun()
        {
            Console.WriteLine("Shooting Gun");
        }

        public static void ShootRifle()
        {
            Console.WriteLine("Shooting Rifle");
        }

        public static void ShootPistol()
        {
            Console.WriteLine("Shooting Pistol");
        }
    }
}
