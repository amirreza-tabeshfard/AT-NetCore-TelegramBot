using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ATNetCoreTelegramBot.Models.SchemaPerson;

[System.ComponentModel.DataAnnotations.Schema.Table(name: Infrastructure.TableName.SchemaPerson.InstantMessage,
                                                    Schema = Infrastructure.SchemaName.SchemaPerson)]
public class InstantMessage : ID.BaseEntityGuid
{
    #region Configuration

    internal class Configuration : IEntityTypeConfiguration<InstantMessage>
    {
        [Obsolete]
        public void Configure(EntityTypeBuilder<InstantMessage> builder)
        {
            builder.HasIndex(current => current.PersonId)
                   .IsUnique(unique: false)
                   .HasName("IX_person.InstantMessage.PersonId");
            // **********
            builder.HasIndex(current => current.InstantMessageTypeId)
                   .IsUnique(unique: false)
                   .HasName("IX_person.InstantMessage.InstantMessageTypeId");
            // **********
            builder.HasOne(current => current.Person)
                    .WithMany(current => current.InstantMessages)
                    .HasForeignKey(current => current.PersonId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();
            // **********
            builder.HasOne(current => current.InstantMessageType)
                    .WithMany(current => current.InstantMessages)
                    .HasForeignKey(current => current.InstantMessageTypeId)
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
        (ResourceType = typeof(Resource.Models.SchemaPerson.InstantMessageTypes.InstantMessageType),
            Name = nameof(Resource.Models.SchemaPerson.InstantMessageTypes.InstantMessageType.EntityName))]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 2)]
    public int InstantMessageTypeId { get; set; }
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
        (ResourceType = typeof(Resource.Models.SchemaPerson.InstantMessageTypes.InstantMessageType),
            Name = nameof(Resource.Models.SchemaPerson.InstantMessageTypes.InstantMessageType.EntityName))]
    public virtual InstantMessageType InstantMessageType { get; set; }
    // **********

    #endregion

    #endregion /RelationShip
}