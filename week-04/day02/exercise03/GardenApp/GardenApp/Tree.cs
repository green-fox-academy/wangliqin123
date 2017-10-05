namespace GardenApp
{
    class Tree : Plant
    {
        public Tree(string color)
        {
            this.type = "tree";
            this.color = color;
            this.waterNeeded = 10;
            this.absorb = 0.4;
        }
    }
}