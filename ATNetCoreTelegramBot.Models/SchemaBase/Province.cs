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
        public void Configure(EntityTypeBuilder<Province> builder)
        {
            builder.Property(current => current.Id)
                    .HasDefaultValueSql("newsequentialid()");

            builder.HasIndex(current => new {
                                                current.CountryId,
                                                current.Name
                                            })
                   .IsUnique(unique: true)
                   .HasName("IX_base.Provinces.CountryId_Name");

            builder.HasOne(current => current.Country)
                    .WithMany(current => current.Provinces)
                    .HasForeignKey(current => current.CountryId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();
        }
    }

    #endregion

    #region Variables

    private string _name;

    #endregion

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

    #endregion

    #endregion
}