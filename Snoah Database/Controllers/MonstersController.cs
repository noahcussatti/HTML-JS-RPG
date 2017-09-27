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
    [Route("api/Monsters")]
    public class MonstersController : Controller
    {
        private readonly SnoahRpgContext _context;

        public MonstersController(SnoahRpgContext context)
        {
            _context = context;
            if (_context.Monster.Count() == 0)
            {
                Monster m1 = new Monster
                {
                    Id = 1,
                    Name = "Goblin",
                    Health = 50,
                    Power = 10,
                    Image = "https://imgur.com/XckJ1D3",
                    CurrentChest = new Item
                    {
                        Id = 4,
                        Name = "Chainmail Helm",
                        Power = 10,
                        Type = "helmet",
                        Image = "https://i.imgur.com/gyIHymO.png",
                    },
                    CurrentWrist = new Item
                    {
                        Id = 8,
                        Name = "Leather Bracers",
                        Power = 5,
                        Type = "wrists",
                        Image = "https://i.imgur.com/iAdsqt0.png"
                    },
                    CurrentWeapon = new Item
                    {
                        Id = 13,
                        Name = "Wooden Sword",
                        Power = 7,
                        Type = "weapon",
                        Image = "https://i.imgur.com/B6Ul0mf.jpg"
                    }
                };

                Monster m2 = new Monster
                {
                    Id = 2,
                    Name = "Ork",
                    Health = 100,
                    Power = 10,
                    Image = "https://i.imgur.com/PYGVUix.png",
                    CurrentHelmet = new Item
                    {
                        Id = 2,
                        Name = "Chainmail Helm",
                        Power = 10,
                        Type = "helmet",
                        Image = "https://i.imgur.com/G3rbn1J.png"
                    },
                    CurrentChest = new Item
                    {
                        Id = 6,
                        Name = "Chainmail Armor",
                        Power = 20,
                        Type = "chest",
                        Image = "https://i.imgur.com/uuDawKP.png"
                    },
                    CurrentWrist = new Item
                    {
                        Id = 6,
                        Name = "Iron Bracers",
                        Power = 6,
                        Type = "wrist"
                    },
                    CurrentWeapon = new Item
                    {
                        Id = 10,
                        Name = "Morning Star",
                        Power = 20,
                        Type = "weapon",
                        Image = "https://i.imgur.com/47MXsHr.png"
                    }
                };
                Monster m4 = new Monster
                {
                    Id = 4,
                    Name = "Cactus Patch Kid",
                    Health = 50,
                    Power = 20,
                    Image = "https://i.imgur.com/qKEAK4k.jpg",
                    CurrentHelmet = null,
                    CurrentChest = null,
                    CurrentWrist = null,
                    CurrentWeapon = null
                };

                Monster m5 = new Monster
                {
                    Id = 5,
                    Name = "Desert Yeti",
                    Health = 100,
                    Power = 10,
                    Image = "https://i.imgur.com/O9AH2iE.png",
                    CurrentHelmet = null,
                    CurrentChest = null,
                    CurrentWrist = null,
                    CurrentWeapon = null
                };

                Monster m6 = new Monster
                {
                    Id = 6,
                    Name = "Evil Hotdog",
                    Health = 200,
                    Power = 20,
                    Image = "https://i.imgur.com/vRWj8Yt.png",
                    CurrentHelmet = null,
                    CurrentChest = null,
                    CurrentWrist = null,
                    CurrentWeapon = null
                };

                Monster m7 = new Monster
                {
                    Id = 7,
                    Name = "Evil Knight",
                    Health = 150,
                    Power = 30,
                    Image = "https://i.imgur.com/UlqCtjh.png",
                    CurrentHelmet = new Item
                    {
                        Id = 3,
                        Name = "Plate Helm",
                        Power = 20,
                        Type = "helmet",
                        Image = "https://i.imgur.com/MSLjTpx.png",
                    },
                    CurrentChest = new Item
                    {
                        Id = 7,
                        Name = "Plate Armor",
                        Power = 25,
                        Type = "chest",
                        Image = "https://i.imgur.com/ilIaLPc.png"
                    },
                    CurrentWrist = new Item
                    {
                        Id = 6,
                        Name = "Iron Bracers",
                        Power = 6,
                        Type = "wrist"
                    },
                    CurrentWeapon = new Item
                    {
                        Id = 14,
                        Name = "Long Sword",
                        Power = 30,
                        Type = "weapon",
                        Image = "https://i.imgur.com/qFl4976.png"
                    }
                };

                Monster m8 = new Monster
                {
                    Id = 8,
                    Name = "Dark Mage",
                    Health = 100,
                    Power = 25,
                    Image = "https://i.imgur.com/i7gpSkr.png",
                    CurrentHelmet = null,
                    CurrentChest = new Item
                    {
                        Id = 5,
                        Name = "Quilted Armor",
                        Power = 15,
                        Type = "chest",
                        Image = "https://i.imgur.com/9oadoje.png"
                    },
                    CurrentWrist = null,
                    CurrentWeapon = new Item
                    {
                        Id = 20,
                        Name = "Fire Wand",
                        Power = 35,
                        Type = "weapon",
                        Image = "https://i.imgur.com/Hx5cg5S.png"
                    }
                };

                Monster m9 = new Monster
                {
                    Id = 9,
                    Name = "Frozen Banshee",
                    Health = 150,
                    Power = 20,
                    Image = "https://i.imgur.com/7z1Ovo2.png",
                    CurrentHelmet = null,
                    CurrentChest = null,
                    CurrentWrist = null,
                    CurrentWeapon = new Item
                    {
                        Id = 21,
                        Name = "Ice Wand",
                        Power = 40,
                        Type = "weapon",
                        Image = "https://i.imgur.com/Do8tVyQ.png"
                    }
                };

                Monster m10 = new Monster
                {
                    Id = 10,
                    Name = "Frost Troll",
                    Health = 100,
                    Power = 12,
                    Image = "https://i.imgur.com/p3esL4H.jpg",
                    CurrentHelmet = new Item
                    {
                        Id = 2,
                        Name = "Chainmail Helm",
                        Power = 10,
                        Type = "helmet",
                        Image = "https://i.imgur.com/G3rbn1J.png"
                    },
                    CurrentChest = new Item
                    {
                        Id = 6,
                        Name = "Chainmail Armor",
                        Power = 20,
                        Type = "chest",
                        Image = "https://i.imgur.com/uuDawKP.png"
                    },
                    CurrentWrist = new Item
                    {
                        Id = 6,
                        Name = "Iron Bracers",
                        Power = 6,
                        Type = "wrist"
                    },
                    CurrentWeapon = null
                };

                Monster m11 = new Monster
                {
                    Id = 11,
                    Name = "Giant Snake",
                    Health = 200,
                    Power = 10,
                    Image = "https://i.imgur.com/eRN11KR.png",
                    CurrentHelmet = null,
                    CurrentChest = null,
                    CurrentWrist = null,
                    CurrentWeapon = null
                };

                Monster m12 = new Monster
                {
                    Id = 12,
                    Name = "Lava Dragon",
                    Health = 300,
                    Power = 10,
                    Image = "https://i.imgur.com/LROimXT.jpg",
                    CurrentHelmet = null,
                    CurrentChest = null,
                    CurrentWrist = null,
                    CurrentWeapon = new Item
                    {
                        Id = 18,
                        Name = "Dragon Dagger",
                        Power = 50,
                        Type = "weapon",
                        Image = "https://i.imgur.com/kwPiOCK.png"
                    }
                };

                Monster m13 = new Monster
                {
                    Id = 13,
                    Name = "Magma Snake",
                    Health = 150,
                    Power = 10,
                    Image = "https://i.imgur.com/vY9qsKA.png",
                    CurrentHelmet = null,
                    CurrentChest = null,
                    CurrentWrist = null,
                    CurrentWeapon = null
                };

                Monster m14 = new Monster
                {
                    Id = 14,
                    Name = "Muad' Dib",
                    Health = 75,
                    Power = 15,
                    Image = "https://i.imgur.com/XwCpGCs.png",
                    CurrentHelmet = null,
                    CurrentChest = new Item
                    {
                        Id = 26,
                        Name = "Medium Potion",
                        Power = 100,
                        Type = "heal",
                        Image = "https://i.imgur.com/qDkCEFe.png"
                    },
                    CurrentWrist = null,
                    CurrentWeapon = new Item
                    {
                        Id = 17,
                        Name = "Twin Daggers",
                        Power = 25,
                        Type = "weapon",
                        Image = "https://i.imgur.com/1BCiVsW.png"
                    }
                };

                Monster m15 = new Monster
                {
                    Id = 15,
                    Name = "Mummy",
                    Health = 200,
                    Power = 5,
                    Image = "https://i.imgur.com/DbxfIiD.png",
                    CurrentHelmet = new Item
                    {
                        Id = 27,
                        Name = "Large Potion",
                        Power = 200,
                        Type = "heal",
                        Image = "https://i.imgur.com/DdBNUSi.png"
                    },
                    CurrentChest = new Item
                    {
                        Id = 26,
                        Name = "Medium Potion",
                        Power = 100,
                        Type = "heal",
                        Image = "https://i.imgur.com/qDkCEFe.png"
                    },
                    CurrentWrist = null,
                    CurrentWeapon = new Item
                    {
                        Id = 27,
                        Name = "Large Potion",
                        Power = 200,
                        Type = "heal",
                        Image = "https://i.imgur.com/DdBNUSi.png"
                    }
                };

                Monster m16 = new Monster
                {
                    Id = 16,
                    Name = "Old Man",
                    Health = 30,
                    Power = 1,
                    Image = "https://i.imgur.com/Ue8lKY1.png",
                    CurrentHelmet = new Item
                    {
                        Id = 27,
                        Name = "Large Potion",
                        Power = 200,
                        Type = "heal",
                        Image = "https://i.imgur.com/DdBNUSi.png"
                    },
                    CurrentChest = new Item
                    {
                        Id = 26,
                        Name = "Medium Potion",
                        Power = 100,
                        Type = "heal",
                        Image = "https://i.imgur.com/qDkCEFe.png"
                    },
                    CurrentWrist = null,
                    CurrentWeapon = new Item
                    {
                        Id = 27,
                        Name = "Large Potion",
                        Power = 200,
                        Type = "heal",
                        Image = "https://i.imgur.com/DdBNUSi.png"
                    }
                };

                Monster m17 = new Monster
                {
                    Id = 17,
                    Name = "Rock Golem",
                    Health = 200,
                    Power = 10,
                    Image = "https://i.imgur.com/pBKoMd6.png",
                    CurrentHelmet = new Item
                    {
                        Id = 27,
                        Name = "Large Potion",
                        Power = 200,
                        Type = "heal",
                        Image = "https://i.imgur.com/DdBNUSi.png"
                    },
                    CurrentChest = new Item
                    {
                        Id = 26,
                        Name = "Medium Potion",
                        Power = 100,
                        Type = "heal",
                        Image = "https://i.imgur.com/qDkCEFe.png"
                    },
                    CurrentWrist = null,
                    CurrentWeapon = new Item
                    {
                        Id = 11,
                        Name = "War Hammer",
                        Power = 40,
                        Type = "weapon",
                        Image = "https://i.imgur.com/nNjnfMu.png"
                    }
                };

                Monster m18 = new Monster
                {
                    Id = 18,
                    Name = "Sand Worm",
                    Health = 100,
                    Power = 15,
                    Image = "https://i.imgur.com/PSJ2dEv.png",
                    CurrentHelmet = new Item
                    {
                        Id = 27,
                        Name = "Large Potion",
                        Power = 200,
                        Type = "heal",
                        Image = "https://i.imgur.com/DdBNUSi.png"
                    },
                    CurrentChest = new Item
                    {
                        Id = 26,
                        Name = "Medium Potion",
                        Power = 100,
                        Type = "heal",
                        Image = "https://i.imgur.com/qDkCEFe.png"
                    },
                    CurrentWrist = null,
                    CurrentWeapon = null
                };

                Monster m19 = new Monster
                {
                    Id = 19,
                    Name = "Ice Golem",
                    Health = 300,
                    Power = 10,
                    Image = "https://i.imgur.com/1Aj1njR.png",
                    CurrentHelmet = new Item
                    {
                        Id = 3,
                        Name = "Plate Helm",
                        Power = 20,
                        Type = "helmet",
                        Image = "https://i.imgur.com/MSLjTpx.png"
                    },
                    CurrentChest = new Item
                    {
                        Id = 7,
                        Name = "Plate Armor",
                        Power = 25,
                        Type = "chest",
                        Image = "https://i.imgur.com/ilIaLPc.png"
                    },
                    CurrentWrist = null,
                    CurrentWeapon = new Item
                    {
                        Id = 9,
                        Name = "Maul",
                        Power = 60,
                        Type = "weapon",
                        Image = "https://i.imgur.com/hXAEbM1.png"
                    }
                };

                Monster m20 = new Monster
                {
                    Id = 20,
                    Name = "Noah after this Week",
                    Health = 200,
                    Power = 20,
                    Image = "https://i.imgur.com/C7pmDXw.png",
                    CurrentHelmet = new Item
                    {
                        Id = 27,
                        Name = "Dank Meme Sauce",
                        Power = 200,
                        Type = "heal",
                        Image = "https://i.imgur.com/DdBNUSi.png"
                    },
                    CurrentChest = new Item
                    {
                        Id = 26,
                        Name = "Meme Sauce",
                        Power = 100,
                        Type = "heal",
                        Image = "https://i.imgur.com/qDkCEFe.png"
                    },
                    CurrentWrist = null,
                    CurrentWeapon = null
                };

                Monster m21 = new Monster
                {
                    Id = 21,
                    Name = "Toxic Cloud",
                    Health = 100,
                    Power = 10,
                    Image = "https://i.imgur.com/l0hl017.png",
                    CurrentHelmet = null,
                    CurrentChest = null,
                    CurrentWrist = null,
                    CurrentWeapon = null
                };

                Monster m22 = new Monster
                {
                    Id = 22,
                    Name = "Vicious Cloud Dog",
                    Health = 75,
                    Power = 15,
                    Image = "https://i.imgur.com/tgvAYnF.jpg",
                    CurrentHelmet = null,
                    CurrentChest = null,
                    CurrentWrist = null,
                    CurrentWeapon = null
                };

                Monster m23 = new Monster
                {
                    Id = 23,
                    Name = "Imp",
                    Health = 250,
                    Power = 15,
                    Image = "https://i.imgur.com/iCaGpRE.png",
                    CurrentHelmet = null,
                    CurrentChest = null,
                    CurrentWrist = null,
                    CurrentWeapon = new Item
                    {
                        Id = 19,
                        Name = "Explosive Staff",
                        Power = 60,
                        Type = "weapon",
                        Image = "https://i.imgur.com/u0JVNz2.png"
                    }
                };

                Monster m24 = new Monster
                {
                    Id = 24,
                    Name = "Wolf",
                    Health = 55,
                    Power = 5,
                    Image = "https://i.imgur.com/AvbsjzM.png",
                    CurrentHelmet = null,
                    CurrentChest = null,
                    CurrentWrist = null,
                    CurrentWeapon = null
                };

                Monster m25 = new Monster
                {
                    Id = 25,
                    Name = "King of Redwood",
                    Health = 400,
                    Power = 30,
                    Image = "https://i.imgur.com/QeYrLVx.png",
                    CurrentHelmet = new Item
                    {
                        Id = 3,
                        Name = "Plate Helm",
                        Power = 20,
                        Type = "helmet",
                        Image = "https://i.imgur.com/MSLjTpx.png"
                    },
                    CurrentChest = new Item
                    {
                        Id = 7,
                        Name = "Plate Armor",
                        Power = 25,
                        Type = "Chest",
                        Image = "https://i.imgur.com/ilIaLPc.png"
                    },
                    CurrentWrist = null,
                    CurrentWeapon = new Item
                    {
                        Id = 15,
                        Name = "EPIC Sword",
                        Power = 70,
                        Type = "weapon",
                        Image = "https://i.imgur.com/poj0jfC.png"
                    }
                };

                Monster m26 = new Monster
                {
                    Id = 26,
                    Name = "Hooded Figure",
                    Health = 500,
                    Power = 50,
                    Image = "https://i.imgur.com/QeYrLVx.png",
                    CurrentHelmet = null,
                    CurrentChest = null,
                    CurrentWrist = null,
                    CurrentWeapon = null
                };
            }
        }

        // GET: api/Monsters
        [HttpGet]
        public IEnumerable<Monster> GetMonster()
        {
            return _context.Monster;
        }

        // GET: api/Monsters/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMonster([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var monster = await _context.Monster.SingleOrDefaultAsync(m => m.Id == id);

            if (monster == null)
            {
                return NotFound();
            }

            return Ok(monster);
        }

        // PUT: api/Monsters/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMonster([FromRoute] int id, [FromBody] Monster monster)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != monster.Id)
            {
                return BadRequest();
            }

            _context.Entry(monster).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MonsterExists(id))
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

        // POST: api/Monsters
        [HttpPost]
        public async Task<IActionResult> PostMonster([FromBody] Monster monster)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Monster.Add(monster);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMonster", new { id = monster.Id }, monster);
        }

        // DELETE: api/Monsters/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMonster([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var monster = await _context.Monster.SingleOrDefaultAsync(m => m.Id == id);
            if (monster == null)
            {
                return NotFound();
            }

            _context.Monster.Remove(monster);
            await _context.SaveChangesAsync();

            return Ok(monster);
        }

        private bool MonsterExists(int id)
        {
            return _context.Monster.Any(e => e.Id == id);
        }
    }
}