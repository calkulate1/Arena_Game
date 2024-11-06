using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp35.Weapons;

namespace ConsoleApp35
{
    internal class Player
    {
        public Player()
        {
            Name = "Боец";
        }
        public string Name { set; get; }

        public void attack()
        {

            if (Weapon != null)
            {
                Weapon.WeaponAttack();
            }
            else
            {
                Console.WriteLine("бьет кулаком\n");
            }
        }
        public Weapon Weapon { set; get; }

    }
}
