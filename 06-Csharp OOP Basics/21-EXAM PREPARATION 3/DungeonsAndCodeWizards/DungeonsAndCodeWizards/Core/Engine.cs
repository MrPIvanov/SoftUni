using System;
using System.Linq;

namespace DungeonsAndCodeWizards.Core
{
    public class Engine
    {
        private bool ItIsRunning;
        private readonly DungeonMaster dungeonMaster;

        public Engine()
        {
            this.dungeonMaster = new DungeonMaster();
        }

        public void Run()
        {
            this.ItIsRunning = true;

            while (ItIsRunning)
            {
                var input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    this.ItIsRunning = false;
                    break;
                }

                var inputTokens = input.Split();

                var command = inputTokens[0];
                var tokens = inputTokens.Skip(1).ToArray();
                var result = "";

                try
                {
                    switch (command)
                    {
                        case "JoinParty":
                            result = this.dungeonMaster.JoinParty(tokens);
                            break;

                        case "AddItemToPool":
                            result = this.dungeonMaster.AddItemToPool(tokens);
                            break;

                        case "PickUpItem":
                            result = this.dungeonMaster.PickUpItem(tokens);
                            break;

                        case "UseItem":
                            result = this.dungeonMaster.UseItem(tokens);
                            break;

                        case "UseItemOn":
                            result = this.dungeonMaster.UseItemOn(tokens);
                            break;

                        case "GiveCharacterItem":
                            result = this.dungeonMaster.GiveCharacterItem(tokens);
                            break;

                        case "GetStats":
                            result = this.dungeonMaster.GetStats();
                            break;

                        case "Attack":
                            result = this.dungeonMaster.Attack(tokens);
                            break;

                        case "Heal":
                            result = this.dungeonMaster.Heal(tokens);
                            break;

                        case "EndTurn":
                            result = this.dungeonMaster.EndTurn(tokens);
                            break;
                    }

                    Console.WriteLine(result);

                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine($"Invalid Operation: {ex.Message}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Parameter Error: {ex.Message}");
                }
            }

            Console.WriteLine($"Final stats:");
            Console.WriteLine(this.dungeonMaster.GetStats());
        }
    }
}
