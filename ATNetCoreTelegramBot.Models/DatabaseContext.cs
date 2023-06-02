using System.Reflection;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ATNetCoreTelegramBot.Models;

public class DatabaseContext :
    //IdentityDbContext
    DbContext
{
    public DatabaseContext()
    {

    }

    public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }

    #region SchemaTelegram

    public DbSet<SchemaTelegram.Channel> Channels { get; set; }

    public DbSet<SchemaTelegram.Group> Groups { get; set; }

    public DbSet<SchemaTelegram.TelegramUser> TelegramUsers { get; set; }

    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        Infrastructure.Configuration.Telegram.ApplyConfiguration(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
            optionsBuilder.UseSqlServer(@"Integrated Security=False; Persist Security Info=False; Initial Catalog=AT_NetCore_TelegramBot; Data Source=AMIRREZA-TABESH; User ID=sa; Password=Amirreza; MultipleActiveResultSets=True; Encrypt=false; TrustServerCertificate=true;");
        
        base.OnConfiguring(optionsBuilder);
    }
}