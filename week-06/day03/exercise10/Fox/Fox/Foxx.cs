
namespace Fox
{
    public class Foxx
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }

        public Foxx(string name, string color, string type)
        {
            this.Name = name;
            this.Color = color;
            this.Type = type;   
        }
    }
}