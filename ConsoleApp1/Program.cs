/*
Author: Pedro Garcia
Course: COMP003A
Faculty: Jonathan Cruz
Purpose: COMP-003A - Lecture Actitvity
 */
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName; // Variable that stores user name
            int userAge; // Variable to store age
            double productPrice; // Variable that stores price of product
            bool isStudent; // Variable that stores whether the user is a student

            Console.Write("Enter your name: "); // Indicate to user to enter name
            userName = Console.ReadLine(); // takes the user input

            Console.Write("Enter your age: "); // Indicate to user to enter age
            userAge = int.Parse(Console.ReadLine()); // Takes the user's input

            Console.Write("Enter the price of a product: "); // Indicate to user to enter product price
            productPrice = double.Parse(Console.ReadLine()); // Takes the user's input

            Console.Write("Are you a student? (true/false): "); // indicate to user to tell whether they are a student or not
            isStudent = bool.Parse(Console.ReadLine()); // Takes the user's input

            int futureAge = userAge + 5; // Calculate user's age in 5 years
            bool isAdult = userAge >= 18; // Ensures whether user is 18 or older
            bool isAdultStudent = isStudent && isAdult; // Checks if user is a student and also an adult

            Console.WriteLine($"\nHello, {userName}"); // Greeting
            Console.WriteLine($"You are currently {userAge} years old. In 5 years, you will be {futureAge}."); // Shows current and future age
            Console.WriteLine($"Are you 18 or older? {isAdult}"); // Shows whether user is an adult
            Console.WriteLine($"Are you both a student and 18 or older? {isAdultStudent}"); // Shows if the user is a student and also an adult
        }
    }
}
