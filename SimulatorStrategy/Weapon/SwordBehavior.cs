using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimulatorStrategy.Interface;
namespace SimulatorStrategy.Weapon
{
   public class SwordBehavior:WeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("Sword Hit!");
        }
    }
}
