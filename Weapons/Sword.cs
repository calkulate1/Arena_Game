using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35.Weapons
{
    internal class Sword : Weapon
    {
        public override void WeaponAttack()
        {
            Console.WriteLine("рубит мечом\n");
        }
    }
}
