using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp35.Enemies;
using static ConsoleApp35.Enemies.Enemy;
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
            Console.WriteLine($"бьет кулаком и наносит {FullDamage} урона\n");
        }


        public void EndPlayerDamage()
        {
            Random rnd = new Random();
            int value = rnd.Next(1, 4);
            if (value == 1)
            {
                Damage += (Damage / 2);
            }
            else if (value == 2)
            {
                Damage -= (Damage / 2);
            }
            else
            {
                Damage += 0;
            }
            FullDamage = Damage + Weapon.WeaponDamage;
        }
        public void attack()
        {

            if (Weapon != null)
            {
                EndPlayerDamage();
                Weapon.WeaponAttack();
                Console.WriteLine($" и наносит { FullDamage} урона");
            }
            else
            {
                EndPlayerDamage();
                FullDamage = Damage;
                BaseAttack();
            }
        }
    }
}
