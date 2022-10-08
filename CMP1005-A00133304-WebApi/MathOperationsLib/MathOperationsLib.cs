﻿namespace MathOperationsLib;

public class MathOperationsLib
{
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
    /// <returns>Sum of integers</returns>
    public static int Sum(params int[] operands)
    {
        var sum = 0;
        foreach (int operand in operands)
            sum += operand; // iterate on all operands and sum it up

        return sum;
    }
}

