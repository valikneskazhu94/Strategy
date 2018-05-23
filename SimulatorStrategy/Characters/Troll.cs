using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimulatorStrategy.Interface;
using SimulatorStrategy.Weapon;
namespace SimulatorStrategy.Characters
{
   public class Troll:Character
    {
        public override void fight()
        {
            Console.WriteLine("I'm a troll! Ha-ha! I will enslave you all!");
            weapon.useWeapon();
        }
        public Troll()
        {
            weapon = new BowAndArrowBehavior();
            
        }
    }
}
