namespace MathOperationsLib;

public class MathOperationsLib
{
    /// <summary>
    /// SUM: Math operations for adding 1 or more integers
    /// </summary>
    /// <param name="operands">Operands separated by comma</param>
    /// <returns>Sum of integers</returns>
    public static int Sum(params int[] operands)
    {
        var sum = 0;
        foreach (int operand in operands)
            sum += operand; // iterate on all operands and sum it up

        return sum;
    }
}

