using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35.characters
{
    internal class Warrior : Player
    {
        public Warrior()
        {
            Name = "Воин";
            Damage = 10;
            Health = 100;
        }

        public override void BaseAttack()
        {
            Console.WriteLine("бьет ногой с вертухи\n");
        }
    }
}
