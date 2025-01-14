using System.ComponentModel.Design;

namespace Haunted_House
{
    public class Rooms
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string[] Contents { get; set; }
        public int KeyCode { get; set; }
        public Rooms SecretRoom { get; set; }

        public Rooms(string name, string description, string[] contents, int keyCode, Rooms secretRoom)
        {
            Name = name;
            Description = description;
            Contents = contents;
            KeyCode = keyCode;
            SecretRoom = secretRoom;
        }
        public void DescribeRoom()
        {
            Console.WriteLine($"You approach the {Name}.\n{Description}");
        }

        public Player Search(Dictionary<string, Items> itemsList, Player player)
        {
            if (Contents != null)
            {
                for (int i = 0; i < Contents.Length; i++)
                {
                    string itemName = Contents[i];
                    Items item = itemsList[itemName];
                    AddItemToInventory(item, player);
                    if (item.IsRelic)
                    {
                        HandleRelic(item, player);
                    }
                    Console.WriteLine("1) Search 2) Leave");
                    break;
                }
                Contents = null;
            }
            else
            {
                Console.WriteLine("Nothing to be found here!");
            }
            return player;
        }



        private void AddItemToInventory(Items item, Player player)
        {
            for (int i = 0; i < player.Inventory.Length; i++)
            {
                if (player.Inventory[i] != null)
                {
                    continue;
                }
                else if (player.Inventory[i] == null)
                {
                    player.Inventory[i] = item;
                    Console.WriteLine($"{item.Name} added to player inventory");
                    break;
                }
            }
        }

        private void HandleRelic(Items item, Player player)
        {
            player.RelicCount++;
            if (player.RelicCount >= 5)
            {
                Console.WriteLine($"Great job, {player.Name}! You have bravely located all my relics and at last I am a peace.");
                player.GameInProgress = false;
            }
        }
    }
}

