using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CommandosOOP.Models;


namespace CommandosOOP.Models
    {
    internal class Factory
        {
        public List<Enemy> Enemies { get; } = new List<Enemy>();
        public List<Commando> Commandos { get; } = new List<Commando>();

        public Factory()
            {
            EnemyFactory(NameList.EnemiesName);
            CommandoFactory(NameList.CommandosNames);
            }

        private void EnemyFactory(string[] EnemiesNameList)
            {
            foreach (string name in EnemiesNameList)
                {
                Enemies.Add(new Enemy(name));
                }
            Console.WriteLine("Factory created all Enemies");
            }

        private void CommandoFactory(List<Dictionary<string, string>> CommandosNameList)
            {

            foreach (Dictionary<string, string> commando in CommandosNameList)
                {
                Console.WriteLine("commando type: " + commando["type"]);

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
            }
        }
    }
 
