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
    internal class Goblin : Enemy
    {
        public Goblin()
        {
            Name = "Гоблиг";
            Damage = 20;
            Health = 150;
        }

        public override void BaseAttack()
        {
            Console.WriteLine("Напрыгивает с кулаками\n");
        }
    }
}
