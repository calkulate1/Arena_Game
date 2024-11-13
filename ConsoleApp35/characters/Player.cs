using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp35.Weapons;

namespace ConsoleApp35.characters
{
    internal abstract class Player
    {

        public string Name { set; get; }
        public int Damage { set; get; }
        public int Health { set; get; }
        public int FullDamage;

        public Weapon Weapon { set; get; }

        public virtual void BaseAttack()
        {
            Console.WriteLine("бьет кулаком\n");
        }


        public void attack()
        {

            if (Weapon != null)
            {
                Weapon.WeaponAttack();
                FullDamage = Damage + Weapon.WeaponDamage;
            }
            else
            {
                FullDamage = Damage;
                BaseAttack();
            }
        }

    }
}
