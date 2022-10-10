// A00133304
// 7 Oct 2022

namespace MathOperationsLibTests;
using MathOperationsLib;

// Tests for all Math Operations - Multiplication
public partial class MathOperationsLibTest
{
    [TestMethod]
    // When multiplying 2 positive integers then the product is a positive integer
    public void WhenMultiplying2PositiveIntegers_ThenProductIsAPositiveInteger()
    {
        var actualProduct = MathOperationsLib.Multiply(11, 2);
        var expectedProduct = 11 * 2;
        Assert.AreEqual(expectedProduct, actualProduct);
        Assert.IsTrue(actualProduct > 0);
    }

    [TestMethod]
    // When multiplying a positive integer and a negative integer then the product is a negative integer
    public void WhenMultiplyingAPositiveIntegerAndANegativeInteger_ThenProductIsANegativeInteger()
    {
        var actualProduct = MathOperationsLib.Multiply(11, -2);
        var expectedProduct = 11 * -2;
        Assert.AreEqual(expectedProduct, actualProduct);
        Assert.IsTrue(actualProduct < 0);
    }

    [TestMethod]
    // When multiplying multiple positive integer with one or more negative integers then the product is a negative integer
    public void WhenMultiplyingManyPositiveIntegersAndANegativeNumber_ThenProductIsANegativeInteger()
    {
        var actualProduct = MathOperationsLib.Multiply(11, -2, 5, 9, 10);
        var expectedProduct = 11 * -2 * 5 * 9 * 10;
        Assert.AreEqual(expectedProduct, actualProduct);
        Assert.IsTrue(actualProduct < 0);
    }

    [TestMethod]
    // When multiplying 2 positive decimals then the product is a positive decimal
    public void WhenMultiplying2PositiveDecimal_ThenProductIsAPositiveDecimal()
    {
        var actualProduct = MathOperationsLib.Multiply(11.4m, 2.11m);
        var expectedProduct = 11.4m * 2.11m;
        Assert.AreEqual(expectedProduct, actualProduct);
        Assert.IsTrue(actualProduct > 0);
    }

    [TestMethod]
    // When multiplying a positive decimal and a negative decimal then the product is a negative decimal
    public void WhenMultiplyingAPositiveDecimalAndANegativeDecimal_ThenProductIsANegativeDecimal()
    {
        var actualProduct = MathOperationsLib.Multiply(11.22m, -2.11m);
        var expectedProduct = 11.22m * -2.11m;
        Assert.AreEqual(expectedProduct, actualProduct);
        Assert.IsTrue(actualProduct < 0);
    }

    [TestMethod]
    // When multiplying multiple positive decimals with one or more negative decimals then the product is a negative decimal
    public void WhenMultiplyingManyPositiveDecimalsAndANegativeDecimal_ThenProductIsANegativeDecimal()
    {
        var actualProduct = MathOperationsLib.Multiply(11.22m, -2.11m, 5.8m, 9.99m, 10.0m);
        var expectedProduct = 11.22m * -2.11m * 5.8m * 9.99m * 10.0m;
        Assert.AreEqual(expectedProduct, actualProduct);
        Assert.IsTrue(actualProduct < 0);
    }
}
