using ConsoleApp35.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp35.characters
{
    internal class Spearman : Player
    {
        public Spearman()
        {
            Name = "Копейщик";
            Damage = 8;
            Health = 100;
        }
    }
}
