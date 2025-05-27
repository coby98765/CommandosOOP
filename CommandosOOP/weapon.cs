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

        public Weapon(string name,string manufacturer, int bulletAmount)
        {
            Name = name;
            Manufacturer = manufacturer;
            BulletAmount = bulletAmount;

            Console.WriteLine("Weapon Created.");

        }

        public void Shoot()
        {
            BulletAmount --;
            Console.WriteLine("💥 Shots fired.");
        }
    }
}
