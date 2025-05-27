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
        private string Name { get; set; }
        private string Manufacturer { get; set; }
        private int BulletAmount { get; set; }

        public Weapon(string name,string manufacturer, int bulletAmount)
        {
            Name = name;
            Manufacturer = manufacturer;
            BulletAmount = bulletAmount;

            Console.WriteLine($"{Name}, Weapon Created.");

        }

        public void Shoot()
        {
            BulletAmount --;
            Console.WriteLine($"{Name} fired a Shot.");
        }
    }
}
