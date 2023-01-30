namespace Lab2
{

    using System;
    internal class Snake : Animal, IAnimalActions
    {
        #region FIELDS & PROPERTIES

        private new string _voice = "I'm a sneeek";
        #endregion

        #region METHODS

        public void Sound()
        {
            base.Sound(GetAnimalType, _voice);
        }
        #endregion

        #region CONSTRUCTORS

        public Snake() : base("default snake name") { }
        public Snake(string name) : base(name, "snake") { }
        #endregion
    }
}
