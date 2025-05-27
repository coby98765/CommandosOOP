using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandosOOP.Models;

namespace CommandosOOP.Models
{
    internal class Commando
    {
        private string Name { get; set; }
        private string Nickname { get; set; }
        private string[] Tools = new string[5];
        private string? Status { get; set; }

        public Commando(string name, string nickname, string[] tools) 
        {
            Name = name;
            Nickname = nickname;
            Tools = tools;
            //Status = status;

            Console.WriteLine($"{Name}, Commando Created.");
        }

        public void Walk()
        {
            Status = "Walk";
            Console.WriteLine($"{Name} Walking.");
        }

        public void Hide()
        {
            Status = "Hide";
            Console.WriteLine($"{Name} Hiding.");
        }

        public void Attack()
        {
            Status = "Attack ";
            Console.WriteLine($"{Name} Attacking.");
        }

        public string SayName(string commanderRank)
        {
            switch (commanderRank.ToUpper())
            {
                case "GENERAL":
                    return Name;
                case "COLONEL":
                    return Nickname;
                default:
                    Console.WriteLine("Not Authorized to access Commando's Name");
                    return null;
            }

        }
    }
}
