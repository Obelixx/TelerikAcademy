namespace Abstraction
{
    using System;

    public abstract class Figure
    {
        protected static bool IsPositiveNumber(double value)
        {
            return value > 0;
        }

        protected static void CheckForPositiveNumber(double value, string whatValue)
        {
            if (!IsPositiveNumber(value))
            {
                throw new ArgumentException(whatValue + " must be positive number.");
            }
        }
    }
}
