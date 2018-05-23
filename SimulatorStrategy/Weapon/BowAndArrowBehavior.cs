using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimulatorStrategy.Interface;
namespace SimulatorStrategy.Weapon
{
   public class BowAndArrowBehavior:WeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("Bow and arrow shot!");
        }

    }
}
