using Moq;
using NUnit.Framework;
using System;

[TestFixture]
public class MathAbsTests
{
    [Test]
    [TestCase(3.4d)]
    [TestCase(-3.4d)]
    [TestCase(0d)]
    [TestCase(0.4d)]
    [TestCase(-0.4d)]
    [TestCase(55555.555d)]
    [TestCase(-23232.32323d)]
    public void MathFloorReturnCorectValue(double value)
    {
        var itemToReturn = value;
        if (value < 0)
        {
            itemToReturn *= -1;
        }

        var mock = new Mock<IMath>();
        mock.Setup(v => v.Abs(value)).Returns(itemToReturn);


        var expected = mock.Object.Abs(value);


        Assert.That(expected, Is.EqualTo(Math.Abs(value)));
    }
}