using NUnit.Framework;

public class _03_RefactorTests
{
    private const int axeDmg = 5;
    private const int axeDurability = 1;
    private const int dummyHealth = 5;
    private const int dummyXP = 10;
    private Axe axe;
    private Dummy dummy;

    [SetUp]
    public void Preparation()
    {
        this.axe = new Axe(axeDmg, axeDurability);
        this.dummy = new Dummy(dummyHealth, dummyXP);
    }

    [Test]
    public void AxeLossesDurabilityWhenAtacking()
    {
        var expectedDurability = 0;

        axe.Attack(dummy);

        Assert.That(axe.DurabilityPoints, Is.EqualTo(expectedDurability), "Axe Dont Lose Durability");
    }

    [Test]
    public void AtackWithBrokenWeapon()
    {

        axe.Attack(dummy);
        Assert.That(() => axe.Attack(dummy), Throws.InvalidOperationException.With.Message.EqualTo("Axe is broken."));
    }

    [Test]
    public void DummyLoseHealthWhenAtacked()
    {
        var expectedDummyHealth = 0;
        dummy.TakeAttack(axeDmg);

        Assert.That(dummy.Health, Is.EqualTo(expectedDummyHealth));
    }

    [Test]
    public void DeadDummyThrowsExeption()
    {
        dummy.TakeAttack(axeDmg);
        Assert.That(() => dummy.TakeAttack(axeDmg), Throws.InvalidOperationException.With.Message.EqualTo("Dummy is dead."));
    }

    [Test]
    public void DeadDummyGiveXP()
    {
        var expectedXP = 10;

        dummy.TakeAttack(axeDmg);
        Assert.That(dummy.GiveExperience, Is.EqualTo(expectedXP));
    }

    [Test]
    public void AliveDummyDontGiveXP()
    {
        Assert.That(dummy.GiveExperience, Throws.InvalidOperationException.With.Message.EqualTo("Target is not dead."));
    }
}