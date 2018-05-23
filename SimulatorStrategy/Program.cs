using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimulatorStrategy.Interface;
using SimulatorStrategy.Weapon;
using SimulatorStrategy.Characters;
namespace SimulatorStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Character> characters = new List<Character>();
            characters.AddRange(new Character[] {
                new King(),
                new Queen(),
                new Troll(),
                new Knight()
            });

            foreach (var character in characters)
            {
                character.fight();
                Console.WriteLine("-----------");
            }
        }
    }
}
