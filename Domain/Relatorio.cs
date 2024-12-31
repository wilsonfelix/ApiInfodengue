namespace ApiInfoDengue.Domain
{
    public class Relatorio
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime DataSolicitacao { get; set; } = DateTime.UtcNow;
        public string Arbovirose { get; set; } = string.Empty;
        public int SemanaInicio { get; set; }
        public int SemanaFim { get; set; }
        public string CodigoIBGE { get; set; } = string.Empty;
        public string Municipio { get; set; } = string.Empty;
        public Guid SolicitanteId { get; set; }
        public Solicitante? Solicitante { get; set; }
    }
}
