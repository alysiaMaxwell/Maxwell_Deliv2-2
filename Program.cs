using System;

namespace Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ask the user what grade they expect to recieve in the class 

            Console.WriteLine("What grade do you expect to get in ISM4300?");
           
            // Validate users response is an integer and not a character 

            try
            {
                // This variable will gather data from user input

                string input = Console.ReadLine();

                // This variable will be used to translate the integer input into a letter grade for the user 

                int grade = int.Parse(input);

                // Evaluate user input and give corresponding letter grade 

                if ((grade > 98))
                {
                    Console.WriteLine("The letter grade you will recieve is A+");
                }
                else if ((grade < 98) && (grade >= 92))
                {
                    Console.WriteLine("The letter grade you will recieve is A");
                }
                else if ((grade < 92) && (grade >= 90))
                {
                    Console.WriteLine("The letter grade you will recieve is A-");
                }
                else if ((grade < 90) && (grade >= 88))
                {
                    Console.WriteLine("The letter grade you will recieve is B+");
                }
                else if ((grade < 88) && (grade >= 82))
                {
                    Console.WriteLine("The letter grade you will recieve is B");
                }
                else if ((grade < 82) && (grade >= 80))
                {
                    Console.WriteLine("The letter grade you will recieve is B-");
                }
                else if ((grade < 80) && (grade >= 78))
                {
                    Console.WriteLine("The letter grade you will recieve is C+");
                }
                else if ((grade < 78) && (grade >= 72))
                {
                    Console.WriteLine("The letter grade you will recieve is C");
                }
                else if ((grade < 72) && (grade >= 70))
                {
                    Console.WriteLine("The letter grade you will recieve is C-");
                }
                else if ((grade < 70) && (grade >= 68))
                {
                    Console.WriteLine("The letter grade you will recieve is D+");
                }
                else if ((grade < 68) && (grade >= 62))
                {
                    Console.WriteLine("The letter grade you will recieve is D");
                }
                else if ((grade < 62) && (grade >= 60))
                {
                    Console.WriteLine("The letter grade you will recieve is D-");
                }
                else
                {
                    Console.WriteLine("The letter grade you will recieve is F, you will have to take this class again!");
                }

            }
            catch
            {
                Console.WriteLine("Invalid input, please enter and integer and try again.");
            }
        }
    }
}
