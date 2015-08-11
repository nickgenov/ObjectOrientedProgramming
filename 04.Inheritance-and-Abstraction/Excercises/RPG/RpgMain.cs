using System;
using RPG.Characters;

namespace RPG
{
    class RpgMain
    {
        static void Main()
        {
            Warrior stamat = new Warrior();
            Priest maria = new Priest();
            Mage kircho = new Mage();

            stamat.Attack(kircho);

            Console.WriteLine(kircho.Health);
        }
    }
}