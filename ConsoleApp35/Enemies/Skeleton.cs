using ConsoleApp35.characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace ConsoleApp35.Enemies
{
    internal class Skeleton : Enemy
    {
        public Skeleton()
        {
            Name = "Скелет";
            Damage = 10;
            Health = 70;
        }
        public override void BaseAttack()
        {
            Console.WriteLine($"стреляет из лука и наносит {Damage} урона");
        }
    }
}
