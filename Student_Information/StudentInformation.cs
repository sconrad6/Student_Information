using System;
namespace Student_Information
{ 
    public class StudentInformation
    {
        private readonly int studentNumber;
        private readonly int extraChoice;
        public static string[] students = { "Bob", "Bill", "Nate", "Joe", "Stefan", "McKenna", "LeoJohn", "Ann", "Carmen", "Ryan" };
        private string[] hometowns = {"Gilmington", "Exeter", "Brentwood", "Altoona", "Ann Arbor", "Altoona", "Stratham", "Stratham",
                                   "Canton", "Colchester" };
        private string[] foods = {"carrots", "cucumbers", "chips", "pasta", "hummus", "cauliflower rice", "doughnuts", "chocolate",
                              "noodles", "bread" };
        private string[] plants = { "3", "4", "6", "45", "100", "0", "10", "8", "2", "7" };


        public StudentInformation(int studentNumber, int extraChoice)
        {
            this.studentNumber = studentNumber - 1;
            this.extraChoice = extraChoice;
        }

        public string StudentExtraInfo()
        {
            switch (extraChoice)
            {
                case 1:
                    return $"{students[studentNumber]} is from {hometowns[studentNumber]}.";
                case 2:
                    return $"{students[studentNumber]}'s favorite food is {foods[studentNumber]}.";
                case 3:
                    return $"{students[studentNumber]} has {plants[studentNumber]} plants.";
                default:
                    return "Invalid number";
            }
        }

        public static int StudentIndex(string userInput)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (userInput == students[i].ToLower())
                {
                    return i + 1;
                }
            }
            return -1;
        }
    
        // validates that the user has entered a number between 1 and 10
        public static bool Validator(int userNumber)
        {
            return userNumber > 0 && userNumber <= 10;
        }
      
    }
}
