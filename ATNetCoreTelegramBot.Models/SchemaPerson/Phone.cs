using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ATNetCoreTelegramBot.Models.SchemaPerson;

[System.ComponentModel.DataAnnotations.Schema.Table(name: Infrastructure.TableName.SchemaPerson.Phone,
                                                    Schema = Infrastructure.SchemaName.SchemaPerson)]
public class Phone : ID.BaseEntityGuid
{
    #region Configuration

    internal class Configuration : IEntityTypeConfiguration<Phone>
    {
        [Obsolete]
        public void Configure(EntityTypeBuilder<Phone> builder)
        {
            builder.HasIndex(current => current.PersonId)
                   .IsUnique(unique: false)
                   .HasName("IX_person.Phone.PersonId");
            // **********
            builder.HasIndex(current => current.PhoneTypeId)
                   .IsUnique(unique: false)
                   .HasName("IX_person.Phone.PhoneTypeId");
            // **********
            builder.HasOne(current => current.Person)
                    .WithMany(current => current.Phones)
                    .HasForeignKey(current => current.PersonId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();
            // **********
            builder.HasOne(current => current.PhoneType)
                    .WithMany(current => current.Phones)
                    .HasForeignKey(current => current.PhoneTypeId)
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
        (ResourceType = typeof(Resource.Models.SchemaPerson.PhoneTypes.PhoneType),
            Name = nameof(Resource.Models.SchemaPerson.PhoneTypes.PhoneType.EntityName))]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 2)]
    public int PhoneTypeId { get; set; }
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
        (ResourceType = typeof(Resource.Models.SchemaPerson.PhoneTypes.PhoneType),
            Name = nameof(Resource.Models.SchemaPerson.PhoneTypes.PhoneType.EntityName))]
    public virtual PhoneType PhoneType { get; set; }
    // **********

    #endregion

    #endregion
}