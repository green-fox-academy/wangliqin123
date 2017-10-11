namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Commands commands = new Commands();

            string[] arguments = { "-r", "-a", "-l" };

            if (args.Length == 0)
            {
                commands.Usage();
            }
            else if (args[0] == "-l")
            {
                commands.ListAnimals();
            }
            else if (args[0] == "-r")
            {
                commands.RemoveAnimal(args[1]);
            }
            else if (args[0] == "-a")
            {
                commands.AddAnimal(args[1]);
            }
        }
    }
}