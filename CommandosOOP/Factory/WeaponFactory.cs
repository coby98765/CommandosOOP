using CommandosOOP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CommandosOOP.Models
    {
    internal class WeaponFactory
        {
        static public WeaponBase[] CreateArr(List<Dictionary<string, object>> WeaponNameList, int WeaponAmount)
            {
            WeaponBase[] Commandos = new WeaponBase[WeaponAmount];
            for(int i = 0;i<= WeaponAmount; i++)
                {
                int x = 0;//need to figure out the weapon from list
                Commandos[i] = CreateWeapon(WeaponNameList[x]);
                }
            return Commandos;
            }

        static public WeaponBase CreateWeapon(Dictionary<string, object> WeaponName)
            {
            return null;
            }

        }
    }
