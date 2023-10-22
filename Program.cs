using System;

class Program
{
     static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter an integer: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number < 0)
            {
                throw new ArgumentException("Negative number is not allowed.");
            }

            double squareRoot = Math.Sqrt(number);
            Console.WriteLine($"Square root of {number} is {squareRoot}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number. Please enter a valid integer.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Good bye.");
        }
    }
}