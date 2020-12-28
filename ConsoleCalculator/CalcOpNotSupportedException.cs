using System;
namespace ConsoleCalculator
{
    public class CalcOpNotSupportedException : CalculationException
    {
        public string Operation { get; }

        /// <summary>
        /// Creates a new <see cref="CalcOpNotSupportedException"/> with a provided message.
        /// </summary>
        public CalcOpNotSupportedException() : base("Specified Operation was out of the range of valid values.")
        {
        }

        /// <summary>
        /// Creates a new <see cref="CalcOpNotSupportedException"/> with an operation that is not supported.
        /// </summary>
        public CalcOpNotSupportedException(string operation) : this()
        {
            Operation = operation;
        }

        /// <summary>
        /// Creates a new <see cref="CalcOpNotSupportedException"/> with a user defined message and wrapped inner exception.
        /// </summary>
        public CalcOpNotSupportedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Creates a new <see cref="CalcOpNotSupportedException"/> with an operation that is not supported along with a user defined message.
        /// </summary>
        public CalcOpNotSupportedException(string operation, string message) : base(message)
        {
            Operation = operation;
        }

        public override string Message
        {
            get
            {
                string message = base.Message;

                if (Operation != null) return $"{message}{Environment.NewLine} Unsupported operation: {Operation}";
                return message;
            }
        }
    }
}
