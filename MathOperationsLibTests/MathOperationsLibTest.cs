// A00133304
// 7 Oct 2022

namespace MathOperationsLibTests;
using MathOperationsLib;

[TestClass]
// Tests for all Math Operations
public class MathOperationsLibTest
{
    [TestMethod]
    // When adding a two positive integers then the sum is a positive integer
    public void WhenAdding2PositiveIntegers_ThenSumIsAPositiveInteger()
    {
        var actualSum = MathOperationsLib.Sum(11, 2);
        var expectedSum = 11 + 2;
        Assert.AreEqual(expectedSum, actualSum);
        Assert.IsTrue(actualSum > 0);
    }

    [TestMethod]
    // When adding multiple positive integers then the sum is a positive integer
    public void WhenAddingMultiplePositiveIntegers_ThenSumIsAPositiveInteger()
    {
        var actualSum = MathOperationsLib.Sum(1, 2, 3, 4, 5);
        var expectedSum = 1 + 2 + 3 + 4 + 5;
        Assert.AreEqual(expectedSum, actualSum);
        Assert.IsTrue(actualSum > 0);
    }

    [TestMethod]
    // When its an Addition Identity Property then the sum is always the number itself
    public void WhenIdentityPropertyOfAddition_ThenSumIsTheNumberItself()
    {
        var actualSum = MathOperationsLib.Sum(11,0);
        var expectedSum = 11;
        Assert.AreEqual(expectedSum, actualSum);
    }

    [TestMethod]
    // Using a datarow, when adding a large positive integer and a small negative integer
    // then the difference is a positive integer
    [DataRow(11,-10)]
    public void WhenAddingALargePositiveAndASmallNegativeInteger_ThenDifferenceIsAPositiveInteger(int largeInteger, int smallInteger)
    {
        var actualSum = MathOperationsLib.Sum(largeInteger, smallInteger);
        var expectedSum = largeInteger + smallInteger;
        Assert.AreEqual(expectedSum, actualSum);
        Assert.IsTrue(actualSum > 0);
        Assert.IsTrue(largeInteger > smallInteger);
        Assert.IsTrue(smallInteger < 0);
    }

    [TestMethod]
    // Using a datarow, when adding a small positive integer and a large negative integer
    // then the difference is a negative integer
    [DataRow(11, -12)]
    public void WhenAddingASmallPositiveAndALargeNegativeInteger_ThenDifferenceIsANegativeInteger(int smallInteger, int largeInteger)
    {
        var actualSum = MathOperationsLib.Sum(largeInteger, smallInteger);
        var expectedSum = largeInteger + smallInteger;
        Assert.AreEqual(expectedSum, actualSum);
        Assert.IsTrue(actualSum < 0);
        Assert.IsTrue(largeInteger < smallInteger);
        Assert.IsTrue(smallInteger > 0);
    }
}
