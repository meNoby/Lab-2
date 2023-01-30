namespace Lab2
{

    using System;

    internal abstract class Animal : IAnimalActions, IAnimalActionsStranger, IAnimalActionsWild
    {
        #region FIELDS & PROPERTIES

        protected string _name;
        protected string _voice = "default voice";
        private bool familiar = false;
        private static bool _first = true;
        public virtual string GetName { get => _name;  }
        public string GetAnimalType { get; }
        #endregion

        #region METHODS

        public virtual void Sound(string animal, string sound)
        {
            Console.WriteLine($"The {animal} says: {sound}!");
        }

        public void GetFamiliar()
        {
            familiar = true;
        }

        void IAnimalActions.Sit()
        {
            Console.WriteLine($"The {GetName} sits obediently");
        }

        void IAnimalActionsStranger.Sit()
        {
            if (!familiar)
                Console.WriteLine($"The {GetName} refuses to sit since you're not familiar with it");
            else
                Console.WriteLine($"The {GetName} sits obediently");
        }

        void IAnimalActionsWild.Sit()
        {
            Console.WriteLine($"The {GetName} is a wild animal and can't listen to commands");
        }

        #endregion

        #region CONSTRUCTORS

        public Animal() : this("default name") { }
        public Animal(string name) : this(name, "default animal") { }
        public Animal(string name, string animalType)
        {
            if (_first) { _name = name + " The first"; _first = !_first; }
            else { _name = name; }
            GetAnimalType = animalType;
        }
        static Animal() { Console.WriteLine("First animal created will be titled 'The First' ");  } // Static
        #endregion

        #region EVENT HANDLER
        public event EventHandler<Animal> AnimalFamiliarized;

        protected virtual void  AlreadyFamiliar(Animal e)
        {
            EventHandler<Animal> handler = AnimalFamiliarized;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        #endregion
    }
}