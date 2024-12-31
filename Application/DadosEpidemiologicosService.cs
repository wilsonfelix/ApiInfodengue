using ApiInfoDengue.Domain;
using ApiInfoDengue.Infrastructure;

namespace ApiInfoDengue.Application
{
    public class DadosEpidemiologicosService
    {
        private readonly AppDbContext _context;
        private readonly InfoDengueApiService _apiService;

        public DadosEpidemiologicosService(AppDbContext context, InfoDengueApiService apiService)
        {
            _context = context;
            _apiService = apiService;
        }

        public async Task<List<DadosEpidemiologicos>> ConsultarEArmazenarDados(string geocode, string disease, int ewStart, int ewEnd, int eyStart, int eyEnd)
        {
            var apiResponse = await _apiService.ConsultarDadosEpidemiologicos(geocode, disease, ewStart, ewEnd, eyStart, eyEnd);

            var dados = new List<DadosEpidemiologicos>();
            foreach (var item in apiResponse)
            {
                var dado = new DadosEpidemiologicos
                {
                    CodigoIBGE = geocode,
                    Doenca = disease,
                    //DataInicio = DateTime.Parse(item.data_iniSE.ToString()),
                    //DataFim = DateTime.Parse(item.data_fimSE.ToString()),
                    CasosEstimadosMin = item.CasosEstMin.Value,
                    CasosEstimadosMax = item.CasosEstMax.Value,
                    Incidencia = item.PInc100K.Value
                };

                _context.DadosEpidemiologicos.Add(dado);
                dados.Add(dado);
            }

            await _context.SaveChangesAsync();
            return dados;
        }
    }
}
