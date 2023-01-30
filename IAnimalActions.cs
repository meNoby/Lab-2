using System;

namespace Lab2
{
    internal interface IAnimalActions
    {
        string GetName { get; }
        string GetAnimalType { get; }

        void Sound(string animal, string sound);

        void Sit();
    }
}
