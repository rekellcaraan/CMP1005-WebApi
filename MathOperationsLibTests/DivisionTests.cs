// A00133304
// 7 Oct 2022

namespace MathOperationsLibTests;
using MathOperationsLib;

// Tests for all Math Operations - Division
public partial class MathOperationsLibTest
{
    [TestMethod]
    // When dividing a large positive number by a small negative number then the quotient is a negative number
    public void WhenDividingALargePositiveNumberByASmallNegativeNumber_ThenQuotientIsANegativeNumber()
    {
        var actualQuotient = MathOperationsLib.Divide(11, -2);
        var expectedQuotient =(decimal) 11m / -2m;
        Assert.AreEqual(expectedQuotient, actualQuotient);
        Assert.IsTrue(actualQuotient < 0);
    }

    [TestMethod]
    // When dividing a large positive number by a small positive number then the quotient is a positive number
    public void WhenDividingALargePositiveNumberByASmallPositiveNumber_ThenQuotientIsAPositiveNumber()
    {
        var actualQuotient = MathOperationsLib.Divide(11, 2);
        var expectedQuotient = (decimal)11m / 2m;
        Assert.AreEqual(expectedQuotient, actualQuotient);
        Assert.IsTrue(actualQuotient > 0);
    }

    [TestMethod]
    // When dividing a small positive number by a large negative number then the quotient is a negative number
    public void WhenDividingASmallPositiveNumberByALargeNegativeNumber_ThenQuotientIsANegativeNumber()
    {
        var actualQuotient = MathOperationsLib.Divide(-2,11);
        var expectedQuotient = (decimal) -2m / 11m;
        Assert.AreEqual(expectedQuotient, actualQuotient);
        Assert.IsTrue(actualQuotient < 0);
    }

    [TestMethod]
    // When dividing a small positive number by a large positive number then the quotient is a positive number
    public void WhenDividingASmallPositiveNumberByALargePositiveNumber_ThenQuotientIsAPositiveNumber()
    {
        var actualQuotient = MathOperationsLib.Divide(2, 11);
        var expectedQuotient = (decimal)2m / 11m;
        Assert.AreEqual(expectedQuotient, actualQuotient);
        Assert.IsTrue(actualQuotient > 0);
    }

    [TestMethod]
    // When dividing any number by zero then throw an exception of DividingByZeroException
    public void WhenDividingByZero_ThenThrowDivisionByZeroException()
    {
        Assert.ThrowsException<DivideByZeroException>(() => MathOperationsLib.Divide(2, 0));
    }

    [TestMethod]
    // When dividing zero by a negative number then the quotient is always zero
    public void WhenDividingZeroByANegativeNumber_ThenQuotientIsZero()
    {
        var actualQuotient = MathOperationsLib.Divide(0, -2);
        Assert.AreEqual(0, actualQuotient);
    }

    [TestMethod]
    // When dividing zero by a positive number then the quotient is always zero
    public void WhenDividingZeroByAPositiveNumber_ThenQuotientIsZero()
    {
        var actualQuotient = MathOperationsLib.Divide(0, 2);
        Assert.AreEqual(0, actualQuotient);
    }
}
