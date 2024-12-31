using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ApiInfoDengue.DTOs
{
    public record DadosEpidemiologicoDto
    {
        [JsonProperty("data_iniSE")]
        public long? DataIniSe { get; set; }

        [JsonProperty("SE")]
        public long? Se { get; set; }

        [JsonProperty("casos_est")]
        public long? CasosEst { get; set; }

        [JsonProperty("casos_est_min")]
        public int? CasosEstMin { get; set; }

        [JsonProperty("casos_est_max")]
        public int? CasosEstMax { get; set; }

        [JsonProperty("casos")]
        public int? Casos { get; set; }

        [JsonProperty("p_rt1")]
        public float? PRt1 { get; set; }

        [JsonProperty("p_inc100k")]
        public float? PInc100K { get; set; }

        [JsonProperty("Localidade_id")]
        public long? LocalidadeId { get; set; }

        [JsonProperty("nivel")]
        public long? Nivel { get; set; }

        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("versao_modelo")]
        public DateTime? VersaoModelo { get; set; }

        [JsonProperty("tweet")]
        public object? Tweet { get; set; }

        [JsonProperty("Rt")]
        public double? Rt { get; set; }

        [JsonProperty("pop")]
        public long? Pop { get; set; }

        [JsonProperty("tempmin")]
        public double? Tempmin { get; set; }

        [JsonProperty("umidmax")]
        public double? Umidmax { get; set; }

        [JsonProperty("receptivo")]
        public long? Receptivo { get; set; }

        [JsonProperty("transmissao")]
        public long? Transmissao { get; set; }

        [JsonProperty("nivel_inc")]
        public long? NivelInc { get; set; }

        [JsonProperty("umidmed")]
        public float? Umidmed { get; set; }

        [JsonProperty("umidmin")]
        public float? Umidmin { get; set; }

        [JsonProperty("tempmed")]
        public float? Tempmed { get; set; }

        [JsonProperty("tempmax")]
        public float? Tempmax { get; set; }

        [JsonProperty("casprov")]
        public float? Casprov { get; set; }

        [JsonProperty("casprov_est")]
        public float? CasprovEst { get; set; }

        [JsonProperty("casprov_est_min")]
        public float? CasprovEstMin { get; set; }

        [JsonProperty("casprov_est_max")]
        public float? CasprovEstMax { get; set; }

        [JsonProperty("casconf")]
        public float? Casconf { get; set; }

        [JsonProperty("notif_accum_year")]
        public long? NotifAccumYear { get; set; }
    }
}
