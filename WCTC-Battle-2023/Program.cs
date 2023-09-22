using Class05.Interfaces;
using Class05.Models;

namespace Class05
{
    class Program
    {
        static void Main(string[] args)
        {

            IArmor armor = new ChainMail("Steel Chain Mail", 16);
            IWeapon axe = new Axe("Wood axe", 2);

            ICombatant fighter = new Fighter("Fighter Fred", armor, axe);
            ICombatant badGuy = new Fighter("Scary Monster", armor, axe);

            fighter.Attack(badGuy); 
            
            
            //IArmor armor = new Leather("Elven Leather Armor", 12);
            //IWeapon sword = new Sword("Long sword", 5);

            //ICombatant fighter = new Fighter("Fighter Fred", armor, sword);
            //ICombatant badGuy = new Fighter("Scary Monster", armor, sword);

            //fighter.Attack(badGuy);

        }

    }

}
