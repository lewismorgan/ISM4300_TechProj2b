using System;

namespace TechProj2b
{
    class Program
    {
        static void Main(string[] args)
        {

            bool exit = false;

            while (!exit)
            {
                promptGrade();
                Console.WriteLine("Press the \'R\' key to rerun the program, any other key will exit");
                var key = Console.ReadKey();
                if (key.KeyChar == 'r' || key.KeyChar == 'R')
                {
                    // Restart the loop to continue asking for a grade, this will prevent it from smushing against the 'y' key that was entered
                    Console.WriteLine();
                }
                else
                {
                    exit = true;
                }
            }
        }

        static void promptGrade()
        {
            Console.WriteLine("What grade do you expect to receive in the class?");

            string entry = Console.ReadLine();

            int expectedGrade;

            if (int.TryParse(entry, out expectedGrade))
            {
                // The parse was successful, print the users grade from the grading scale range
                if (expectedGrade >= 93)
                {
                    writeGrade("A");
                }
                else if (expectedGrade >= 90 && expectedGrade <= 92)
                {
                    writeGrade("A-");
                }
                else if (expectedGrade >= 87 && expectedGrade <= 89)
                {
                    writeGrade("B+");
                }
                else if (expectedGrade >= 83 && expectedGrade <= 86)
                {
                    writeGrade("B");
                }
                else if (expectedGrade >= 80 && expectedGrade <= 82)
                {
                    writeGrade("B-");
                }
                else if (expectedGrade >= 77 && expectedGrade <= 79)
                {
                    writeGrade("C+");
                }
                else if (expectedGrade >= 73 && expectedGrade <= 76)
                {
                    writeGrade("C");
                }
                else if (expectedGrade >= 70 && expectedGrade <= 72)
                {
                    writeGrade("C-");
                }
                else if (expectedGrade >= 67 && expectedGrade <= 69)
                {
                    writeGrade("D+");
                }
                else if (expectedGrade >= 63 && expectedGrade <= 66)
                {
                    writeGrade("D");
                }
                else if (expectedGrade >= 60 && expectedGrade <= 62)
                {
                    writeGrade("D-");
                }
                else if (expectedGrade >= 0 && expectedGrade <= 59)
                {
                    writeGrade("F");
                }
                else if (expectedGrade < 0)
                {
                    Console.WriteLine("Yikes, I didn\'t know getting less than a 0 was possible");
                }
            }
            else
            {
                Console.WriteLine("Please enter a integer greater than or equal to 0");
            }
        }

        static void writeGrade(string grade)
        {
            Console.WriteLine("You will get a " + grade);
        }
    }
}
