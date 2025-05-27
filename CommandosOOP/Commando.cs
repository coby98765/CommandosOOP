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
        public string Name { get; set; }
        public string Nickname { get; set; }
        public string[] Tools = new string[5];
        public string? Status { get; set; }

        public Commando(string name, string nickname, string[] tools) 
        {
            Name = name;
            Nickname = nickname;
            Tools = tools;
            //Status = status;

            Console.WriteLine("Commando Created.");
        }

        public void Walk()
        {
            Status = "Walk";
            Console.WriteLine("Commando Walking.");
        }

        public void Hide()
        {
            Status = "Hide";
            Console.WriteLine("Commando Hiding.");
        }

        public void Attack()
        {
            Status = "Attack ";
            Console.WriteLine("Commando Attacking.");
        }
    }
}
