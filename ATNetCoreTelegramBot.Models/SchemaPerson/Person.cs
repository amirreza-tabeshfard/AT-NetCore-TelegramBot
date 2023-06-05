using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ATNetCoreTelegramBot.Models.SchemaPerson;

[System.ComponentModel.DataAnnotations.Schema.Table(name: Infrastructure.TableName.SchemaPerson.Person,
                                                    Schema = Infrastructure.SchemaName.SchemaPerson)]
public class Person : ID.BaseEntityGuid
{
    #region Configuration

    internal class Configuration : IEntityTypeConfiguration<Person>
    {
        [Obsolete]
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasIndex(current => new
            {
                current.CultureId,
                current.UserId
            })
            .IsUnique(unique: true)
            .HasName("IX_person.Person.CultureId_UserId");
            // **********
            builder.HasOne(current => current.User)
                    .WithMany(current => current.People)
                    .HasForeignKey(current => current.UserId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();
            // **********
            builder.HasOne(current => current.Culture)
                    .WithMany(current => current.People)
                    .HasForeignKey(current => current.CultureId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();
        }
    }

    #endregion /Configuration

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaBase.CultureNames.CultureName),
            Name = nameof(Resource.Models.SchemaBase.CultureNames.CultureName.EntityName))]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 1)]
    public int CultureId { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 2)]
    public Guid UserId { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Generals.General),
            Name = nameof(Resource.Generals.General.FirstName))]

    [System.ComponentModel.DataAnnotations.Required
        (AllowEmptyStrings = false,
            ErrorMessageResourceType = typeof(Resource.Messages.Message),
            ErrorMessageResourceName = nameof(Resource.Messages.Message.Required))]

    [System.ComponentModel.DataAnnotations.StringLength
        (maximumLength: 20,
            MinimumLength = 3,
            ErrorMessageResourceType = typeof(Resource.Messages.Message),
            ErrorMessageResourceName = nameof(Resource.Messages.Message.MaxLength))]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 3)]
    public string FirstName { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Generals.General),
            Name = nameof(Resource.Generals.General.LastName))]

    [System.ComponentModel.DataAnnotations.Required
        (AllowEmptyStrings = false,
            ErrorMessageResourceType = typeof(Resource.Messages.Message),
            ErrorMessageResourceName = nameof(Resource.Messages.Message.Required))]

    [System.ComponentModel.DataAnnotations.StringLength
        (maximumLength: 20,
            MinimumLength = 3,
            ErrorMessageResourceType = typeof(Resource.Messages.Message),
            ErrorMessageResourceName = nameof(Resource.Messages.Message.MaxLength))]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 4)]
    public string LastName { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.StringLength
        (maximumLength: 5000,
            MinimumLength = 30,
            ErrorMessageResourceType = typeof(Resource.Messages.Message),
            ErrorMessageResourceName = nameof(Resource.Messages.Message.MaxLength))]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 7)]
    public string? AboutMe { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 8)]
    public byte[]? Avatar { get; set; }
    // **********

    #region RelationShip

    #region SchemaBase

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaBase.CultureNames.CultureName),
            Name = nameof(Resource.Models.SchemaBase.CultureNames.CultureName.EntityName))]
    public virtual SchemaBase.Culture Culture { get; set; }
    // **********

    #endregion /SchemaBase

    #region SchemaPerson

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.Addresses.Address),
            Name = nameof(Resource.Models.SchemaPerson.Addresses.Address.EntitiesName))]
    public virtual IList<Address> Addresses { get; set; }
    // ********** 

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.BirthCertificates.BirthCertificate),
            Name = nameof(Resource.Models.SchemaPerson.BirthCertificates.BirthCertificate.EntitiesName))]
    public virtual IList<BirthCertificate> BirthCertificates { get; set; }
    // **********
    
    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.Birthdays.Birthday),
            Name = nameof(Resource.Models.SchemaPerson.Birthdays.Birthday.EntitiesName))]
    public virtual IList<Birthday> Birthdays { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.Emails.Email),
            Name = nameof(Resource.Models.SchemaPerson.Emails.Email.EntitiesName))]
    public virtual IList<Email> Emails { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.Genders.Gender),
            Name = nameof(Resource.Models.SchemaPerson.Genders.Gender.EntitiesName))]
    public virtual IList<Gender> Genders { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.InstantMessages.InstantMessage),
            Name = nameof(Resource.Models.SchemaPerson.InstantMessages.InstantMessage.EntitiesName))]
    public virtual IList<InstantMessage> InstantMessages { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.MaritalStatuses.MaritalStatus),
            Name = nameof(Resource.Models.SchemaPerson.MaritalStatuses.MaritalStatus.EntitiesName))]
    public virtual IList<MaritalStatus> MaritalStatuses { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.MilitaryServiceStatuses.MilitaryServiceStatus),
            Name = nameof(Resource.Models.SchemaPerson.MilitaryServiceStatuses.MilitaryServiceStatus.EntitiesName))]
    public virtual IList<MilitaryServiceStatus> MilitaryServiceStatuses { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.NationalCodes.NationalCode),
            Name = nameof(Resource.Models.SchemaPerson.NationalCodes.NationalCode.EntitiesName))]
    public virtual IList<NationalCode> NationalCodes { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.Phones.Phone),
            Name = nameof(Resource.Models.SchemaPerson.Phones.Phone.EntitiesName))]
    public virtual IList<Phone> Phones { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.Socials.Social),
            Name = nameof(Resource.Models.SchemaPerson.Socials.Social.EntitiesName))]
    public virtual IList<Social> Socials { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.Urls.Url),
            Name = nameof(Resource.Models.SchemaPerson.Urls.Url.EntitiesName))]
    public virtual IList<Url> Urls { get; set; }

    // **********

    #endregion

    #region SchemaTelegram

    public virtual SchemaTelegram.User User { get; set; }

    #endregion

    #endregion /RelationShip
}