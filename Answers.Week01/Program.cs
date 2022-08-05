using System;

namespace Answers.Week01
{
    class Program
    {

        static void Main(string[] args)
        {
            #region Task-1
            //Printing out all even numbers until 40
            for (int i = 1; i < 40; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            #endregion
            #region Task-2
            //Declare an array of even and odd numbers 
            int[] numbers = { 11, 16, 19, 22, 28, 33, 37, 40, 51, 60 };
            //Create a variable to store the sum of the odd numbers in our array
            int sum = 0;
            //Loop to find out the sum of the odd numbers in our array
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    sum = sum + numbers[i];
                }
                
            }
            Console.WriteLine("Sum of all of the odd numbers in our array is " + sum);
            #endregion
            #region Task-3
            //Ask the user for the radius
            Console.WriteLine("Please provide a radius: ");
            //Store the radius in a variable
            double radius = Convert.ToDouble(Console.ReadLine());
            //Calaculate the perimeter of the circle
            double perimeter = 2 * 3.14 * radius;
            //Calculate the area of the circle
            double area = 3.14 * radius * radius;
            //Print the results to the console
            Console.WriteLine("The perimeter of our circle is " + perimeter);
            Console.WriteLine("The area of our circle is " + area);
            //Add a switch case (Bonus)
            switch(radius)
            {
                case 8:
                    Console.WriteLine("Congratulation! You guessed the correct radius, but there isn't any prize hahaha");
                    break;
                default:
                    Console.WriteLine("This is not a correct guess");
                    break;  
            }
            #endregion
        }
    }
}
