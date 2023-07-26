using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Engine.Engine
{
    internal class Weapon : Item
    {
        public Weapon(int ıd, string name, string namePlural,int minimumDamage, int maximumDamage) : base(ıd, name, namePlural)
        {
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
        }

        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

    }
}
