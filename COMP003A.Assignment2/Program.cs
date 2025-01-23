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
            string firstName;
            string secondName;
            int useage;
            double productPrice;
            bool isStudent; 

            Console.Write("Enter your first name: ");
            firstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            secondName = Console.ReadLine();

            Console.Write("Enter your age: ");
            useage = int.Parse(Console.ReadLine());

            Console.Write("What is the price of the item you’re interested in?: ");
            productPrice = double.Parse(Console.ReadLine());

            Console.Write("Are you a student? (true/false)? ");
            isStudent = bool.Parse(Console.ReadLine());

            int futureage = useage + 5;
            bool isSenior = useage == 60;
            double discount1 = isStudent ? productPrice * 0.9 : productPrice;
            double discount2 =  productPrice * 0.8;

            Console.WriteLine($"\nHello, {firstName} {secondName}!");
            Console.WriteLine($"You are currently {useage} years old. In 5 years, you will be {futureage}.");
            Console.WriteLine($"The original price of the item is {productPrice}"); 
            Console.WriteLine($"As a Student, your discounted price is {discount1}");
            Console.WriteLine($"As a senior citizen, your discounted price would be {discount2}");



        }
    }
}
