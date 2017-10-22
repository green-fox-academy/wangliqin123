namespace BabiesInTheZoo
{
    public abstract class Animal
    {
        protected string name;
        protected int age;
        protected string gender = "female";
        protected string babyFrom = "want a child from an egg!";

        public abstract void Greet();
        public abstract string WantChild();
        public abstract string GetName();
        public abstract void BabyInfo();
    }
}