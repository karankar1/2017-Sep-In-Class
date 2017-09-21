﻿using System;

namespace AssortedItems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Basic calculation examples
            //TimeConversions(); 

            // Converting Strings to Numbers
            //StringConversions();

            // Formatting output
            //FormatDemo();

            // Casting
            char digit = '5';
            Console.WriteLine(digit);
            int casted = (int)digit;
            //           \   /
            //          "Casting"
            Console.WriteLine(casted);

            double anotherCast = (double)digit;
            Console.WriteLine(anotherCast);

            Console.WriteLine((float)digit);

            Console.WriteLine((int)3.14159);
        } // end of Main()

        public static void FormatDemo()
        {
            int yea = 245, nay = 12, abstain = 3;

            Console.WriteLine($"yes     {yea,5}");
            Console.WriteLine($"no      {nay,5}");
            Console.WriteLine($"abstain {abstain,5}");

            string candidate1, candidate2, candidate3;
            Console.WriteLine("Enter three names:");
            candidate1 = Console.ReadLine();
            candidate2 = Console.ReadLine();
            candidate3 = Console.ReadLine();
            // Hmm... could we get some random numbers?
            Random rnd = new Random(); // make a random number generator
            int vote1, vote2, vote3;
            vote1 = rnd.Next(200);
            vote2 = rnd.Next(200);
            vote3 = rnd.Next(200);

            Console.WriteLine($"{candidate1,-15} - {vote1,4}");
            Console.WriteLine($"{candidate2,-15} - {vote2,4}");
            Console.WriteLine($"{candidate3,-15} - {vote3,4}");

            // Here's a demo about currency....
            Console.Write("How many items (3.95 each): ");
            int quantity = int.Parse(Console.ReadLine());

            double total = 3.95 * quantity;
            Console.WriteLine($"The total is {total,12:C}");
        }

        public static void StringConversions()
        {
            string userInput;

            Console.Write("Enter a whole number: ");
            userInput = Console.ReadLine(); // gets TEXT from the user

            int wholeNumber = int.Parse(userInput);
            Console.WriteLine($"Times 10, that would be {wholeNumber * 10}");


            Console.Write("\n\nEnter the value for PI: ");
            double pi = double.Parse(Console.ReadLine());
            //                       \ get user input /
            //          \    convert the input to ##.# /
            Console.WriteLine($"PI is {pi}");
            Console.WriteLine($"PI is {Math.PI}");
        }


        public static void TimeConversions()
        {
            int totalSeconds, seconds, hours, minutes;
            // Convert total seconds to hours/minutes/seconds
            totalSeconds = 36789; // off the top of my head....
            hours = totalSeconds / (60 * 60); // leverage integer division
            minutes = (totalSeconds - (hours * 3600)) / 60;
            //    or  (totalSeconds % 3600) / 60
            seconds = totalSeconds % 60;

            string results;
            results = $"{totalSeconds} total seconds --> {hours} hrs, {minutes} min, {seconds} sec";
            Console.WriteLine(results);

            // Convert hours/minutes/seconds to totals seconds
            hours = 12;
            minutes = 16;
            seconds = 34;

            totalSeconds = hours * 3600
                         + minutes * 60
                         + seconds;

            results = $"{totalSeconds} total seconds --> {hours} hrs, {minutes} min, {seconds} sec";
            Console.WriteLine(results);
        }

    } // end of Program class
} // end of namespace
