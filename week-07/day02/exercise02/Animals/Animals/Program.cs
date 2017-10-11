namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals animals = new Animals();

            if (args.Length > 0)
            {
                animals.AddAnimal(args);
            }
            else
            {
                animals.Usage();
            }
        }
    }
}