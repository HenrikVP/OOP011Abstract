namespace OOP011Abstract
{
    internal abstract class Vehicle
    {
        public string Name { get; set; }

        public virtual string Description()
        {
            return $"{Name}";
        }

        //Ved at lave en abstract metode fortæller vi alle der nedarver fra vehicle SKAL implementere metoden.
        public abstract string NameName();
    }
}
