using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Engine.Engine
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string NamePlural { get; set; }

        public Item(int ıd, string name, string namePlural)
        {
            ID = ıd;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            NamePlural = namePlural ?? throw new ArgumentNullException(nameof(namePlural));
        }
    }
}
