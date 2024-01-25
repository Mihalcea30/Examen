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
    public class OrganizatorsController : ControllerBase
    {
        private readonly SimulareContext _context;

        public OrganizatorsController(SimulareContext context)
        {
            _context = context;
        }

      
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Organizator>>> GetOrganizatori()
        {
            return await _context.Organizatori.ToListAsync();
        }

        
        [HttpPost]
        public async Task<ActionResult<Organizator>> PostOrganizator(Organizator organizator)
        {
            _context.Organizatori.Add(organizator);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (OrganizatorExists(organizator.ParticipantId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetOrganizator", new { id = organizator.ParticipantId }, organizator);
        }

       

        private bool OrganizatorExists(int id)
        {
            return _context.Organizatori.Any(e => e.ParticipantId == id);
        }
    }
}
