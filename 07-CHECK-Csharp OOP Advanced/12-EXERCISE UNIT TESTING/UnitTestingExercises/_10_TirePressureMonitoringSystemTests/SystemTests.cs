using Moq;
using NUnit.Framework;
using System.Linq;
using System.Reflection;

[TestFixture]
public class SystemTests
{

    [Test]
    [TestCase(-11d)]
    [TestCase(0d)]
    [TestCase(16.9d)]
    [TestCase(21.1d)]
    [TestCase(122d)]
    public void AlarmSetOfCorectly(double value)
    {
        var sensor = new Mock<Sensor>();
        sensor.Setup(p => p.PopNextPressurePsiValue()).Returns(value);

        var alarm = new Alarm();
        var field = typeof(Alarm).GetFields(BindingFlags.NonPublic | BindingFlags.Instance).FirstOrDefault(f => f.FieldType == typeof(Sensor));
        field.SetValue(alarm, sensor.Object);

        alarm.Check();
        Assert.That(alarm.AlarmOn, Is.True);

    }

    [Test]
    [TestCase(17d)]
    [TestCase(20d)]
    [TestCase(21d)]
    public void AlarmDidntSetOfCorectly(double value)
    {
        var sensor = new Mock<Sensor>();
        sensor.Setup(p => p.PopNextPressurePsiValue()).Returns(value);

        var alarm = new Alarm();
        var field = typeof(Alarm).GetFields(BindingFlags.NonPublic | BindingFlags.Instance).FirstOrDefault(f => f.FieldType == typeof(Sensor));
        field.SetValue(alarm, sensor.Object);

        alarm.Check();
        Assert.That(alarm.AlarmOn, Is.False);

    }
}