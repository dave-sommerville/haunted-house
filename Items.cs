namespace Haunted_House
{
    public class Items
    {
        public string Name {  get; set; }
        public string UseItemString { get; set; }
        public int KeyID { get; set; }
        public bool IsRelic { get; set; }

        public Items(string name, string useItemString, int keyID, bool isRelic)
        {
            Name = name;
            UseItemString = useItemString;
            KeyID = keyID;
            IsRelic = isRelic;
        }

    }
}
