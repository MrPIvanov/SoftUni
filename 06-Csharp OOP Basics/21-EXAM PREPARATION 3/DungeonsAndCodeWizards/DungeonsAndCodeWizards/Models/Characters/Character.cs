using DungeonsAndCodeWizards.Models.Bags;
using DungeonsAndCodeWizards.Models.Items;
using System;

namespace DungeonsAndCodeWizards.Models.Characters
{
    public abstract class Character
    {
        private string name;

        private double health;

        private double armor;

        public Character(string name, double health, double armor, double abilityPoints, Bag bag, Faction faction)
        {
            this.Name = name;
            this.BaseHealth = health;
            this.Health = health;
            this.BaseArmor = armor;
            this.Armor = armor;
            this.AbilityPoints = abilityPoints;
            this.Bag = bag;
            this.Faction = faction;
        }

        public bool IsAlive { get; set; } = true;

        public virtual double RestHealMultiplier { get; private set; } = 0.2;

        public Bag Bag { get; private set; }

        public Faction Faction { get; private set; }

        public double AbilityPoints { get; private set; }

        public double BaseHealth { get; private set; }

        public double BaseArmor { get; private set; }

        public double Armor
        {
            get { return armor; }
            set
            {
                if (value <= 0)
                {
                    value = 0;
                }

                if (value >= this.BaseArmor)
                {
                    value = this.BaseArmor;
                }

                armor = value;
            }
        }

        public double Health
        {
            get { return health; }
            set
            {
                if (value <= 0)
                {
                    value = 0;
                }

                if (value >= this.BaseHealth)
                {
                    value = this.BaseHealth;
                }

                health = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or whitespace!");
                }
                name = value;
            }
        }

        public void TakeDamage(double hitPoints)
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }

            if (this.Armor >= hitPoints)
            {
                this.Armor -= hitPoints;
            }
            else if (this.Health + this.Armor >= hitPoints)
            {
                hitPoints -= this.Armor;
                this.Armor = 0;
                this.Health -= hitPoints;
            }
            else
            {
                this.Health = 0;
                this.Armor = 0;
                this.IsAlive = false;
            }
        }

        public void Rest()
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }

            this.Health += this.BaseHealth * this.RestHealMultiplier;
        }

        public void UseItem(Item item)
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }

            item.AffectCharacter(this);
        }

        public void UseItemOn(Item item, Character character)
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }

            if (!character.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }

            item.AffectCharacter(character);
        }

        public void GiveCharacterItem(Item item, Character character)
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }

            if (!character.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }

            character.ReceiveItem(item);
        }

        public void ReceiveItem(Item item)
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }

            this.Bag.AddItem(item);
        }
    }
}
