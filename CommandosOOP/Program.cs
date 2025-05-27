using CommandosOOP.Models;
using System.Runtime.CompilerServices;


namespace CommandosOOP
{
    class Program
    {
        public readonly string[] ToolTypes = { "Hammer", "Chisel", "rope", "bag", "water bottle" };
        void Main()
        {
            Commando testCommando = new Commando("test","badass", ToolTypes);


        }
    }
}