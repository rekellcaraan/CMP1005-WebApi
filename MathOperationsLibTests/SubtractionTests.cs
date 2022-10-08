// A00133304
// 7 Oct 2022

namespace MathOperationsLibTests;
using MathOperationsLib;

// Tests for all Math Operations - Subtraction
public partial class MathOperationsLibTest
{
    [TestMethod]
    // When subtracting a large positive number by a small number then the difference is a positive number
    public void WhenALargePositiveNumberSubtractedByASmallNumber_ThenDifferenceIsAPositiveNumber()
    {
        var largePositiveValue = 11;
        var smallValue = 2;
        var actualResult = MathOperationsLib.Subtract(largePositiveValue, smallValue);
        var expectedResult = largePositiveValue - smallValue;
        Assert.AreEqual(expectedResult, actualResult);
        Assert.IsTrue(actualResult > 0);
        Assert.IsTrue(largePositiveValue > smallValue);
    }

    [TestMethod]
    // When subtracting a small positive number by a large number then the difference is a negative number
    public void WhenASmallPositiveNumberSubtractedByALargeNumber_ThenDifferenceIsANegativeNumber()
    {
        var smallPositiveValue = 2;
        var largeValue = 11;
        var actualResult = MathOperationsLib.Subtract(smallPositiveValue, largeValue);
        var expectedResult = smallPositiveValue - largeValue;
        Assert.AreEqual(expectedResult, actualResult);
        Assert.IsTrue(actualResult < 0);
        Assert.IsTrue(largeValue > smallPositiveValue);
    }
}
