using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculator
{
    public class Calculator
    {
        /// <summary>
        /// calculates the math of the numbers provided depending on the operator and the 2 numbers provided.
        /// </summary>
        /// <param name="num1">number to the left of the operator</param>
        /// <param name="num2">number to the right of the operator</param>
        /// <param name="operation">operator</param>
        /// <returns>The result of the mathematic operation</returns>
        public int Calculate(int num1, int num2, string operation)
        {

            //throw new ArgumentNullException(nameof(num1));
            
            //Conditional check for nulls with exception for case that the user input cannot make null.
            var nonNullOperation = operation ?? throw new ArgumentNullException(nameof(operation));

            //Old style conditional check
            //if (operation is null)
            //    throw new ArgumentNullException(nameof(operation));

            if (nonNullOperation == "/")
            {
                try
                {
                    return Divide(num1, num2);
                }
                catch (ArithmeticException ex)
                {
                    throw new CalculationException("An Error occured during division", ex);
                    
                    //log error
                    //throw
                    //throw new ArithmeticException("Error during calculation.", ex);
                }
            }
            else
            {
                throw new CalcOpNotSupportedException(operation);
                //throw new ArgumentOutOfRangeException(nameof(operation),"The mathematical operator is not supported.");
                //Console.WriteLine("Unknown Operation.");
                //return 0;
            }
        }

        /// <summary>
        /// Divides the numbers provided
        /// </summary>
        /// <param name="num1">numerator</param>
        /// <param name="num2">Denominator</param>
        /// <returns>Returns the quotient to the nearest whole number</returns>
        private int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
