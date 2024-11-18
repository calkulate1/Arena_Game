using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35.Enemies
{
    internal abstract class Enemy
    {
        public string Name { set; get; }
        public int Damage { set; get; }
        public int Health { set; get; }

        public virtual void BaseAttack()
        {
            Console.WriteLine("бьет кулаком\n");
        }
    }
}
