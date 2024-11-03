using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClienteApi.Data;
using ClienteApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InformacionGeneralController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public InformacionGeneralController(ApplicationDbContext context)
        {
            _context = context;
        }

        // POST: api/informaciongeneral
        [HttpPost]
        public async Task<ActionResult<InformacionGeneral>> CrearInformacion(InformacionGeneral info)
        {
            _context.InformacionGenerales.Add(info);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetInformacion", new { id = info.Id }, info);
        }

        // GET: api/informaciongeneral
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InformacionGeneral>>> ListarInformacionGeneral()
        {
            return await _context.InformacionGenerales.OrderBy(info => info.FechaCreacion).ToListAsync();
        }
    }
}
