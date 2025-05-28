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
            Enemies = EnemyFactory.Create(NameList.EnemiesName);
            Commandos = CommandoFactory.Create(NameList.CommandosNames);
            }
        }
    }
 
