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
            Console.WriteLine($"SeaCommando: {Name}, is swimming");
        }

        public override void Attack()
        {
            Status = "Attack";
            Console.WriteLine($"SeaCommando: {Name},is Attacking.");
        }
    }
}
