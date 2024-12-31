namespace ApiInfoDengue.Domain
{
    public class Solicitante
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public ICollection<Relatorio> Relatorios { get; set; } = new List<Relatorio>();
    }
}
