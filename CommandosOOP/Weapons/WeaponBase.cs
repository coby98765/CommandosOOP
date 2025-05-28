using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandosOOP.Models;


namespace CommandosOOP.Models
    {
    internal class WeaponBase
        {

        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Strength { get; set; }
        public int Health { get; set; }
        public string Color { get; set; }
        public double Weight { get; set; }
        public string Status { get; set; }


        public WeaponBase(Dictionary<string, object> data)
            {
            Name = (string)data["name"];
            Manufacturer = (string)data["maker"];
            Strength = (int)data["strength"];
            Health = (int)data["health"];
            Color = (string)data["color"];
            Weight = (double)data["weight"];
            Status = "active";
            Console.WriteLine($"Weapon {Name}, {Manufacturer} was created.");
            }
        public virtual void Printer()
            {
            Console.WriteLine($"Weapon Name {Name},\n" +
                $"Manufacturer: {Manufacturer}\n" +
                $"Strength: {Strength}\n" +
                $"Health: {Health}\n" +
                $"Color: {Color}\n" +
                $"Weight: {Weight}\n" +
                $"Status: {Status}\n");
            }

        public bool TakeAHit(int strength)
            {
            if (Health - strength <= 0)
                {
                Health = 0;
                Status = "inactive";
                Console.WriteLine($"Weapon {Name}, Got hit bad and is now inactive.");
                return false;
                }
            else
                {
                Health -= strength;
                return true;
                }
            }
        public WeaponBase(string name, string maker,int strength, int health, string color, double weight)
            {
            Name = name;
            Manufacturer = maker;
            Strength = strength;
            Health = health;
            Color = color;
            Weight = weight;
            Status = "active";
            Console.WriteLine($"Weapon {Name}, {Manufacturer} was created.");
            }

        }
    }
