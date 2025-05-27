using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandosOOP.Models;


namespace CommandosOOP.Models
{
    internal class Weapon
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int BulletAmount { get; set; }

        Weapon(string name,string manufacturer, int bulletAmount)
        {
            Name = name;
            Manufacturer = manufacturer;
            BulletAmount = bulletAmount;

            Console.WriteLine("Weapon Created.");

        }

        void Shoot()
        {
            BulletAmount --;
            Console.WriteLine("💥 Shots fired.");
        }
    }
}
