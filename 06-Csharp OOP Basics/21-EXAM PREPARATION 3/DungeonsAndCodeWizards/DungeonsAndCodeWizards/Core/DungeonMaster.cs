using DungeonsAndCodeWizards.Factories;
using DungeonsAndCodeWizards.Models.Characters;
using DungeonsAndCodeWizards.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonsAndCodeWizards.Core
{
    public class DungeonMaster
    {
        private List<Character> AllCharacters;

        private List<Item> AllItems;

        private int LastSurvivorRounds;

        private ItemFactory ItemFactory;

        private CharacterFactory CharacterFactory;

        public DungeonMaster()
        {
            this.AllCharacters = new List<Character>();

            this.AllItems = new List<Item>();

            this.ItemFactory = new ItemFactory();

            this.CharacterFactory = new CharacterFactory();
        }

        public string JoinParty(string[] args)
        {
            var faction = args[0];
            var type = args[1];
            var name = args[2];

            var characterToAdd = this.CharacterFactory.CreateCharacter(faction, type, name);

            this.AllCharacters.Add(characterToAdd);

            var result = $"{name} joined the party!";
            return result;
        }

        public string AddItemToPool(string[] args)
        {
            var itemName = args[0];

            var item = this.ItemFactory.CreateItem(itemName);

            this.AllItems.Add(item);

            var result = $"{itemName} added to pool.";
            return result;
        }

        public string PickUpItem(string[] args)
        {
            var characterName = args[0];

            var character = this.AllCharacters.Where(c => c.Name == characterName).FirstOrDefault();

            if (character == null)
            {
                throw new ArgumentException($"Character {characterName} not found!");
            }

            if (this.AllItems.Count == 0)
            {
                throw new InvalidOperationException($"No items left in pool!");
            }

            var item = this.AllItems.Last();
            character.ReceiveItem(item);

            this.AllItems.Remove(item);

            var result = $"{characterName} picked up {item.GetType().Name}!";
            return result;
        }

        public string UseItem(string[] args)
        {
            var characterName = args[0];
            var itemName = args[1];

            var character = this.AllCharacters.Where(c => c.Name == characterName).FirstOrDefault();

            if (character == null)
            {
                throw new ArgumentException($"Character {characterName} not found!");
            }

            if (character.Bag.Items.Count == 0)
            {
                throw new InvalidOperationException("Bag is empty!");
            }

            var item = character.Bag.Items.FirstOrDefault(x => x.GetType().Name == itemName);

            if (item == null)
            {
                throw new ArgumentException($"No item with name {itemName} in bag!");
            }

            character.UseItem(item);

            var result = $"{characterName} used {itemName}.";
            return result;
        }

        public string UseItemOn(string[] args)
        {
            var giverName = args[0];
            var receiverName = args[1];
            var itemName = args[2];

            var giverCharacter = this.AllCharacters.Where(c => c.Name == giverName).FirstOrDefault();
            var receiverCharacter = this.AllCharacters.Where(c => c.Name == receiverName).FirstOrDefault();

            if (giverCharacter == null)
            {
                throw new ArgumentException($"Character {giverName} not found!");
            }

            if (receiverCharacter == null)
            {
                throw new ArgumentException($"Character {receiverName} not found!");
            }

            var item = giverCharacter.Bag.Items.FirstOrDefault(x => x.GetType().Name == itemName);

            if (item == null)
            {
                throw new ArgumentException($"Item {itemName} not found!");
            }

            giverCharacter.UseItemOn(item, receiverCharacter);


            var result = $"{giverName} used {itemName} on {receiverName}.";
            return result;
        }

        public string GiveCharacterItem(string[] args)
        {
            var giverName = args[0];
            var receiverName = args[1];
            var itemName = args[2];

            var giverCharacter = this.AllCharacters.Where(c => c.Name == giverName).FirstOrDefault();
            var receiverCharacter = this.AllCharacters.Where(c => c.Name == receiverName).FirstOrDefault();

            if (giverCharacter == null)
            {
                throw new ArgumentException($"Character {giverName} not found!");
            }

            if (receiverCharacter == null)
            {
                throw new ArgumentException($"Character {receiverName} not found!");
            }

            var item = giverCharacter.Bag.Items.FirstOrDefault(x => x.GetType().Name == itemName);

            if (item == null)
            {
                throw new ArgumentException($"Item {itemName} not found!");
            }

            giverCharacter.GiveCharacterItem(item, receiverCharacter);

            var result = $"{giverName} gave {receiverName} {itemName}.";
            return result;
        }

        public string GetStats()
        {
            var sb = new StringBuilder();

            var sortedChars = this.AllCharacters.OrderByDescending(x => x.IsAlive).ThenByDescending(x => x.Health).ToArray();

            foreach (var character in sortedChars)
            {
                var status = "Dead";
                if (character.IsAlive)
                {
                    status = "Alive";
                }

                sb.AppendLine($"{character.Name} - HP: {character.Health}/{character.BaseHealth}," +
                    $" AP: {character.Armor}/{character.BaseArmor}, Status: {status}");
            }

            var result = sb.ToString().TrimEnd();
            return result;
        }

        public string Attack(string[] args)
        {
            var attackerName = args[0];
            var receiverName = args[1];

            var attacker = this.AllCharacters.Where(x => x.Name == attackerName).FirstOrDefault();
            var receiver = this.AllCharacters.Where(x => x.Name == receiverName).FirstOrDefault();

            if (attacker == null)
            {
                throw new ArgumentException($"Character {attackerName} not found!");
            }

            if (receiver == null)
            {
                throw new ArgumentException($"Character {receiverName} not found!");
            }


            if (attacker.GetType().Name != "Warrior")
            {
                throw new ArgumentException($"{attacker.Name} cannot attack!");
            }

            var warriorAttacker = (Warrior)attacker;

            warriorAttacker.Attack(receiver);

            var result = $"{attackerName} attacks {receiverName} for {attacker.AbilityPoints} hit points! " +
                $"{receiverName} has {receiver.Health}/{receiver.BaseHealth} HP and {receiver.Armor}/{receiver.BaseArmor} AP left!";

            if (!receiver.IsAlive)
            {
                result += $"{Environment.NewLine}{receiver.Name} is dead!";
            }

            return result;
        }

        public string Heal(string[] args)
        {

            var healerName = args[0];
            var healingReceiverName = args[1];

            var healer = this.AllCharacters.Where(x => x.Name == healerName).FirstOrDefault();
            var receiver = this.AllCharacters.Where(x => x.Name == healingReceiverName).FirstOrDefault();

            if (healer == null)
            {
                throw new ArgumentException($"Character {healerName} not found!");
            }

            if (receiver == null)
            {
                throw new ArgumentException($"Character {healingReceiverName} not found!");
            }

            if (healer.GetType().Name != "Cleric")
            {
                throw new ArgumentException($"{healerName} cannot heal!");
            }

            var clericHealer = (Cleric)healer;

            clericHealer.Heal(receiver);

            var result = $"{healer.Name} heals {receiver.Name} for {healer.AbilityPoints}! {receiver.Name} has {receiver.Health} health now!";
            return result;
        }

        public string EndTurn(string[] args)
        {
            var sb = new StringBuilder();

            foreach (var character in this.AllCharacters.Where(x => x.IsAlive == true).ToArray())
            {
                var healthBeforeRest = character.Health;

                character.Rest();

                var currentHealth = character.Health;

                sb.AppendLine($"{character.Name} rests ({healthBeforeRest} => {currentHealth})");
            }

            if (this.AllCharacters.Where(x => x.IsAlive == true).ToArray().Length <= 1)
            {
                this.LastSurvivorRounds++;
                
            }

            var result = sb.ToString().TrimEnd();
            return result;
        }

        public bool IsGameOver()
        {
            var oneOrZeroSurvivorsLeft = this.AllCharacters.Count(c => c.IsAlive) <= 1;
            var lastSurviverSurvivedTooLong = this.LastSurvivorRounds > 1;

            return oneOrZeroSurvivorsLeft && lastSurviverSurvivedTooLong;
        }

    }
}
