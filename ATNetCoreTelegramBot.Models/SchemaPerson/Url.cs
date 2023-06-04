using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ATNetCoreTelegramBot.Models.SchemaPerson;

[System.ComponentModel.DataAnnotations.Schema.Table(name: Infrastructure.TableName.SchemaPerson.Url,
                                                    Schema = Infrastructure.SchemaName.SchemaPerson)]
public class Url : ID.BaseEntityGuid
{
    #region Configuration

    internal class Configuration : IEntityTypeConfiguration<Url>
    {
        [Obsolete]
        public void Configure(EntityTypeBuilder<Url> builder)
        {
            builder.HasIndex(current => current.PersonId)
                   .IsUnique(unique: false)
                   .HasName("IX_person.Url.PersonId");
            // **********
            builder.HasIndex(current => current.UrlTypeId)
                   .IsUnique(unique: false)
                   .HasName("IX_person.Url.UrlTypeId");
            // **********
            builder.HasOne(current => current.Person)
                    .WithMany(current => current.Urls)
                    .HasForeignKey(current => current.PersonId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();
            // **********
            builder.HasOne(current => current.UrlType)
                    .WithMany(current => current.Urls)
                    .HasForeignKey(current => current.UrlTypeId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();
            // **********
        }
    }

    #endregion /Configuration

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.People.Person),
            Name = nameof(Resource.Models.SchemaPerson.People.Person.EntityName))]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 1)]
    public Guid PersonId { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.UrlTypes.UrlType),
            Name = nameof(Resource.Models.SchemaPerson.UrlTypes.UrlType.EntityName))]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 2)]
    public int UrlTypeId { get; set; }
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
        (maximumLength: 6,
            MinimumLength = 2,
            ErrorMessageResourceType = typeof(Resource.Messages.Message),
            ErrorMessageResourceName = nameof(Resource.Messages.Message.MaxLength))]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 3)]
    public string Name { get; set; }
    // **********

    #region RelationShip

    #region SchemaPerson

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.People.Person),
            Name = nameof(Resource.Models.SchemaPerson.People.Person.EntityName))]
    public virtual Person Person { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.UrlTypes.UrlType),
            Name = nameof(Resource.Models.SchemaPerson.UrlTypes.UrlType.EntityName))]
    public virtual UrlType UrlType { get; set; }
    // **********

    #endregion

    #endregion /RelationShip
}