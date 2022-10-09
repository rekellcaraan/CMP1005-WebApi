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
    // When dividing a small positive number by a large negative number then the quotient is a negative number
    public void WhenDividingASmallPositiveNumberByALargeNegativeNumber_ThenQuotientIsANegativeNumber()
    {
        var actualQuotient = MathOperationsLib.Divide(-2,11);
        var expectedQuotient = (decimal) -2m / 11m;
        Assert.AreEqual(expectedQuotient, actualQuotient);
        Assert.IsTrue(actualQuotient < 0);
    }
}
