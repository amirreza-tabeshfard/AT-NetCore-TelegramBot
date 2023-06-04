using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ATNetCoreTelegramBot.Models.SchemaBase;

[System.ComponentModel.DataAnnotations.Schema.Table(name: Infrastructure.TableName.SchemaBase.City,
                                                    Schema = Infrastructure.SchemaName.SchemaBase)]
public class City : ID.BaseEntityGuid
{
    #region Configuration

    internal class Configuration : IEntityTypeConfiguration<City>
    {
        [Obsolete]
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.Property(current => current.Id)
                    .HasDefaultValueSql("newsequentialid()");

            builder.HasIndex(current => current.CultureId)
                   .IsUnique(unique: false)
                   .HasName("IX_base.City.CultureId");

            builder.HasIndex(current => new
            {
                current.ProvinceId,
                current.Name
            })
            .IsUnique(unique: true)
            .HasName("IX_base.City.ProvinceId_Name");

            builder.HasOne(current => current.CultureName)
                    .WithMany(current => current.Cities)
                    .HasForeignKey(current => current.CultureId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();

            builder.HasOne(current => current.Province)
                    .WithMany(current => current.Cities)
                    .HasForeignKey(current => current.ProvinceId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();
        }
    }

    #endregion /Configuration

    #region Variables

    private string _name;

    #endregion /Variables

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaBase.CultureNames.CultureName),
            Name = nameof(Resource.Models.SchemaBase.CultureNames.CultureName.EntityName))]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 1)]
    public int CultureId { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaBase.Provinces.Province),
            Name = nameof(Resource.Models.SchemaBase.Provinces.Province.EntityName))]

    [System.ComponentModel.DataAnnotations.Required
        (AllowEmptyStrings = false,
            ErrorMessageResourceType = typeof(Resource.Messages.Message),
            ErrorMessageResourceName = nameof(Resource.Messages.Message.Required))]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 2)]
    public Guid ProvinceId { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Generals.General),
            Name = nameof(Resource.Generals.General.Name))]

    [System.ComponentModel.DataAnnotations.Required
        (AllowEmptyStrings = false,
            ErrorMessageResourceType = typeof(Resource.Messages.Message),
            ErrorMessageResourceName = nameof(Resource.Messages.Message.Required))]

    [System.ComponentModel.DataAnnotations.StringLength
        (maximumLength: 50,
            MinimumLength = 2,
            ErrorMessageResourceType = typeof(Resource.Messages.Message),
            ErrorMessageResourceName = nameof(Resource.Messages.Message.MaxLength))]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 3)]
    public string Name
    {
        get
        {
            if (string.IsNullOrWhiteSpace(_name))
                return string.Empty;

            _name = _name.Trim();

            while (_name.Contains(value: "  "))
                _name = _name.Replace(oldValue: "  ", newValue: " ");

            return _name;
        }
        set { _name = value; }
    }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Generals.General),
            Name = nameof(Resource.Generals.General.InsertDateTime), Order = 500)]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 500)]
    public DateTime InsertDateTime { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Generals.General),
            Name = nameof(Resource.Generals.General.LastUpdateDateTime), Order = 501)]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 501)]
    public DateTime? LastUpdateDateTime { get; set; }
    // **********

    #region RelationShip

    #region SchemaBase

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaBase.CultureNames.CultureName),
            Name = nameof(Resource.Models.SchemaBase.CultureNames.CultureName.EntityName))]
    public virtual Culture CultureName { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaBase.Provinces.Province),
            Name = nameof(Resource.Models.SchemaBase.Provinces.Province.EntityName))]
    public Province Province { get; set; }
    // **********

    #endregion

    #region SchemaPerson
    
    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.Addresses.Address),
            Name = nameof(Resource.Models.SchemaPerson.Addresses.Address.EntitiesName))]
    public virtual IList<SchemaPerson.Address> Addresses { get; set; }
    // ********** 

    #endregion

    #endregion
}