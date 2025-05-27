using CommandosOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandosOOP.Models
{
    internal class AirCommando : Commando
    {
        public AirCommando(string name, string nickname) : base(name, nickname) { }

        public void Parachute()
        {
            Console.WriteLine($"AirCommando: {Name}, is Parachuting");
        }

        public override void Attack()
        {
            Status = "Attack";
            Console.WriteLine($"AirCommando: {Name},is Attacking.");
        }
    }
}
