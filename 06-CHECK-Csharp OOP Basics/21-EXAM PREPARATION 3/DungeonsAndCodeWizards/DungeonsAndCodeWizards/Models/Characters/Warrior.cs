using System;
using DungeonsAndCodeWizards.Models.Bags;

namespace DungeonsAndCodeWizards.Models.Characters
{
    public class Warrior : Character, IAttackable
    {
        private const double  WarriorHealth = 100.0;
        private const double  WarriorArmor = 50.0;
        private const double WarriorAbilityPoints = 40.0;

        public Warrior(string name, Faction faction) 
            : base(name, WarriorHealth, WarriorArmor, WarriorAbilityPoints, new Satchel(), faction)
        {
        }

        public void Attack(Character character)
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }

            if (!character.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }

            if (this == character)
            {
                throw new InvalidOperationException("Cannot attack self!");
            }

            if (this.Faction == character.Faction)
            {
                throw new ArgumentException($"Friendly fire! Both characters are from {this.Faction} faction!");
            }

            character.TakeDamage(this.AbilityPoints);
        }
    }
}
