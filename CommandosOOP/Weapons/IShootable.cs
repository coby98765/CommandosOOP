using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandosOOP.Models;


namespace CommandosOOP.Models
    {
    //Hot Weapon
    internal interface IShootable
        {
        public int Shoot();
        public void Reload();
        public int Bullets { get; set; }
        }
    }
