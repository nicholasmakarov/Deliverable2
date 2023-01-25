/*
 Author: Nicholas Makarov
Date: 1/24/2023
Desc: Deliverable 2 Calculating Letter Grades C# Console Application 
*/

using System;

namespace Deliverable_2_
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numerical grade: ");
            try
            {
                decimal grade = decimal.Parse(Console.ReadLine());

                string letter;

                if (grade >= 90)
                {
                    letter = "A";
                    Console.WriteLine("Your expected letter grade for ISM 4300  is: " + letter);
                }
                else if (grade >= 80 && grade < 90)
                {
                    letter = "B";
                    Console.WriteLine("Your expected letter grade for ISM 4300  is: " + letter);
                }
                else if (grade >= 70 && grade < 80)
                {
                    letter = "C";
                    Console.WriteLine("Your expected letter grade for ISM 4300  is: " + letter);
                }
                else if (grade >= 60 && grade < 70)
                {
                    letter = "D";
                    Console.WriteLine("Your expected letter grade for ISM 4300  is: " + letter);
                }
                else if (grade >= 0 && grade < 60)
                {
                    letter = "F";
                    Console.WriteLine("Your expected letter grade for ISM 4300  is: " + letter);
                }
            }

           catch
            {
                Console.WriteLine("Enter a numerical value");
            }
        }
    }
}