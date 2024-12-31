namespace ApiInfoDengue.Domain
{
    public class DadosEpidemiologicos
    {
        public int Id { get; set; }
        public string CodigoIBGE { get; set; } = string.Empty;
        public string Doenca { get; set; } = string.Empty;
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int CasosEstimadosMin { get; set; }
        public int CasosEstimadosMax { get; set; }
        public float Incidencia { get; set; }
    }
}
