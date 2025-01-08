using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haunted_House
{
    internal class Items
    {
        public string Name {  get; set; }
        public string Description { get; set; }
        public bool IsKey { get; set; }

        public Items(string name, string description, bool iskey)
        {
            Name = name;
            Description = description;
            IsKey = iskey;
        }
        public void DescribeItem()
        {

        }
        public void OpenSecret()
        {

        }
    }
}
