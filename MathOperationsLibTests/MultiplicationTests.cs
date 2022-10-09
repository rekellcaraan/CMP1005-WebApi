// A00133304
// 7 Oct 2022

namespace MathOperationsLibTests;
using MathOperationsLib;

// Tests for all Math Operations - Multiplication
public partial class MathOperationsLibTest
{
    [TestMethod]
    // When multiplying 2 positive numbers then the product is a positive number
    public void WhenMultiplying2PositiveNumbers_ThenProductIsAPositiveNumber()
    {
        var actualProduct = MathOperationsLib.Multiply(11, 2);
        var expectedProduct = 11 * 2;
        Assert.AreEqual(expectedProduct, actualProduct);
        Assert.IsTrue(actualProduct > 0);
    }

    [TestMethod]
    // When multiplying a positive number and a negative number then the product is a negative number
    public void WhenMultiplyingAPositiveNumberAndANegativeNumber_ThenProductIsANegativeNumber()
    {
        var actualProduct = MathOperationsLib.Multiply(11, -2);
        var expectedProduct = 11 * -2;
        Assert.AreEqual(expectedProduct, actualProduct);
        Assert.IsTrue(actualProduct < 0);
    }

    [TestMethod]
    // When multiplying multiple positive numbers with one or more negative numbers then the product is a negative number
    public void WhenMultiplyingManyPositiveNumbersAndANegativeNumber_ThenProductIsANegativeNumber()
    {
        var actualProduct = MathOperationsLib.Multiply(11, -2, 5, 9, 10);
        var expectedProduct = 11 * -2 * 5 * 9 * 10;
        Assert.AreEqual(expectedProduct, actualProduct);
        Assert.IsTrue(actualProduct < 0);
    }
}
