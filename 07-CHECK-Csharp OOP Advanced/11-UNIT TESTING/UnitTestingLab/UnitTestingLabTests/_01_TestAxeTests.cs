using NUnit.Framework;

public class _01_TestAxeTests
{
    [Test]
    public void AxeLossesDurabilityWhenAtacking()
    {
        var axe = new Axe(5, 10);
        var dummy = new Dummy(15, 20);

        axe.Attack(dummy);

        Assert.That(axe.DurabilityPoints, Is.EqualTo(9));
    }

    [Test]
    public void AtackWithBrokenWeapon()
    {
        var axe = new Axe(5, 0);
        var dummy = new Dummy(15, 20);

        Assert.That(() => axe.Attack(dummy), Throws.InvalidOperationException.With.Message.EqualTo("Axe is broken."));
    }
}