using System;
using System.Threading;

namespace DiceGame
{
    /// <summary>
    /// This class represents a single N-sided die
    /// The creator of Die objects specify the value of N
    /// </summary>
    class DieNSides
    {
        #region Instance fields
        private int _value;
        private int _noOfSides;
        private Random _generator;
        #endregion

        #region Constructor
        public DieNSides(int noOfSides)
        {
            _noOfSides = noOfSides;
            _generator = new Random(); // The generator is used for generating random numbers
            Roll();  // This puts the die in a well-defined state
        }
        #endregion

        #region Properties

        public int NumberOfChoices { get; set; }

        public int NumberOfRolls { get; set; }

        public string Return
        {
            get
            {
                if (NumberOfChoices == 2)
                {
                    if (_value >= 51)
                    {
                        return ChoiceOne;
                    }
                    else
                    {
                        return ChoiceTwo;
                    }
                }
                if (NumberOfChoices == 3)
                {
                    if (_value >= 66)
                    {
                        return ChoiceOne;
                    }
                    else if (_value >= 33)
                    {
                        return ChoiceTwo;
                    }
                    else
                    {
                        return ChoiceThree;
                    }
                }
                if (NumberOfChoices == 4)
                {
                    if (_value >= 75)
                    {
                        return ChoiceOne;
                    }
                    else if (_value >= 50)
                    {
                        return ChoiceTwo;
                    }
                    else if (_value >= 25)
                    {
                        return ChoiceThree;
                    }
                    else
                    {
                        return ChoiceFour;
                    }
                }
                if (NumberOfChoices == 5)
                {
                    if (_value >= 80)
                    {
                        return ChoiceOne;
                    }
                    else if (_value >= 60)
                    {
                        return ChoiceTwo;
                    }
                    else if (_value >= 40)
                    {
                        return ChoiceThree;
                    }
                    else if (_value >= 20)
                    {
                        return ChoiceFour;
                    }
                    else
                    {
                        return ChoiceFive;
                    }
                }
                if (NumberOfChoices == 6)
                {
                    if (_value >= 83)
                    {
                        return ChoiceOne;
                    }
                    else if (_value >= 66)
                    {
                        return ChoiceTwo;
                    }
                    else if (_value >= 50)
                    {
                        return ChoiceThree;
                    }
                    else if (_value >= 33)
                    {
                        return ChoiceFour;
                    }
                    else if (_value >= 17)
                    {
                        return ChoiceFive;
                    }
                    else
                    {
                        return ChoiceSix;
                    }
                }
                if (NumberOfChoices == 7)
                {
                    if (_value >= 85)
                    {
                        return ChoiceOne;
                    }
                    else if (_value >= 71)
                    {
                        return ChoiceTwo;
                    }
                    else if (_value >= 57)
                    {
                        return ChoiceThree;
                    }
                    else if (_value >= 42)
                    {
                        return ChoiceFour;
                    }
                    else if (_value >= ((100 / 7) * 2))
                    {
                        return ChoiceFive;
                    }
                    else if (_value >= (100 / 7))
                    {
                        return ChoiceSix;
                    }
                    else
                    {
                        return ChoiceSeven;
                    }
                }
                if (NumberOfChoices == 8)
                {
                    if (_value >= ((100 / 8) * 7))
                    {
                        return ChoiceOne;
                    }
                    else if (_value >= ((100 / 8) * 6))
                    {
                        return ChoiceTwo;
                    }
                    else if (_value >= ((100 / 8) * 5))
                    {
                        return ChoiceThree;
                    }
                    else if (_value >= ((100 / 8) * 4))
                    {
                        return ChoiceFour;
                    }
                    else if (_value >= ((100 / 8) * 3))
                    {
                        return ChoiceFive;
                    }
                    else if (_value >= ((100 / 8) * 2))
                    {
                        return ChoiceSix;
                    }
                    else if (_value >= ((100 / 8) * 1))
                    {
                        return ChoiceSeven;
                    }
                    else
                    {
                        return ChoiceEight;
                    }
                }
                if (NumberOfChoices == 9)
                {
                    if (_value >= ((100 / 9) * 8))
                    {
                        return ChoiceOne;
                    }
                    else if (_value >= ((100 / 9) * 7))
                    {
                        return ChoiceTwo;
                    }
                    else if (_value >= ((100 / 9) * 6))
                    {
                        return ChoiceThree;
                    }
                    else if (_value >= ((100 / 9) * 5))
                    {
                        return ChoiceFour;
                    }
                    else if (_value >= ((100 / 9) * 4))
                    {
                        return ChoiceFive;
                    }
                    else if (_value >= ((100 / 9) * 3))
                    {
                        return ChoiceSix;
                    }
                    else if (_value >= ((100 / 9) * 2))
                    {
                        return ChoiceSeven;
                    }
                    else if(_value >= ((100 / 9) * 1))
                    {
                        return ChoiceEight;
                    }
                    else
                    {
                        return ChoiceNine;
                    }
                }
                if (NumberOfChoices == 10)
                {
                    if (_value >= ((100 / 10) * 9))
                    {
                        return ChoiceOne;
                    }
                    else if (_value >= ((100 / 10) * 8))
                    {
                        return ChoiceTwo;
                    }
                    else if (_value >= ((100 / 10) * 7))
                    {
                        return ChoiceThree;
                    }
                    else if (_value >= ((100 / 10) * 6))
                    {
                        return ChoiceFour;
                    }
                    else if (_value >= ((100 / 10) * 5))
                    {
                        return ChoiceFive;
                    }
                    else if (_value >= ((100 / 10) * 4))
                    {
                        return ChoiceSix;
                    }
                    else if (_value >= ((100 / 10) * 3))
                    {
                        return ChoiceSeven;
                    }
                    else if (_value >= ((100 / 10) * 2))
                    {
                        return ChoiceEight;
                    }
                    else if (_value >= ((100 / 10) * 1))
                    {
                        return ChoiceNine;
                    }
                    else
                    {
                        return ChoiceTen;
                    }
                }
                return "Error detected";
            }

        }
        #endregion

        public string ChoiceOne { get; set; }

        public string ChoiceTwo { get; set; }
        public string ChoiceThree { get; set; }
        public string ChoiceFour { get; set; }
        public string ChoiceFive { get; set; }
        public string ChoiceSix { get; set; }
        public string ChoiceSeven { get; set; }
        public string ChoiceEight { get; set; }
        public string ChoiceNine { get; set; }
        public string ChoiceTen { get; set; }


        #region Methods
        /// <summary>
        /// Roll the die: the value will be set to a random number
        /// between 1 and _noOfSides (both included).
        /// </summary>
        public void Roll()
        {
                while (NumberOfRolls > 0)
                {
                    Thread.Sleep(10); // This is needed for magical purposes...
                    _value = _generator.Next(_noOfSides) + 1;
                    if (ChoiceOne != null)
                    {
                        Console.WriteLine($"So what is it? {Return}");
                    }
                    NumberOfRolls--;
            }
        } 
        #endregion
    }
}
