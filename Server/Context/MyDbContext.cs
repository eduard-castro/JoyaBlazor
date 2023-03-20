using  Microsoft.EntityFrameworkCore;
using JoyaBlazor.Server.Models;

namespace JoyaBlazor.Server.Context;

public interface IMyDbContext
{
    DbSet<Usuario> UsuariosRoles { get; set; }
    DbSet<UsuarioRol> Usuarios { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}

public class MyDbContext : DbContext, IMyDbContext
{
    private readonly IConfiguration config;

    public MyDbContext(IConfiguration _config)
    {
        config = _config;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(config.GetConnectionString("JOYA"));

    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(cancellationToken);
    }

    #region Tablas de la BD.
    public DbSet<Usuario> UsuariosRoles { get; set; } = null!;
    public DbSet<UsuarioRol> Usuarios { get; set; } = null!;
    #endregion
}
