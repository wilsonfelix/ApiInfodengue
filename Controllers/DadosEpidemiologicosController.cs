using ApiInfoDengue.Application;
using Microsoft.AspNetCore.Mvc;

namespace ApiInfodengue.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DadosEpidemiologicosController : ControllerBase
    {
        private readonly DadosEpidemiologicosService _service;

        public DadosEpidemiologicosController(DadosEpidemiologicosService service)
        {
            _service = service;
        }

        [HttpGet("consultar")]
        public async Task<IActionResult> Consultar(string geocode, string disease, int ewStart, int ewEnd, int eyStart, int eyEnd)
        {
            try
            {
                var dados = await _service.ConsultarEArmazenarDados(geocode, disease, ewStart, ewEnd, eyStart, eyEnd);
                return Ok(dados);
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = ex.Message });
            }
        }
    }
}
