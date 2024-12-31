using ApiInfoDengue.Infrastructure;
using ApiInfoDengue.Domain;
using Microsoft.EntityFrameworkCore;

namespace ApiInfoDengue.Application
{
    public class RelatorioService
    {
        private readonly AppDbContext _context;

        public RelatorioService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Relatorio>> GetRelatoriosAsync()
        {
            return await _context.Relatorios.Include(r => r.Solicitante).ToListAsync();
        }

        public async Task AddRelatorioAsync(Relatorio relatorio)
        {
            _context.Relatorios.Add(relatorio);
            await _context.SaveChangesAsync();
        }
    }
}
