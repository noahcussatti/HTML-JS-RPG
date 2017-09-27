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
    [Route("api/Locations")]
    public class LocationsController : Controller
    {
        private readonly SnoahRpgContext _context;

        public LocationsController(SnoahRpgContext context)
        {
            _context = context;


            if (_context.Location.Count() == 0)
            {
                Location l1 = new Location
                {
                    Id = 1,
                    Name = "Forest 1",
                    Image = "https://i.imgur.com/1LEQutv.jpg"
                };

                Location l2 = new Location
                {
                    Id = 2,
                    Name = "Forest 2",
                    Image = "https://i.imgur.com/1JZezCN.jpg"
                };

                Location l3 = new Location
                {
                    Id = 3,
                    Name = "Forest 3",
                    Image = "https://i.imgur.com/oz9if8c.jpg"
                };

                Location l4 = new Location
                {
                    Id = 4,
                    Name = "Forest 4",
                    Image = "https://i.imgur.com/VXfa18m.jpg"
                };

                Location l5 = new Location
                {
                    Id = 5,
                    Name = "Forest 4 To Mountain",
                    Image = "https://i.imgur.com/ltJBFcR.jpg"
                };

                Location l6 = new Location
                {
                    Id = 6,
                    Name = "Mountain 1",
                    Image = "https://i.imgur.com/FOuIIrh.jpg"
                };

                Location l7 = new Location
                {
                    Id = 7,
                    Name = "CMountain",
                    Image = "https://i.imgur.com/sTVbIic.jpg"
                };

                Location l8 = new Location
                {
                    Id = 8,
                    Name = "Mountain 3",
                    Image = "https://i.imgur.com/lvASEcX.jpg"
                };

                Location l9 = new Location
                {
                    Id = 9,
                    Name = "Mountain 3 Snow Mountain",
                    Image = "https://i.imgur.com/DQSZAXn.jpg"
                };

                Location l10 = new Location
                {
                    Id = 10,
                    Name = "Snow 1",
                    Image = "https://i.imgur.com/FgVVgpR.jpg"
                };
                Location l11 = new Location
                {
                    Id = 11,
                    Name = "Snow 2",
                    Image = "https://i.imgur.com/YcptPDb.jpg"
                };

                Location l12 = new Location
                {
                    Id = 12,
                    Name = "Snow 3",
                    Image = "https://i.imgur.com/FgVVgpR.jpg"
                };

                Location l13 = new Location
                {
                    Id = 13,
                    Name = "Snow 4",
                    Image = "https://i.imgur.com/wwFEqED.jpg"
                };

                Location l14 = new Location
                {
                    Id = 14,
                    Name = "Snow 5",
                    Image = "https://i.imgur.com/gXhpBPQ.jpg"
                };

                Location l15 = new Location
                {
                    Id = 15,
                    Name = "Rocky Path 1",
                    Image = "https://i.imgur.com/Iv6psXn.jpg"
                };

                Location l16 = new Location
                {
                    Id = 16,
                    Name = "Rocky Path 2",
                    Image = "https://i.imgur.com/dtY1r3N.jpg"
                };

                Location l17 = new Location
                {
                    Id = 17,
                    Name = "Volcano 1",
                    Image = "https://i.imgur.com/vvcBzQ4.jpg"
                };

                Location l18 = new Location
                {
                    Id = 18,
                    Name = "Volcano 2",
                    Image = "https://i.imgur.com/LCEnJkp.jpg"
                };

                Location l19 = new Location
                {
                    Id = 19,
                    Name = "Volcano 3",
                    Image = "https://i.imgur.com/bUrg6dV.jpg"
                };

                Location l20 = new Location
                {
                    Id = 20,
                    Name = "Volcano 4",
                    Image = "https://i.imgur.com/fxI262Dg.jpg"
                };

                Location l21 = new Location
                {
                    Id = 21,
                    Name = "Volcano 5",
                    Image = "https://i.imgur.com/E5htIss.jpg"
                };

                Location l22 = new Location
                {
                    Id = 22,
                    Name = "Castle 1",
                    Image = "https://i.imgur.com/DxHULEV.jpg"
                };

                Location l23 = new Location
                {
                    Id = 23,
                    Name = "Castle 2",
                    Image = "https://i.imgur.com/Eea85aq.jpg"
                };

                Location l24 = new Location
                {
                    Id = 24,
                    Name = "Castle 3",
                    Image = "https://i.imgur.com/VETxcXf.jpg"
                };

                Location l25 = new Location
                {
                    Id = 25,
                    Name = "Castle 4",
                    Image = "https://i.imgur.com/UNgvAor.jpg"
                };

                Location l26 = new Location
                {
                    Id = 26,
                    Name = "Castle Hidden Room 1",
                    Image = "https://i.imgur.com/M1NEFEq.jpg"
                };

                Location l27 = new Location
                {
                    Id = 27,
                    Name = "Castle Hidden Room 2",
                    Image = "https://i.imgur.com/s6zpFNL.jpg"
                };

                Location l28 = new Location
                {
                    Id = 28,
                    Name = "Desert 1",
                    Image = "https://i.imgur.com/ivnnPAu.jpg"
                };

                Location l29 = new Location
                {
                    Id = 29,
                    Name = "Desert 2",
                    Image = "https://i.imgur.com/rnkx7BN.jpg"
                };

                Location l30 = new Location
                {
                    Id = 30,
                    Name = "Desert 3",
                    Image = "https://i.imgur.com/op6K9AR.jpg"
                };

                Location l31 = new Location
                {
                    Id = 31,
                    Name = "Desert 3 Cave 1",
                    Image = "https://i.imgur.com/PEGIMJ9.jpg"
                };

                Location l32 = new Location
                {
                    Id = 32,
                    Name = "Desert 3 Cave 2",
                    Image = "https://i.imgur.com/9HVBQJM.jpg"
                };

                Location l33 = new Location
                {
                    Id = 33,
                    Name = "Desert 4",
                    Image = "https://i.imgur.com/43sMyuW.jpg"
                };

                Location l34 = new Location
                {
                    Id = 34,
                    Name = "Desert 5 (Oasis 1)",
                    Image = "https://i.imgur.com/ttAZqXU.jpg"
                };

                Location l35 = new Location
                {
                    Id = 35,
                    Name = "Oasis 2",
                    Image = "https://i.imgur.com/7PNVIzU.jpg"
                };

                Location l36 = new Location
                {
                    Id = 36,
                    Name = "Oasis 3",
                    Image = "https://i.imgur.com/5b3bvbT.jpg"
                };

                Location l37 = new Location
                {
                    Id = 37,
                    Name = "Oasis 4",
                    Image = "https://i.imgur.com/Pr3fzzh.jpg"
                };

                Location l38 = new Location
                {
                    Id = 38,
                    Name = "Ruins 1",
                    Image = "https://i.imgur.com/ySWJX0x.jpg"
                };

                 Location l39 = new Location
                {
                    Id = 39,
                    Name = "Ruins 2",
                    Image = "https://i.imgur.com/h4Kij1b.jpg"
                };

                 Location l40 = new Location
                {
                    Id = 40,
                    Name = "Ruins 2 (Right)",
                    Image = "https://i.imgur.com/E1sEBPj.jpg"
                };

                 Location l41 = new Location
                {
                    Id = 41,
                    Name = "Ruins 2 (Left)",
                    Image = "https://i.imgur.com/yVHOvzpg.jpg"
                };

                 Location l42 = new Location
                {
                    Id = 42,
                    Name = "Ruins 3 (Left)",
                    Image = "https://i.imgur.com/m00FbKj.jpg"
                };

                 Location l43 = new Location
                {
                    Id = 43,
                    Name = "Cave 1",
                    Image = "https://i.imgur.com/cUfMnf8.jpg"
                };

                Location l44 = new Location
                {
                    Id = 44,
                    Name = "Cave 2",
                    Image = "https://i.imgur.com/QUNi8wN.jpg"
                };

                Location l45 = new Location
                {
                    Id = 45,
                    Name = "Cloud City 1",
                    Image = "https://i.imgur.com/sKG8TGz.jpg"
                };

                Location l46 = new Location
                {
                    Id = 46,
                    Name = "Cloud City 2",
                    Image = "https://i.imgur.com/awh2Lzd.jpg"
                };

            }
        }

        // GET: api/Locations
        [HttpGet]
        public IEnumerable<Location> GetLocation()
        {
            return _context.Location;
        }

        // GET: api/Locations/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetLocation([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var location = await _context.Location.SingleOrDefaultAsync(m => m.Id == id);

            if (location == null)
            {
                return NotFound();
            }

            return Ok(location);
        }

        // PUT: api/Locations/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLocation([FromRoute] int id, [FromBody] Location location)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != location.Id)
            {
                return BadRequest();
            }

            _context.Entry(location).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocationExists(id))
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

        // POST: api/Locations
        [HttpPost]
        public async Task<IActionResult> PostLocation([FromBody] Location location)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Location.Add(location);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLocation", new { id = location.Id }, location);
        }

        // DELETE: api/Locations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLocation([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var location = await _context.Location.SingleOrDefaultAsync(m => m.Id == id);
            if (location == null)
            {
                return NotFound();
            }

            _context.Location.Remove(location);
            await _context.SaveChangesAsync();

            return Ok(location);
        }

        private bool LocationExists(int id)
        {
            return _context.Location.Any(e => e.Id == id);
        }
    }
}