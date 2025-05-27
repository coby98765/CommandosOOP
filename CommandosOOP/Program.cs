using CommandosOOP.Models;
using System.Runtime.CompilerServices;
using System.Xml.Linq;


namespace CommandosOOP
{
    class Program
    {
        static void Main()
        {
            //init Commando ant test methods
            Commando testCommando = new Commando("Command", "badass");
            testCommando.Walk();
            testCommando.Hide();
            testCommando.Attack();



            //init Weapon ant test methods
            Weapon testWeapon = new Weapon("Hammer", "AAA", 10);
            testWeapon.Shoot();

        }
    }
}