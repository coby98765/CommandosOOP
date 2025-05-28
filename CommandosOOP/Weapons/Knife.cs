using CommandosOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CommandosOOP.Weapons
    {
    internal class Knife : WeaponBase, IBreakable
        {
        public int Hits { get; set; }
        public int MaxHits { get; }

        public Knife(Dictionary<string, object> data) : base(data)
            {
            Hits = 0;
            MaxHits = (int)data["maxHits"];
            Console.WriteLine($"Knife {Name} is ready. Max stabs: {MaxHits} .");
            }

        public int Stab()
            {
            if (Hits >= MaxHits)
                {
                Status = "inactive";
                Console.WriteLine($"Knife {Name} is broken and cannot be used anymore.");
                return 0;
                }

            Hits++;
            Console.WriteLine($"Stab! {Name} used {Hits}/{MaxHits} times.");
            return Strength;
            }
        }
    }
