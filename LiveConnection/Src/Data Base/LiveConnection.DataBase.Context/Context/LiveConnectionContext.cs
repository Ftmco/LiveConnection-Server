using Microsoft.EntityFrameworkCore;

namespace LiveConnection.DataBase.Context;

public class LiveConnectionContext : DbContext
{
    public static string ConnectionString { get; set; } = null!;

    public LiveConnectionContext(DbContextOptions<LiveConnectionContext> options) : base(options)
    { }

    public LiveConnectionContext()
    { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
            optionsBuilder.UseSqlServer(ConnectionString);
    }
}