using Moq;
using NUnit.Framework;

public class _05_Mocking
{
    [Test]
    public void HeroGainsXPAfterTargetDies()
    {
        Mock<IDummy> fakeTarget = new Mock<IDummy>();
        fakeTarget.Setup(p => p.Health).Returns(0);
        fakeTarget.Setup(p => p.GiveExperience()).Returns(20);
        fakeTarget.Setup(p => p.IsDead()).Returns(true);

        Mock<IAxe> fakeWeapon = new Mock<IAxe>();
        Hero hero = new Hero("Pesho", fakeWeapon.Object);

        hero.Attack(fakeTarget.Object);

        Assert.That(hero.Experience, Is.EqualTo(20));
    }
}