using CommandosOOP.Models;
using System.Runtime.CompilerServices;


namespace CommandosOOP
{
    class Program
    {
        static void Main()
        {
            string[] ToolTypes = { "Hammer", "Chisel", "rope", "bag", "water bottle" };

            //init Commando ant test methods
            Commando testCommando = new Commando("test","badass", ToolTypes);
            testCommando.Walk();
            testCommando.Hide();
            testCommando.Attack();

            //init Weapon ant test methods
            Weapon testWeapon = new Weapon("Hammer", "AAA", 10);
            testWeapon.Shoot();

        }
    }
}