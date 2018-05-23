using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimulatorStrategy.Interface;
namespace SimulatorStrategy.Characters
{
    public abstract class Character
    {
       public WeaponBehavior weapon;
        

        public abstract void fight();

      public void setWeapon(WeaponBehavior w)
        {
            this.weapon = w;
            w.useWeapon();
        }

        
    }
}
