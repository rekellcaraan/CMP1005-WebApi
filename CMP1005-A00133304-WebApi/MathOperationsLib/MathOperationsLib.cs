namespace MathOperationsLib;

public class MathOperationsLib
{
    /// <summary>
    /// DIVIDE: Math operations for dividing 2 decimals
    /// </summary>
    /// <param name="dividend">Dividend decimal</param>
    /// <param name="divisor">Divisor decimal</param>
    /// <returns>Quotient of 2 decimals</returns>
    public static decimal Divide(decimal dividend, decimal divisor)
    {
        if (divisor == 0)
            throw new DivideByZeroException(); // Throws an exception is divisor is zero (0)

        return dividend / divisor;
    }

    /// <summary>
    /// MULTIPLY: Math operations for multiplying 1 or more decimal/integers
    /// </summary>
    /// <param name="factors">Factors separated by comma</param>
    /// <returns>Product of decimal or integers</returns>
    public static decimal Multiply(params decimal[] factors)
    {
        var product = 1m;
        foreach (decimal factor in factors)
            product *= factor; // iterate on all factors and multiply

        return product;
    }

    /// <summary>
    /// SUBTRACT: Math operations for subtracting 2 integers
    /// </summary>
    /// <param name="leftValue">Minuend</param>
    /// <param name="rightValue">Subtrahend</param>
    /// <returns>Difference between 2 integers</returns>
    public static int Subtract(int leftValue, int rightValue)
    {
        return leftValue - rightValue;
    }

    /// <summary>
    /// SUM: Math operations for adding 1 or more integers
    /// </summary>
    /// <param name="operands">Operands separated by comma</param>
    /// <returns>Sum of decimals or integers</returns>
    public static decimal Sum(params decimal[] operands)
    {
        var sum = 0m;
        foreach (decimal operand in operands)
            sum += operand; // iterate on all operands and sum it up

        return sum;
    }
}

