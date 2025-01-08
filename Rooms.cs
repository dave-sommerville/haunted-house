using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Haunted_House
{
    internal class Rooms
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string[] Contents { get; set; }
        public bool HasSecret { get; set; }
        public string SecretRoom { get; set; } //Only for three rooms, leave rest null

        public Rooms(string name, string description, string[] contents, bool hasSecret, string secretRoom)
        {
            Name = name;
            Description = description;
            Contents = contents;
            HasSecret = hasSecret;
            SecretRoom = secretRoom;
        }
        public void DescribeRoom()
        {

        }
        public void Search()
        {

        }
    }

}
