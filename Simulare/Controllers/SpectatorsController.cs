using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Simulare.Data;
using Simulare.Models;

namespace Simulare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpectatorsController : ControllerBase
    {
        private readonly SimulareContext _context;

        public SpectatorsController(SimulareContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Spectator>>> GetSpectators()
        {
            return await _context.Spectators.ToListAsync();
        }

        
        [HttpPost]
        public async Task<ActionResult<Spectator>> PostSpectator(Spectator spectator)
        {
            _context.Spectators.Add(spectator);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SpectatorExists(spectator.ParticipantId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSpectator", new { id = spectator.ParticipantId }, spectator);
        }

       

        private bool SpectatorExists(int id)
        {
            return _context.Spectators.Any(e => e.ParticipantId == id);
        }
    }
}
