using System.Reflection;

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

    #region SchemaBase

    public DbSet<SchemaBase.City> Cities { get; set; }

    public DbSet<SchemaBase.Country> Countries { get; set; }

    public DbSet<SchemaBase.Culture> Cultures { get; set; }

    public DbSet<SchemaBase.Province> Provinces { get; set; }

    #endregion

    #region SchemaPerson

    public DbSet<SchemaPerson.Address> Addresses { get; set; }

    public DbSet<SchemaPerson.AddressType> AddressTypes { get; set; }

    public DbSet<SchemaPerson.Email> Emails { get; set; }

    public DbSet<SchemaPerson.EmailType> EmailTypes { get; set; }

    public DbSet<SchemaPerson.Gender> Genders { get; set; }

    public DbSet<SchemaPerson.InstantMessage> InstantMessages { get; set; }

    public DbSet<SchemaPerson.InstantMessageType> InstantMessageType { get; set; }

    public DbSet<SchemaPerson.MaritalStatus> MaritalStatuses { get; set; }

    public DbSet<SchemaPerson.MilitaryServiceStatus> MilitaryServiceStatuses { get; set; }

    public DbSet<SchemaPerson.Phone> Phones { get; set; }

    public DbSet<SchemaPerson.PhoneType> PhoneTypes { get; set; }

    public DbSet<SchemaPerson.Social> Socials { get; set; }

    public DbSet<SchemaPerson.SocialType> SocialTypes { get; set; }

    public DbSet<SchemaPerson.Url> Urls { get; set; }

    public DbSet<SchemaPerson.UrlType> UrlTypes { get; set; }

    #endregion

    #region SchemaTelegram

    public DbSet<SchemaTelegram.Channel> Channels { get; set; }

    public DbSet<SchemaTelegram.Group> Groups { get; set; }

    public DbSet<SchemaTelegram.User> TelegramUsers { get; set; }

    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        Infrastructure.Configuration.Base.ApplyConfiguration(modelBuilder);
        Infrastructure.Configuration.Person.ApplyConfiguration(modelBuilder);
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