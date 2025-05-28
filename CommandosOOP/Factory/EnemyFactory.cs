using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandosOOP.Models;


namespace CommandosOOP.Models
{
    internal class EnemyFactory
    {
        static public List<Enemy> Create(string[] EnemiesNameList)
            {
            List<Enemy> Enemies = new List<Enemy>;
            foreach (string name in EnemiesNameList)
                {
                Enemies.Add(new Enemy(name));
                }
            Console.WriteLine("Factory created all Enemies");
            return Enemies;
            }
        }
    }
