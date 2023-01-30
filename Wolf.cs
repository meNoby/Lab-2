namespace Lab2
{

    using System;
    internal class Wolf : Dog, IAnimalActionsWild
    {
        #region FIELDS & PROPERTIES

        private new string _voice = "howl";
        #endregion

        #region METHODS
        public new void Sound()
        {
            base.Sound(GetAnimalType, _voice);
        }

        #endregion

        #region CONSTRUCTORS

        public Wolf() : this("default cat name") { }
        public Wolf(string name) : base(name) { }
        #endregion
    }
}
