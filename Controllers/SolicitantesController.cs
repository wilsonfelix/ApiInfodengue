using ApiInfoDengue.Infrastructure;
using ApiInfoDengue.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiInfodengue.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SolicitantesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SolicitantesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Solicitante solicitante)
        {
            if (await _context.Solicitantes.AnyAsync(s => s.CPF == solicitante.CPF))
                return BadRequest("CPF já cadastrado.");

            _context.Solicitantes.Add(solicitante);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = solicitante.Id }, solicitante);
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var solicitante = await _context.Solicitantes.FindAsync(id);
            if (solicitante == null) return NotFound();
            return Ok(solicitante);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _context.Solicitantes.ToListAsync());
        }
    }
}
