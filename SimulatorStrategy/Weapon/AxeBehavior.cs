using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimulatorStrategy.Interface;
namespace SimulatorStrategy.Weapon
{
    public class AxeBehavior:WeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("Axe shot!");
        }
    }
}
