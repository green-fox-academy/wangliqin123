namespace ParkingLot
{
    class Car : Storage
    {
        public CarType Type;
        public CarColor Color;

        public Car(CarColor color, CarType type)
        {
            Type = type;
            Color = color;
        }
    }

    public enum CarType
    {
        Lada,
        Zaporozsec,
        Dacia,
        Zastava,
        Volga,
        Wartburg,
        Skoda,
        Trabant,
        Moszkvics
    }

    public enum CarColor
    {
        White,
        Black,
        Red,
        Purple,
        Green,
        Yellow,
        Blue,
        Grey,
        Pink,
    }
}