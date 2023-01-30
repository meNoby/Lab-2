namespace Lab2
{

    using System;
    internal class Cat : Animal, IAnimalActions
    {
        #region FIELDS & PROPERTIES

        private new string _voice = "meow";
        #endregion

        #region METHODS

        public void Sound()
        {
            base.Sound(GetAnimalType, _voice);
        }
        #endregion

        #region CONSTRUCTORS

        public Cat() : base("default cat name") { }
        public Cat(string name) : base(name, "cat") { }
        #endregion
    }
}
