using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ATNetCoreTelegramBot.Models.SchemaBase;

[System.ComponentModel.DataAnnotations.Schema.Table(name: Infrastructure.TableName.SchemaBase.Province,
                                                    Schema = Infrastructure.SchemaName.SchemaBase)]
public class Province : ID.BaseEntityGuid
{
    #region Configuration

    internal class Configuration : IEntityTypeConfiguration<Province>
    {
        [Obsolete]
        public void Configure(EntityTypeBuilder<Province> builder)
        {
            builder.Property(current => current.Id)
                    .HasDefaultValueSql("newsequentialid()");

            builder.HasIndex(current => current.CultureId)
                   .IsUnique(unique: false)
                   .HasName("IX_base.Province.CultureId");

            builder.HasIndex(current => new
            {
                current.CountryId,
                current.Name
            })
            .IsUnique(unique: true)
            .HasName("IX_base.Province.CountryId_Name");

            builder.HasOne(current => current.CultureName)
                    .WithMany(current => current.Provinces)
                    .HasForeignKey(current => current.CultureId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();

            builder.HasOne(current => current.Country)
                    .WithMany(current => current.Provinces)
                    .HasForeignKey(current => current.CountryId)
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
        (ResourceType = typeof(Resource.Models.SchemaBase.Countries.Country),
            Name = nameof(Resource.Models.SchemaBase.Countries.Country.EntityName))]

    [System.ComponentModel.DataAnnotations.Required
        (AllowEmptyStrings = false,
            ErrorMessageResourceType = typeof(Resource.Messages.Message),
            ErrorMessageResourceName = nameof(Resource.Messages.Message.Required))]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 2)]
    public Guid CountryId { get; set; }
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

    #region RelationShip

    #region SchemaBase

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaBase.Cities.City),
            Name = nameof(Resource.Models.SchemaBase.Cities.City.EntitiesName))]
    public virtual IList<City> Cities { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaBase.Countries.Country),
            Name = nameof(Resource.Models.SchemaBase.Countries.Country.EntityName))]
    public virtual Country Country { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaBase.CultureNames.CultureName),
            Name = nameof(Resource.Models.SchemaBase.CultureNames.CultureName.EntityName))]
    public virtual Culture CultureName { get; set; }
    // **********

    #endregion /SchemaBase

    #endregion /RelationShip
}