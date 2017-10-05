namespace GardenApp
{
    class Plant
    {
        public string color;
        public string type;
        public int waterNeeded;
        public double absorb;
        public double waterAmount;

        public bool IsThirsty()
        {
            return waterAmount < waterNeeded;
        }
    }
}