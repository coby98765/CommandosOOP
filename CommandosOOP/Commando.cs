namespace CommandosOOP.Models
{
    internal class Commando
    {
        protected string Name { get; set; }
        protected string CodeName { get; set; }
        protected string[] Tools = { "Hammer", "Chisel", "rope", "bag", "water bottle" };
        protected string? Status { get; set; }

        public Commando(string name, string nickname) 
        {
            Name = name;
            CodeName = nickname;
            Console.WriteLine($"Commando: {Name} was Created.");
        }

        public void Walk()
        {
            Status = "Walk";
            Console.WriteLine($"Commando {Name} is Walking.");
        }

        public void Hide()
        {
            Status = "Hide";
            Console.WriteLine($"Commando {Name} is Hiding.");
        }

        public virtual void Attack()
        {
            Status = "Attack";
            Console.WriteLine($"Commando {Name} is Attacking.");
        }

        public string SayName(string commanderRank)
        {
            switch (commanderRank.ToUpper())
            {
                case "GENERAL":
                    return Name;
                case "COLONEL":
                    return CodeName;
                default:
                    Console.WriteLine("Not Authorized to access Commando's Name");
                    return null;
            }
        }
    }
}
