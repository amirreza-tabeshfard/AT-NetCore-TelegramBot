using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ATNetCoreTelegramBot.Models.SchemaPerson;

[System.ComponentModel.DataAnnotations.Schema.Table(name: Infrastructure.TableName.SchemaPerson.NationalCode,
                                                    Schema = Infrastructure.SchemaName.SchemaPerson)]
public class NationalCode : ID.BaseEntityGuid
{
    #region Configuration

    internal class Configuration : IEntityTypeConfiguration<NationalCode>
    {
        [Obsolete]
        public void Configure(EntityTypeBuilder<NationalCode> builder)
        {
            builder.HasIndex(current => current.PersonId)
                   .IsUnique(unique: true)
                   .HasName("IX_person.NationalCode.PersonId");
            // **********
            builder.HasIndex(current => current.Name)
                   .IsUnique(unique: true)
                   .HasName("IX_person.NationalCode.Name");
            // **********
            builder.HasOne(current => current.Person)
                    .WithMany(current => current.NationalCodes)
                    .HasForeignKey(current => current.PersonId)
                    .OnDelete(DeleteBehavior.NoAction);
        }
    }

    #endregion /Configuration

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.People.Person),
            Name = nameof(Resource.Models.SchemaPerson.People.Person.EntityName))]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 2)]
    public Guid PersonId { get; set; }
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
        (maximumLength: 10,
            MinimumLength = 10,
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

    #endregion

    #endregion
}