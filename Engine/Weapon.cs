﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Engine.Engine
{
    internal class Weapon : Item
    {
        
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
    }
}