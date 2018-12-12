using System;
using DungeonsAndCodeWizards.Models.Bags;

namespace DungeonsAndCodeWizards.Models.Characters
{
    public class Cleric : Character, IHealable
    {
        private const double ClericHealth = 50.0;
        private const double ClericArmor = 25.0;
        private const double ClericAbilityPoints = 40.0;
        private static Backpack backpack = new Backpack();

        public Cleric(string name, Faction faction)
            : base(name, ClericHealth, ClericArmor, ClericAbilityPoints, backpack, faction)
        {
        }

        public override double RestHealMultiplier => 0.5;

        public void Heal(Character character)
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }

            if (!character.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }

            if (this.Faction != character.Faction)
            {
                throw new InvalidOperationException("Cannot heal enemy character!");
            }

            character.Health += this.AbilityPoints;
        }
    }
}
