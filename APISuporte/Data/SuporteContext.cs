using Microsoft.EntityFrameworkCore;

namespace APISuporte.Data;

public class SuporteContext : DbContext
{
    public DbSet<Chamado> Chamados => Set<Chamado>();

    public SuporteContext(DbContextOptions<SuporteContext> options) :
        base(options)
    {
    }
}