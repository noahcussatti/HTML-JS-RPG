using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnoahRpg.Model
{
    public class Monster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Health { get; set;}
        public int Power { get; set; }
        public int Gold { get; set; }
        public Item CurrentHelmet { get; set; }
        public Item CurrentChest { get; set; }
        public Item CurrentWrist { get; set; }
        public Item CurrentWeapon { get; set; }
    }
}
