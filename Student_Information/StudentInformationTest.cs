using System;

namespace Student_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeting();
        }

        public static void Greeting()
        {
            string userChoice = "y";
            do
            {
                Console.WriteLine("Enter the number or name of the student you want to learn about! 1-10");
                int studentNumber = StudentInputReader();

                Console.WriteLine($"Student {studentNumber} is {StudentInformation.students[studentNumber - 1]}.");
                StudentChooser(studentNumber);

                Console.Write("Would you like to learn about another student?\n");
                userChoice = Console.ReadLine().ToLower();

            } while (userChoice == "y");
            Console.WriteLine("Thanks, have a great day!");
        }

        public static void StudentChooser(int studentNumber)
        {
            string userKnowMore = "y";
            do
            {
                if (StudentInformation.Validator(studentNumber))
                {
                    Console.WriteLine("What would you like to learn about them? \nEnter: \n1. " +
                        "For hometown \n2. For favorite food  \n3. For number of plants\n");
                    int extraChoice = int.Parse(Console.ReadLine());

                    StudentInformation student1 = new StudentInformation(studentNumber, extraChoice);
                    Console.WriteLine(student1.StudentExtraInfo());

                    Console.WriteLine("Would you like to know more about this student? y/n");
                    userKnowMore = Console.ReadLine().ToLower();
                }
                else
                {
                    Console.WriteLine("Invalid number");
                }
            } while (userKnowMore == "y");
        }

        public static int StudentInputReader()
        {
            while (true)
            {
                string userInput = Console.ReadLine().ToLower();

                try
                {
                    return int.Parse(userInput);
                }
                catch (Exception)
                {
                    int studentIndex = StudentInformation.StudentIndex(userInput);
                    if (studentIndex != -1)
                    {
                        return studentIndex;
                    }
                    Console.WriteLine("Invalid. Enter a number from 1-10 or the student's first name.");
                }  
            }  
        }
    }
}
