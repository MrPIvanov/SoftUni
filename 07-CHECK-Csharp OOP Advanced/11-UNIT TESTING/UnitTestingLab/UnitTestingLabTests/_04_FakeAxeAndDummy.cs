using NUnit.Framework;
using System;

public class _04_FakeAxeAndDummy
{
    [Test]
    public void HeroTakeXPWhenDummyDies()
    {
        var fakeWeapon = new FakeWeapon();
        var fakeTarget = new FaceDummy();
        var hero = new Hero("Ivan", fakeWeapon);

        hero.Attack(fakeTarget);
        Assert.That(hero.Experience, Is.EqualTo(20));

    }

    public class FakeWeapon : IAxe
    {
        public int AttackPoints => 5;

        public int DurabilityPoints => 3;

        public void Attack(IDummy target)
        {
            if (this.DurabilityPoints <= 0)
            {
                throw new InvalidOperationException("Axe is broken.");
            }

            target.TakeAttack(this.AttackPoints);
        }
    }
    public class FaceDummy : IDummy
    {
        public int Health => 0;

        public int GiveExperience()
        {
            return 20;
        }

        public bool IsDead()
        {
            return true;
        }

        public void TakeAttack(int attackPoints)
        {
            
        }
    }
}