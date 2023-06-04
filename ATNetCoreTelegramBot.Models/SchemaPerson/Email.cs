using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ATNetCoreTelegramBot.Models.SchemaPerson;

[System.ComponentModel.DataAnnotations.Schema.Table(name: Infrastructure.TableName.SchemaPerson.Email,
                                                    Schema = Infrastructure.SchemaName.SchemaPerson)]
public class Email : ID.BaseEntityGuid
{
    #region Configuration

    internal class Configuration : IEntityTypeConfiguration<Email>
    {
        [Obsolete]
        public void Configure(EntityTypeBuilder<Email> builder)
        {
            builder.HasIndex(current => current.PersonId)
                   .IsUnique(unique: false)
                   .HasName("IX_person.Email.PersonId");
            // **********
            builder.HasIndex(current => current.EmailTypeId)
                   .IsUnique(unique: false)
                   .HasName("IX_person.Email.EmailTypeId");
            // **********
            builder.HasOne(current => current.Person)
                    .WithMany(current => current.Emails)
                    .HasForeignKey(current => current.PersonId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();
            // **********
            builder.HasOne(current => current.EmailType)
                    .WithMany(current => current.Emails)
                    .HasForeignKey(current => current.EmailTypeId)
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
        (ResourceType = typeof(Resource.Models.SchemaPerson.EmailTypes.EmailType),
            Name = nameof(Resource.Models.SchemaPerson.EmailTypes.EmailType.EntityName))]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 2)]
    public int EmailTypeId { get; set; }
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
        (ResourceType = typeof(Resource.Models.SchemaPerson.EmailTypes.EmailType),
            Name = nameof(Resource.Models.SchemaPerson.EmailTypes.EmailType.EntityName))]
    public virtual EmailType EmailType { get; set; }
    // **********

    #endregion

    #endregion /RelationShip
}