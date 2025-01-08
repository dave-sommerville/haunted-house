using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haunted_House
{
    public class Ghosts
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Scariness { get; set; }

        public Ghosts(string name, string description, int scariness)
        {
            Name = name;
            Description = description;
            Scariness = scariness;
        }

        // Methods
        public void DescribeGhost()
        {

        }
        public void WillHaunt()
        {

        }
        public void Haunt()
        {
            
        }
    }

}
