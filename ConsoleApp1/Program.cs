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
            string userName;
            int userAge;
            double productPrice;
            bool isStudent;

            Console.Write("Enter your name: ");
            userName = Console.ReadLine();

            Console.Write("Enter your age: ");
            userAge = int.Parse(Console.ReadLine());

            Console.Write("Enter the price of a product: ");
            productPrice = double.Parse(Console.ReadLine());

            Console.Write("Are you a student? (true/false): ");
            isStudent = bool.Parse(Console.ReadLine());

            Console.WriteLine("Hello, World!");
        }
    }
}
