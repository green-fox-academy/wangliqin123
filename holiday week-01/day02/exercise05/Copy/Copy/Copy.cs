namespace Copy
{
    class Copy
    {
        static void Main(string[] args)
        {
            Command command = new Command();

            if (args.Length == 0)
            {
                command.Usage();
            }
            else if (args.Length > 0)
            {
                command.CopyFile(args);
            }
        }
    }
}