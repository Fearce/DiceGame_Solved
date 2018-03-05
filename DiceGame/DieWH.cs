using System;
using System.Threading;

namespace DiceGame
{
    /// <summary>
    /// This class represents a single N-sided die
    /// The creator of Die objects specify the value of N
    /// </summary>
    class DieWH
    {
        #region Instance fields
        private int _value;
        private Random _generator;
        #endregion

        #region Constructor
        public DieWH()
        {
            _generator = new Random(); // The generator is used for generating random numbers
            Roll();  // This puts the die in a well-defined state
        }
        #endregion

        #region Properties

        public int Attacks { get; set; }
        public int ToHit { get; set; }
        public int DidHit { get; set; }
        public int ToWound { get; set; }
        public int Wounds { get; set; }
        public int SaveChar { get; set; }
        public int AmountSixes { get; set; }

        public int Return
        {
            get { return _value; }

        }
        #endregion

        #region Methods
        /// <summary>
        /// Roll the die: the value will be set to a random number
        /// between 1 and _noOfSides (both included).
        /// </summary>
        public void Roll()
        {
                    Thread.Sleep(10); // This is needed for magical purposes...
                    _value = _generator.Next(6) + 1;
        } 
        #endregion
    }
}
