using CommandosOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandosOOP.Models
{
    internal class SeaCommando : Commando
    {
        public SeaCommando(string name, string nickname) : base(name, nickname) { }

        public void Swim()
        {
            Console.WriteLine($"SeaCommando '{CodeName}' is swimming");
        }

        public override void Attack(Enemy e)
        {
            Status = "Attack";
            e.Attack(7);
            Console.WriteLine($"SeaCommando '{CodeName}' is Attacking.");
        }
    }
}
