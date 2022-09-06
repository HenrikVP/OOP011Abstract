namespace OOP011Abstract
{
    internal class Car : Vehicle
    {
        public int KmPerLiter { get; set; }

        public override string Description()
        {
            return $"{Name} Km/l: {KmPerLiter}";
        }

        public override string NameName()
        {
            return Name + Name;
        }
    }
}
