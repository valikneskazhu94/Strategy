using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimulatorStrategy.Weapon;
using SimulatorStrategy.Interface;
namespace SimulatorStrategy.Characters
{
    public class King:Character
    {
        public override void fight()
        {
            Console.WriteLine("I'm a King ! I can fight! I'm so mighty!");
            weapon.useWeapon();
        }
        public King()
        {
            weapon = new SwordBehavior();
            
        }
    }
}
