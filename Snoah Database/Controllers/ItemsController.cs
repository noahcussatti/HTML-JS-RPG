using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SnoahRpg.Model;

namespace SnoahRpg.Controllers
{
    [Produces("application/json")]
    [Route("api/Items")]
    public class ItemsController : Controller
    {
        private readonly SnoahRpgContext _context;

        public ItemsController(SnoahRpgContext context)
        {
            _context = context;
            if (_context.Item.Count() == 0)
            {

                Item h1 = new Item
                {
                    Id = 1,
                    Name = "Leather Cap",
                    Power = 5,
                    Type = "helmet",
                    Image = "https://i.imgur.com/tFG1KOM.png"
                };

                Item h2 = new Item
                {
                    Id = 2,
                    Name = "Chainmail Helm",
                    Power = 10,
                    Type = "helmet",
                    Image = "https://i.imgur.com/G3rbn1J.png"
                };

                Item h3 = new Item
                {
                    Id = 3,
                    Name = "Plate Helm",
                    Power = 20,
                    Type = "helmet",
                    Image = "https://i.imgur.com/MSLjTpx.png"

                };

                Item a1 = new Item
                {
                    Id = 4,
                    Name = "Studed Leather Armor",
                    Power = 10,
                    Type = "chest",
                    Image = "https://i.imgur.com/QcXVP0b.png"
                };
                
                Item a2 = new Item
                {
                    Id = 5,
                    Name = "Quilted armor",
                    Power = 15,
                    Type = "chest",
                    Image = "https://i.imgur.com/9oadoje.png"
                };


                Item a3 = new Item
                {
                    Id = 6,
                    Name = "Chainmail Armor",
                    Power = 20,
                    Type = "chest",
                    Image = "https://i.imgur.com/uuDawKP.png"
                };

                Item a4 = new Item
                {
                    Id = 7,
                    Name = "Plate Armor",
                    Power = 25,
                    Type = "chest",
                    Image = "https://i.imgur.com/ilIaLPc.png"
                };

                Item a5 = new Item
                {
                    Id = 8,
                    Name = "Leather Bracers",
                    Power = 5,
                    Type = "wrist",
                    Image = "https://i.imgur.com/iAdsqt0.png"
                };

                Item w1 = new Item
                {
                    Id = 9,
                    Name = "Maul",
                    Power = 60,
                    Type = "weapon",
                    Image = "https://i.imgur.com/hXAEbM1.png"
                };

                Item w2 = new Item
                {
                    Id = 10,
                    Name = "Morning Star",
                    Power = 20,
                    Type = "weapon",
                    Image = "https://i.imgur.com/47MXsHr.png"
                };

                Item w3 = new Item
                {
                    Id = 11,
                    Name = "War Hammer",
                    Power = 40,
                    Type = "weapon",
                    Image = "https://i.imgur.com/nNjnfMu.png"
                };

                Item w4 = new Item
                {
                    Id = 12,
                    Name = "Rusty Sword",
                    Power = 10,
                    Type = "weapon",
                    Image = "https://i.imgur.com/LARZT7I.png"
                };

                Item w5 = new Item
                {
                    Id = 13,
                    Name = "wooden sword",
                    Power = 7,
                    Type = "weapon",
                    Image = "https://i.imgur.com/B6Ul0mf.jpg"
                };

                Item w6 = new Item
                {
                    Id = 14,
                    Name = "Long Sword",
                    Power = 30,
                    Type = "weapon",
                    Image = "https://i.imgur.com/qFl4976.png"
                };

                Item w7 = new Item
                {
                    Id = 15,
                    Name = "EPIC Sword",
                    Power = 70,
                    Type = "weapon",
                    Image = "https://i.imgur.com/poj0jfC.png"
                };

                Item w8 = new Item
                {
                    Id = 16,
                    Name = "Rusty Daggers",
                    Power = 10,
                    Type = "weapon",
                    Image = "https://i.imgur.com/50DTMnJ.png"
                };

                Item w9 = new Item
                {
                    Id = 17,
                    Name = "Twin Daggers",
                    Power = 25,
                    Type = "weapon",
                    Image = "https://i.imgur.com/1BCiVsW.png"
                
                };

                Item w10 = new Item
                {
                     Id = 18,
                    Name = "Dragon Dagger",
                    Power = 50,
                    Type = "weapon",
                    Image = "https://i.imgur.com/kwPiOCK.png" 
                    
                };

                Item w11 = new Item
                {
                    Id = 19,
                    Name = "Explosive Staff",
                    Power = 60,
                    Type = "weapon",
                    Image = "https://i.imgur.com/u0JVNz2.png"
                };

                Item w12 = new Item
                {
                    Id = 20,
                    Name = "Fire Wand",
                    Power = 35,
                    Type = "weapon",
                    Image = "https://i.imgur.com/Hx5cg5S.png"
                };

                Item w13 = new Item
                {
                    Id = 21,
                    Name = "Ice Wand",
                    Power = 40,
                    Type = "weapon",
                    Image = "https://i.imgur.com/Do8tVyQ.png"
                };

                Item o1 = new Item
                {
                    Id = 22,
                    Name = "Golden Ball",
                    Power = 0,
                    Type = "other",
                    Image = "https://i.imgur.com/RvJZNk9.jpg"
                };

                Item o2 = new Item
                {
                    Id = 23,
                    Name = "Golden Paddle",
                    Power = 0,
                    Type = "other",
                    Image = "https://i.imgur.com/feoJp0d.png"
                };

                Item o3 = new Item
                {
                    Id = 24,
                    Name = "Golden Sweat Bands",
                    Power = 0,
                    Type = "other",
                    Image = "https://i.imgur.com/x28nL5x.png"
                };

                Item o4 = new Item
                {
                    Id = 25,
                    Name = "Small Potion",
                    Power = 50,
                    Type = "heal",
                    Image = "https://i.imgur.com/EmmAL5V.png"
                };

                Item o5 = new Item
                {
                    Id = 26,
                    Name = "Medium Potion",
                    Power = 100,
                    Type = "heal",
                    Image = "https://i.imgur.com/qDkCEFe.png"
                };

                Item o6 = new Item
                {
                    Id = 27,
                    Name = "Large Potion",
                    Power = 200,
                    Type = "heal",
                    Image = "https://i.imgur.com/DdBNUSi.png"
                };
            }
        }
        // GET: api/Items
        [HttpGet]
        public IEnumerable<Item> GetItem()
        {
            return _context.Item;
        }

        // GET: api/Items/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetItem([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = await _context.Item.SingleOrDefaultAsync(m => m.Id == id);

            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        // PUT: api/Items/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItem([FromRoute] int id, [FromBody] Item item)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Items
        [HttpPost]
        public async Task<IActionResult> PostItem([FromBody] Item item)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Item.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetItem", new { id = item.Id }, item);
        }

        // DELETE: api/Items/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = await _context.Item.SingleOrDefaultAsync(m => m.Id == id);
            if (item == null)
            {
                return NotFound();
            }

            _context.Item.Remove(item);
            await _context.SaveChangesAsync();

            return Ok(item);
        }

        private bool ItemExists(int id)
        {
            return _context.Item.Any(e => e.Id == id);
        }
    }
}