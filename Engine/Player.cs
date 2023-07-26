using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Engine.Engine
{
    public class Player : LivingCreature
    {
       
        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }

        public List<InventoryItem> Inventory { get; set; } = new List<InventoryItem>();
        public List<PlayerQuest> Quests { get; set; } = new List<PlayerQuest> { };

        public Player(int gold, int experiencePoints, int level, int currentHitPoints, int maximumHitPoints) : base(currentHitPoints,maximumHitPoints)
        {
            Gold = gold;
            ExperiencePoints = experiencePoints;
            Level = level;
        }
    }
}
