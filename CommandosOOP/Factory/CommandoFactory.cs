using CommandosOOP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CommandosOOP.Models
    {
    internal class CommandoFactory
        {
        static public List<Commando> Create(List<Dictionary<string, string>> CommandosNameList)
            {
            List<Commando> Commandos = new List<Commando>();
            Random random = new Random();

            foreach (Dictionary<string, string> commando in CommandosNameList)
                {
                Console.WriteLine("commando type: " + commando["type"]);
                int WeaponAmount = random.Next(1, 3);

                switch (commando["type"])
                    {
                    case "air":
                        Commandos.Add(new AirCommando(commando["name"], commando["nickname"]));
                        break;
                    case "land":
                        Commandos.Add(new Commando(commando["name"], commando["nickname"]));
                        break;
                    case "sea":
                        Commandos.Add(new SeaCommando(commando["name"], commando["nickname"]));
                        break;
                    }
                }
            Console.WriteLine("Factory created all Commandos");
            return Commandos;
            }
        }
    }
