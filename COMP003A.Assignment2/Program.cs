/*
 * Author: James Limos
 * Course: COMP-003A
 * Faculty: Jonathan Cruz
 * Purpose: A program that acts as a discount calculator.
 */
// Namespace level
namespace COMP003A.Assignment2
{
    internal class Program
    {
        // Main level
        static void Main(string[] args)
        {
            string firstname;
            string secondname;
            int useage;
            double productprice;
            bool isStudent; 

            Console.Write("Enter your first name: ");
            firstname = Console.ReadLine();

            Console.WriteLine("Enter your last name: ");
            secondname = Console.ReadLine();

            Console.Write("Enter your age: ");
            useage = int.Parse(Console.ReadLine());

            Console.Write("What is the price of the item you’re interested in?: ");
            productprice = double.Parse(Console.ReadLine());

            Console.Write("Are you a student? (true/false)");
            isStudent = bool.Parse(Console.ReadLine());

            int futureage = useage + 5;

            Console.WriteLine($"\nHello, {firstname} {secondname}!");
            Console.WriteLine($"You are currently {useage} years old. In 5 years, you will be {futureage}.");
            Console.WriteLine($"The original price of the item is {productprice:C}"); 

        }
    }
}
