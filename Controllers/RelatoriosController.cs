using ApiInfoDengue.Application;
using ApiInfoDengue.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ApiInfoDengue.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RelatoriosController : ControllerBase
    {
        private readonly RelatorioService _relatorioService;

        public RelatoriosController(RelatorioService relatorioService)
        {
            _relatorioService = relatorioService;
        }

        [HttpGet]
        public async Task<IActionResult> GetRelatorios()
        {
            var relatorios = await _relatorioService.GetRelatoriosAsync();
            return Ok(relatorios);
        }

        [HttpPost]
        public async Task<IActionResult> AddRelatorio([FromBody] Relatorio relatorio)
        {
            await _relatorioService.AddRelatorioAsync(relatorio);
            return CreatedAtAction(nameof(GetRelatorios), new { id = relatorio.Id }, relatorio);
        }
    }
}
