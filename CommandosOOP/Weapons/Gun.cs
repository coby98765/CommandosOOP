using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandosOOP.Models;


namespace CommandosOOP.Models
    {
    internal class Gun : WeaponBase, IShootable
        {
        public int Bullets { get; set; }
        private int MaxBullets { get; }

        public Gun(Dictionary<string, object> data) : base(data)
            {
            MaxBullets = (int)data["bullets"];
            Bullets = MaxBullets;
            Console.WriteLine($"Gun {Name} is loaded with {Bullets} bullets.");
            }

        public int Shoot()
            {
            if (Bullets > 0)
                {
                Bullets--;
                Console.WriteLine($"Bang! {Bullets} bullets left.");
                return Strength; // Strength of gun (how much to decrees from health)
                }
            else
                {
                Status = "inactive";
                Console.WriteLine("Click! Out of bullets.");
                return 0; // empty shot
                }
            }

        public void Reload()
            {
            Bullets = MaxBullets;
            Console.WriteLine("Reloaded.");
            }
        public override void Printer()
            {
            Console.WriteLine($"Weapon Name {Name},\n" +
                $"Manufacturer: {Manufacturer}\n" +
                $"Strength: {Strength}\n" +
                $"Health: {Health}\n" +
                $"MaxBullets: {MaxBullets}\n" +
                $"Bullets: {Bullets}\n" +
                $"Color: {Color}\n" +
                $"Weight: {Weight}\n" +
                $"Status: {Status}\n");
            }
        }

    }
