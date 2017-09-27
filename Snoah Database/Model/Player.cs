using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnoahRpg.Model
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxHealth { get; set; }
        public int CurrentHealth { get; set; }
        public int Gold { get; set; }
        public Item CurrentHelm { get; set; }
        public Item CurrentChest { get; set; }
        public Item CurrentWrist { get; set; }
        public Item CurrentWeapon { get; set; }
    }
}
