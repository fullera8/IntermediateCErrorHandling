using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the operation");
            string operation = Console.ReadLine().ToUpperInvariant();

            Console.WriteLine("Enter the second number");
            int num2 = int.Parse(Console.ReadLine());

            var calculator = new Calculator();
            try
            {
                int result = calculator.Calculate(num1, num2, operation);
                DisplayResult(result);
            }
            //conditional catch block
            //catch (ArgumentNullException ex) when (ex.ParamName == "operation") { Console.WriteLine($"Operation not provided. {ex}"); }
            //catch (ArgumentNullException ex) { Console.WriteLine($"An argument was null. {ex}"); }
            //catch (ArgumentOutOfRangeException ex) { Console.WriteLine($"Operation is not supported. {ex}"); }
            //catch (CalcOpNotSupportedException ex) { Console.WriteLine(ex); } <-----This is uneeded because the base is derrived from the base which we still call
            catch (CalculationException ex) { Console.WriteLine(ex); }
            catch (Exception ex) { Console.WriteLine($"Something went wrong. {ex}"); }
            finally
            {
                Console.WriteLine("...finally...");
            }
           

            Console.WriteLine("\nPress enter to exit...");
            Console.ReadLine();
        }

        private static void DisplayResult(int result)
        {
            Console.WriteLine($"Result is: {result}");
        }
    }
}
