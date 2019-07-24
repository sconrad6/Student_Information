using System;

namespace Student_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string userChoice = "y";


            do
            {
                int studentNumber = Greeting();
                 
                string userKnowMore;
                do
                {
                    StudentChooser(studentNumber);

                    Console.WriteLine("Would you like to know more about this student? y/n");
                    userKnowMore = Console.ReadLine().ToLower();

                } while (userKnowMore == "y");

                Console.Write("Would you like to learn about another student?\n");
                userChoice = Console.ReadLine().ToLower();

            } while (userChoice == "y");

        } 

        public static int Greeting()
        {
            Console.WriteLine("Enter the number of the student you want to learn about! 1-10");
            int studentNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"Student  {studentNumber}  is  {StudentInformation.StudentNamesArray(studentNumber)}.");
            return studentNumber;
        }

        public static void StudentChooser(int studentNumber)
        {
            if (StudentInformation.StudentNamesArray(studentNumber) != null)
            {
                Console.WriteLine("What would you like to learn about them? \nEnter: \n1. For hometown \n2. For favorite food  \n3. For number of plants\n");
                int extraChoice = int.Parse(Console.ReadLine());

                StudentInformation student1 = new StudentInformation(studentNumber, extraChoice);

                Console.WriteLine(student1.StudentHometownArray());
                Console.WriteLine(student1.StudentFavoriteFood());
                Console.WriteLine(student1.StudentPlants());
            }
            else
            {
                Console.WriteLine("Invalid number");
            }

        }
    }
}
