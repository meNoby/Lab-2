namespace Lab2
{

    using System;
    internal class Dog : Animal, IAnimalActions
    {
        #region FIELDS & PROPERTIES
        
        private new string _voice = "woof";
        #endregion

        #region METHODS

        public void Sound()
        {
            base.Sound(GetAnimalType, _voice);
        }
        #endregion

        #region CONSTRUCTORS

        public Dog() : this("default dog name") { }
        public Dog(string name) : base(name, "Dog") { }
        #endregion
    }
}
