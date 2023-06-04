using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ATNetCoreTelegramBot.Models.SchemaTelegram;

[System.ComponentModel.DataAnnotations.Schema.Table(name: Infrastructure.TableName.SchemaTelegram.User,
                                                    Schema = Infrastructure.SchemaName.SchemaTelegram)]
public class User : ID.BaseEntityGuid
{
    #region Configuration

    internal class Configuration : IEntityTypeConfiguration<User>
    {
        [Obsolete]
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(current => current.Id)
                   .HasDefaultValueSql("newsequentialid()");

            builder.HasIndex(current => current.UserName)
                   .IsUnique(unique: true)
                   .HasName("IX_telegram.Users.UserName");
        }
    }

    #endregion

    // **********
    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 1)]
    public long ChatID { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.StringLength
        (maximumLength: 200,
            MinimumLength = 1,
            ErrorMessageResourceType = typeof(Resource.Messages.Message),
            ErrorMessageResourceName = nameof(Resource.Messages.Message.MaxLength))]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 2)]
    public string? UserName { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.StringLength
        (maximumLength: 100,
            MinimumLength = 1,
            ErrorMessageResourceType = typeof(Resource.Messages.Message),
            ErrorMessageResourceName = nameof(Resource.Messages.Message.MaxLength))]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 3)]
    public string FirstName { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.StringLength
        (maximumLength: 100,
            MinimumLength = 1,
            ErrorMessageResourceType = typeof(Resource.Messages.Message),
            ErrorMessageResourceName = nameof(Resource.Messages.Message.MaxLength))]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 4)]
    public string? LastName { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 5)]
    public bool IsBot { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 6)]
    public bool? IsPremium { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.StringLength
        (maximumLength: 10,
            MinimumLength = 1,
            ErrorMessageResourceType = typeof(Resource.Messages.Message),
            ErrorMessageResourceName = nameof(Resource.Messages.Message.MaxLength))]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 7)]
    public string? LanguageCode { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 8)]
    public bool? AddedToAttachmentMenu { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 9)]
    public bool? CanJoinGroups { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 10)]
    public bool? CanReadAllGroupMessages { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 11)]
    public bool? SupportsInlineQueries { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Generals.General),
            Name = nameof(Resource.Generals.General.InsertDateTime), Order = 10)]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 12)]
    public DateTime InsertDateTime { get; set; }
    // **********
}