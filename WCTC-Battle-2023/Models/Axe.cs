using Class05.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class05.Models
{
    public class Axe : IWeapon
    {
        public string Name { get; set; }
        public int Power { get; set; }

        // default constructor
        public Axe()
        {
            Name = "Battle Axe";
            Power = 13;
        }
        // constructor
        public Axe(string name, int power)
        {
            Name = name;
            Power = power;
        }
    }
}
