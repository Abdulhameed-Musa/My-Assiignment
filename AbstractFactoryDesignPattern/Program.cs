using AbstractFactoryDesignPattern;


Animal animal = null;
AnimalFactory animalFactory = null;
string speakSound = null;

// Land
animalFactory = AnimalFactory.CreateAnimalFactory("Land");
Console.WriteLine("Animal Factory type : " + animalFactory.GetType().Name);
Console.WriteLine();
//  Lion
animal = animalFactory.GetAnimal("Lion");
Console.WriteLine("Animal Type : " + animal.GetType().Name);
speakSound = animal.Speak();
Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
Console.WriteLine();
//  Cat
animal = animalFactory.GetAnimal("Cat");
Console.WriteLine("Animal Type : " + animal.GetType().Name);
speakSound = animal.Speak();
Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
Console.Read();
