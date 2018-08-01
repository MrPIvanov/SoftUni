using NUnit.Framework;

public class _02_TestDummyTests
{
    [Test]
    public void DummyLoseHealthWhenAtacked()
    {
        var axe = new Axe(5, 10);
        var dummy = new Dummy(15, 20);

        dummy.TakeAttack(5);

        Assert.That(dummy.Health, Is.EqualTo(10));
    }

    [Test]
    public void DeadDummyThrowsExeption()
    {
        var axe = new Axe(5, 10);
        var dummy = new Dummy(0,15);

        Assert.That(()=> dummy.TakeAttack(5), Throws.InvalidOperationException.With.Message.EqualTo("Dummy is dead."));
    }

    [Test]
    public void DeadDummyGiveXP()
    {
        var axe = new Axe(5, 10);
        var dummy = new Dummy(2, 15);

        dummy.TakeAttack(5);
        Assert.That(dummy.GiveExperience, Is.EqualTo(15));
    }

    [Test]
    public void AliveDummyDontGiveXP()
    {
        var axe = new Axe(5, 10);
        var dummy = new Dummy(2, 15);

        
        Assert.That(dummy.GiveExperience, Throws.InvalidOperationException.With.Message.EqualTo("Target is not dead."));
    }
}