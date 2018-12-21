using Moq;
using NUnit.Framework;
using System;

[TestFixture]
public class MathFloorTests
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
        int itemToReturn = (int)value;
        if (value<0)
        {
            itemToReturn -= 1;
        }

        var mock = new Mock<IMath>();
        mock.Setup(v => v.Floor(value)).Returns(itemToReturn);
         

        var expected = mock.Object.Floor(value);


        Assert.That(expected, Is.EqualTo(Math.Floor(value)));
    }

}