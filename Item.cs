namespace Haunted_House
{
    public class Item
    {
        public readonly string Name;
        public readonly string UseItemString;
        public readonly int KeyID;
        public readonly bool IsRelic;

        public Item(string name, string useItemString, int keyID, bool isRelic)
        {
            Name = name;
            UseItemString = useItemString;
            KeyID = keyID;
            IsRelic = isRelic;
        }

    }
}
