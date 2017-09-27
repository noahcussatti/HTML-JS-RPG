using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnoahRpg.Model
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Gold { get; set; }
        public List<Item> Items { get; set; }
    }
}
