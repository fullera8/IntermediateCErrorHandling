using System;


namespace ConsoleCalculator
{
    public class CalculationException : Exception
    {
        private static readonly string defaultMessage = "An error occurred during calculation. Ensure that the operator is supported and that the values are within the valid ranges for the requested operation.";

        /// <summary>
        /// Creates a new <see cref="CalculationException"/> with a predefined message
        /// </summary>
        public CalculationException() : base(defaultMessage)
        {
        }

        /// <summary>
        /// Creates a new <see cref="CalculationException"/> with a user-supplied message
        /// </summary>
        public CalculationException(string message) : base(message)
        {
        }

        /// <summary>
        /// Creates a new <see cref="CalculationException"/> with a predefined message and a wrapped inner exception
        /// </summary>
        public CalculationException(Exception innException) : base(defaultMessage, innException)
        {
        }

        /// <summary>
        /// Creates a new <see cref="CalculationException"/> with a user provided message and a wrapped inner exception
        /// </summary>
        public CalculationException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
