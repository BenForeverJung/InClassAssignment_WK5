using Class05.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class05.Models
{
    public class ChainMail : IArmor
    {
        public string Name { get; set; }
        public int Defense { get; set; }

        // default cinstructor

        public ChainMail()
        {
            Name = "Chain Mail Armor";
            Defense = 16;

        }

        // Constructor
        public ChainMail(string name, int defense)
        {
            Name = name;
            Defense = defense;
        }
    }
}
