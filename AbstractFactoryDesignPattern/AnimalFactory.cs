namespace AbstractFactoryDesignPattern
{
    public abstract class AnimalFactory
    {
        public abstract Animal GetAnimal(string AnimalType);
        public static AnimalFactory CreateAnimalFactory(string FactoryType)
        {
         return new LandAnimalFactory();
        }
    }
}