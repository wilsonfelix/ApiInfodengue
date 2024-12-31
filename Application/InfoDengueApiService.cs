using System.Net.Http;
using System.Threading.Tasks;
using ApiInfoDengue.DTOs;
using Newtonsoft.Json;

namespace ApiInfoDengue.Application
{
    public class InfoDengueApiService
    {
        private readonly HttpClient _httpClient;

        public InfoDengueApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<DadosEpidemiologicoDto>> ConsultarDadosEpidemiologicos(string geocode, string disease, int ewStart, int ewEnd, int eyStart, int eyEnd)
        {
            string url = $"https://info.dengue.mat.br/api/alertcity/" +
                         $"?geocode={geocode}&disease={disease}&format=json" +
                         $"&ew_start={ewStart}&ew_end={ewEnd}&ey_start={eyStart}&ey_end={eyEnd}";

            var response = await _httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<DadosEpidemiologicoDto>>(content)!;
            }

            throw new HttpRequestException($"Erro ao consultar API: {response.StatusCode}");
        }
    }
}
