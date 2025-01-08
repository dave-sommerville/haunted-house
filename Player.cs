using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haunted_House
{
    public class Player
    {
        public string Name {  get; set; }
        public int Shards { get; set; }
        public string[] Inventory { get; set; }
        public int Sanity { get; set; }
        public Player(string name, int shards, string[] inventory, int sanity)
        {
            Name = name;
            Shards = shards;
            Inventory = inventory;
            Sanity = sanity;
        }
        public void SetName()
        {

        }
        public void ShardManagement()
        {

        }
        public void InventoryManagement()
        {

        }
        public void SanityManagement()
        {

        }

    }
}
