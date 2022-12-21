﻿namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Programs!");
            Console.WriteLine("\n1. Flip Coin Percentages.\n2. Leap Year\n3. Power Of Two.\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    //Q1. Flip Coin and percentage of Heads and Tails.
                    FlipCoinPercentage flipCoin = new FlipCoinPercentage();
                    flipCoin.FlipCoinPercentageFn();
                break;
                case 2:
                    //Q2 . Leap Year
                    LeapYear leapyear = new LeapYear();
                    leapyear.LeapYearFn();
                break;
                    case 3:
                    //Power of 2
                    PowerOfTwo powerOfTwo = new PowerOfTwo();
                    powerOfTwo.PowerOfTwoFn();
                    break;
                default:
                    Console.WriteLine("Choose from given options only!");
                break;
            }

        }
    }
}