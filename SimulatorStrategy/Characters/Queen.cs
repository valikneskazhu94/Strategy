using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimulatorStrategy.Weapon;
using SimulatorStrategy.Interface;
namespace SimulatorStrategy.Characters
{
    public class Queen:Character
    {
        public override void fight()
        {
            Console.WriteLine("I'm a queen! I can fight too! Despite the fact that I'm a queen");
            weapon.useWeapon();
        }
        public Queen()
        {
            weapon = new KnifeBehavior();
            
        }
    }
}
