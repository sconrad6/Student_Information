using System;
namespace Student_Information
{ 
    public class StudentInformation
    {
        public readonly int studentNumber;
        public readonly int extraChoice;
        

        public StudentInformation(int studentNumber, int extraChoice)
        {
            this.studentNumber = studentNumber;
            this.extraChoice = extraChoice;
            
        }

        //stores an array of students and returns the number the user chose
        public static  string StudentNamesArray(int studentNumber)
        {
            string[] students = { "Bob", "Bill", "Nate", "Joe", "Stefan", "McKenna", "LeoJohn", "Ann", "Carmen", "Ryan",
                                  "Meredith", "Sam", "Lauren", "Sagar", "Savanah", "Leo", "Marie", "Paul", "Caleb", "Cailey"};
           
          if (Validator(studentNumber))
            {
                return students[studentNumber - 1];
            }
            return null;
        }

        // stores the city the people live in 

        public string StudentHometownArray()
        {
            string[] hometowns = {"Gilmington", "Exeter", "Brentwood", "Altoona", "Ann Arbor", "Altoona", "Stratham", "Stratham",
                                   "Canton", "Colchester", "Royal Oak", "New Lebanon", "Bangalore", "Ann Arbor", "Stratham",
                                   "Haverhill", "Haverhill", "Haverhill", "Haverhill"};
            if (extraChoice == 1)
            {
                return $"{StudentNamesArray(studentNumber)} is from {hometowns[studentNumber - 1]}.";
            }
            return null;
        }

        // stores the favorite food of the person
        public string StudentFavoriteFood()
        {
            string[] foods = {"carrots", "cucumbers", "chips", "pasta", "hummus", "cauliflower rice", "doughnuts", "chocolate",
                              "noodles", "bread", "stir fry", "veggie burgers", "oatmeal", "Indian food", "stir fry", "ice cream",
                               "peanuts", "V8", "pringles", "smoothies"};
            if (extraChoice == 2)
            {
                return $"{StudentNamesArray(studentNumber)}'s favorite food is {foods[studentNumber - 1]}.";

            }
            return null;
        }

        // stores the number of plants the person has
        public string StudentPlants()
        {
            string[] plants = { "3", "4", "6", "45", "1", "0", "10", "1", "2", "7", "3", "6", "3", "5", "7", "9", "2", "6", "9", "11" };
            if (extraChoice == 3)
            {
                return $"{StudentNamesArray(studentNumber)} has {plants[studentNumber - 1]} plants.";
            }
            return null;
        }

        // validates that the user has entered a number between 1 and 20
        public static bool Validator(int studentNumber)
        {
            if (studentNumber > 0 && studentNumber <= 20)
            {
                return true;
            }
            return false;
        }
    }
}
