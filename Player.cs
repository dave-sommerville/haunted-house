namespace Haunted_House
{
    public class Player
    {
        public string Name {  get; set; }
        public Items[] Inventory { get; set; }
        public int Sanity { get; set; }
        public int RelicCount { get; set; }
        public Player(string name, Items[] inventory, int sanity, int relicCount)
        {
            Name = name;
            Inventory = inventory;
            Sanity = sanity;
            RelicCount = relicCount;
        }

        public int PrintInventory()
        {
            while (true) 
            { 
                int intDecision;
                string decision = Console.ReadLine();

                if (int.TryParse(decision, out intDecision))
                {
                    if (intDecision >= 0 && intDecision <= 10)

                    {
                        return intDecision;
                    }
                    else
                    {
                        Console.WriteLine("Enter a number between 1 - 2");
                    }
                }
                else
                {
                    Console.WriteLine("That is an invalid character.");
                }
            }
        }
        public bool UseItem(int selectedItem, Rooms chosenRoom)
        {
            if (Inventory[selectedItem] != null)
            {
                int key = Inventory[selectedItem].KeyID;
                int room = chosenRoom.KeyCode;
                if (key == room)
                {
                    return true;
                } else
                {
                    return false;
                }
            } else
            {
                return false;
            }
        }
    }
}
