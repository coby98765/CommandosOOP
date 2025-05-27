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
            Console.WriteLine($"AirCommando '{CodeName}' is Parachuting");
        }

        public override void Attack(Enemy e)
        {
            Status = "Attack";
            e.Attack(10);
            Console.WriteLine($"AirCommando '{CodeName}' is Attacking.");
        }
    }
}
