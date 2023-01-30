namespace Lab2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            IAnimalActions puppy1 = new Dog("Asmodeus");
            IAnimalActionsStranger kitty1 = new Cat("Sparkles");
            IAnimalActionsWild cub1 = new Wolf("Karl");
            IAnimalActionsWild snake1 = new Snake("Josh");

            Console.WriteLine("Let's call the same method from different interfaces!\n");

            Console.WriteLine($"Type = {puppy1.GetType()}");
            WriteData(puppy1, puppy1.GetType());
            WriteData(kitty1, kitty1.GetType());
            WriteData(cub1, cub1.GetType());
            WriteData(snake1, snake1.GetType());

            Console.ReadKey();
        }

        private static void WriteData(IAnimalActions animal, Type animalType)
        {
            Console.WriteLine($"Name: {animal.GetName}");
            Console.WriteLine($"Type: {animal.GetAnimalType}");
            
            if (animalType is IAnimalActionsStranger)
                ((IAnimalActionsStranger)animal).Sit();
            if (animalType is IAnimalActionsWild)
                ((IAnimalActionsWild)animal).Sit();
            if (animalType is IAnimalActions)
                animal.Sit();
        }

    }
}