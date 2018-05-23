using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimulatorStrategy.Interface;
using SimulatorStrategy.Weapon;
namespace SimulatorStrategy.Characters
{
    public class Knight:Character
    {
       

        public override void fight()
        {
            Console.WriteLine("I'm knight! I can fight better than you,bitch! ");
            weapon.useWeapon();
        }

        public Knight()
        {
            weapon = new AxeBehavior();
            
        }
      
    }
}
