using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35.Weapons
{
    internal abstract class Weapon
    {
        public abstract void WeaponAttack();
        public int WeaponDamage { get; set; }
    }
}
