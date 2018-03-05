using System;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

namespace DiceGame
{
    public class InsertCodeHere
    {
        public int TypeChoice { get; set; } 
        public void MyCode()
        {
            Console.WriteLine("Write 1 for Warhammer or 2 for A-10");
            TypeChoice = Convert.ToInt32(Console.ReadLine());

            if (TypeChoice == 2)
            {
            DieNSides d100 = new DieNSides(100);


            Console.WriteLine("Input number of options (2-10)");
            d100.NumberOfChoices = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many times do you want to roll?");
            d100.NumberOfRolls = Convert.ToInt32(Console.ReadLine());


            switch (d100.NumberOfChoices)
            {
                case 2:
                    ChoiceOne(d100);
                    ChoiceTwo(d100);
                    break;
                case 3:
                    ChoiceOne(d100);
                    ChoiceTwo(d100);
                    ChoiceThree(d100);
                    break;
                case 4:
                    ChoiceOne(d100);
                    ChoiceTwo(d100);
                    ChoiceThree(d100);
                    ChoiceFour(d100);
                    break;
                case 5:
                    ChoiceOne(d100);
                    ChoiceTwo(d100);
                    ChoiceThree(d100);
                    ChoiceFour(d100);
                    ChoiceFive(d100);
                    break;
                case 6:
                    ChoiceOne(d100);
                    ChoiceTwo(d100);
                    ChoiceThree(d100);
                    ChoiceFour(d100);
                    ChoiceFive(d100);
                    ChoiceSix(d100);
                    break;
                case 7:
                    ChoiceOne(d100);
                    ChoiceTwo(d100);
                    ChoiceThree(d100);
                    ChoiceFour(d100);
                    ChoiceFive(d100);
                    ChoiceSix(d100);
                    ChoiceSeven(d100);
                    break;
                case 8:
                    ChoiceOne(d100);
                    ChoiceTwo(d100);
                    ChoiceThree(d100);
                    ChoiceFour(d100);
                    ChoiceFive(d100);
                    ChoiceSix(d100);
                    ChoiceSeven(d100);
                    ChoiceEight(d100);
                    break;
                case 9:
                    ChoiceOne(d100);
                    ChoiceTwo(d100);
                    ChoiceThree(d100);
                    ChoiceFour(d100);
                    ChoiceFive(d100);
                    ChoiceSix(d100);
                    ChoiceSeven(d100);
                    ChoiceEight(d100);
                    ChoiceNine(d100);
                    break;
                case 10:
                    ChoiceOne(d100);
                    ChoiceTwo(d100);
                    ChoiceThree(d100);
                    ChoiceFour(d100);
                    ChoiceFive(d100);
                    ChoiceSix(d100);
                    ChoiceSeven(d100);
                    ChoiceEight(d100);
                    ChoiceNine(d100);
                    ChoiceTen(d100);
                    break;
                default:
                    Console.WriteLine("Sorry, you have to enter a number from 2 to 10!");
                    break;
            }
        

             d100.Roll();
            }
            else if (TypeChoice == 1)
            {
                DieWH wh = new DieWH();
                Console.WriteLine("How many attacks?");
                wh.Attacks = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the To Hit? (Hit this or higher)");
                wh.ToHit = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the Wound Characteristic? (Hit this or higher)");
                wh.ToWound = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the Save Characteristic? (Hit less than this)");
                wh.SaveChar = Convert.ToInt32(Console.ReadLine());
                while(wh.Attacks > 0)
                {
                    wh.Roll();
                    Console.WriteLine($"Doing attack roll for {wh.Return}");
                    if (wh.Return >= wh.ToHit)
                    {
                        wh.DidHit++;
                        Console.WriteLine($"Hit added, now at {wh.DidHit}");
                    }
                    wh.Attacks--;
                }
                Console.WriteLine($"\nA total of {wh.DidHit} attacks hit for {wh.ToHit} or more\n");
                while (wh.DidHit > 0)
                {
                    wh.Roll();
                    Console.WriteLine($"Doing wound roll for {wh.Return}");
                    if (wh.Return >= wh.ToWound)
                    {
                        wh.Wounds++;
                        Console.WriteLine($"Wound added, now at {wh.Wounds}");
                    }
                    wh.DidHit--;
                }
                Console.WriteLine($"\nA total of {wh.Wounds} wounds hit for {wh.ToWound} or more\n");
                while (wh.Wounds > 0)
                {
                    wh.Roll();
                    Console.WriteLine($"Doing save roll for {wh.Return}");
                    if (wh.Return < wh.SaveChar)
                    {
                        wh.AmountSixes++;
                        Console.WriteLine($"You took a wound, now at {wh.AmountSixes}");
                    }
                    wh.Wounds--;
                }
                Console.WriteLine($"\nYou took {wh.AmountSixes} wounds from that attack\n");


            }


            // The LAST line of code should be ABOVE this line
        }
        private static void ChoiceOne(DieNSides d100)
        {
            Console.WriteLine("Input first option");
            d100.ChoiceOne = Console.ReadLine();
        }
        private static void ChoiceTwo(DieNSides d100)
        {
            Console.WriteLine("Input second option");
            d100.ChoiceTwo = Console.ReadLine();
        }

        private static void ChoiceThree(DieNSides d100)
        {
            Console.WriteLine("Input third option");
            d100.ChoiceThree = Console.ReadLine();
        }

        private static void ChoiceFour(DieNSides d100)
        {
            Console.WriteLine("Input fourth option");
            d100.ChoiceFour = Console.ReadLine();
        }

        private static void ChoiceFive(DieNSides d100)
        {
            Console.WriteLine("Input fifth option");
            d100.ChoiceFive = Console.ReadLine();
        }

        private static void ChoiceSix(DieNSides d100)
        {
            Console.WriteLine("Input sixth option");
            d100.ChoiceSix = Console.ReadLine();
        }

        private static void ChoiceSeven(DieNSides d100)
        {
            Console.WriteLine("Input seventh option");
            d100.ChoiceSeven = Console.ReadLine();
        }

        private static void ChoiceEight(DieNSides d100)
        {
            Console.WriteLine("Input eigth option");
            d100.ChoiceEight = Console.ReadLine();
        }

        private static void ChoiceNine(DieNSides d100)
        {
            Console.WriteLine("Input ninth option");
            d100.ChoiceNine = Console.ReadLine();
        }

        private static void ChoiceTen(DieNSides d100)
        {
            Console.WriteLine("Input tenth option");
            d100.ChoiceTen = Console.ReadLine();
        }


    }
}