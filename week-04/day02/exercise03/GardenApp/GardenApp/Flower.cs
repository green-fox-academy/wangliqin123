namespace GardenApp
{
    class Flower : Plant
    {
        public Flower(string color)
        {
            this.type = "flower";
            this.color = color;
            this.waterNeeded = 5;
            this.absorb = 0.75;
        }
    }
}