using DungeonsAndCodeWizards.Models.Characters;
using System;

namespace DungeonsAndCodeWizards.Factories
{
    public class CharacterFactory
    {
        public Character CreateCharacter(string faction, string type, string name)
        {
            Character character = null;

            if (faction != "CSharp" && faction != "Java")
            {
                throw new ArgumentException($"Invalid faction \"{faction}\"!");
            }
            Faction factionEnum;
            switch (type)
            {
                case "Warrior":
                    factionEnum = (Faction)Enum.Parse(typeof(Faction), faction);

                    character = new Warrior(name, factionEnum);
                    break;

                case "Cleric":
                    factionEnum = (Faction)Enum.Parse(typeof(Faction), faction);

                    character = new Cleric(name, factionEnum);
                    break;

                default:
                    throw new ArgumentException($"Invalid character type \"{type}\"!");
            }

            return character;
        }

        
    }
}
