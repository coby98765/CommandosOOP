using CommandosOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace CommandosOOP.Models
{
    internal class Enemy
    {
        protected string Name { get; set; }
        protected int Lives = 100;
        protected string Status  = "alive";

        public Enemy(string name)
        {
            Name = name;
            Console.WriteLine($"Enemy '{Name}' was Created.");
        }

        public int Attack(int lives)
        {
            if((Lives - lives) <= 0)
            {
                Kill();
                return 0;
            }
            else
            {
                Lives -= lives;
                return Lives;
            }
        }

        public void Kill()
        {
            Status = "dead";
            Console.WriteLine($"Enemy '{Name}' was Kiled.");
        }

        public void Scream()
        {
            Console.WriteLine($"I'm an Enemy.");
        }
    }
}
