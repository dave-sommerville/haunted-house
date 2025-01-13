using System.ComponentModel.Design;

namespace Haunted_House
{
    public class Rooms
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string[] Contents { get; set; }
        public bool IsComplete { get; set; }
        public int KeyCode { get; set; }
        public Rooms SecretRoom { get; set; }

        public Rooms(string name, string description, string[] contents, bool isComplete, int keyCode, Rooms secretRoom)
        {
            Name = name;
            Description = description;
            Contents = contents;
            IsComplete = isComplete;
            KeyCode = keyCode;
            SecretRoom = secretRoom;
        }
        public void DescribeRoom()
        {
            Console.WriteLine($"You make it to the {Name}.\n{Description}");
        }

        public Player Search(Dictionary<string, Items> itemsList, Player player)
        {
            if (Contents != null)
            { 
                for (int i = 0; i < Contents.Length; i++)
                {
                    string itemName = Contents[i];
                    Items item = itemsList[itemName];
                    for (int j = 0; j < player.Inventory.Length; j++)
                    {
                        if (player.Inventory[j] != null)
                        {
                            continue;
                        } else if (player.Inventory[j] == null) {
                            player.Inventory[j] = item;
                            Console.WriteLine($"{item.Name} added to player inventory");
                            if (item.IsRelic)
                            {
                                player.RelicCount++;
                                if (player.RelicCount >= 5)
                                {
                                    Console.WriteLine($"Great job, {player.Name}! You have bravely located all my relics and at last I am a peace.");
                                }
                            }
                            break;
                        }
                    }
                }
                Contents = null;
            } else if (Contents == null){
                Console.WriteLine("Nothing to be found here!");
            }
            return player;
        }

    }

}
