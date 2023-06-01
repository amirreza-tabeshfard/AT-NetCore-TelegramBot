using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ATNetCoreTelegramBot.Models.SchemaTelegram;

[System.ComponentModel.DataAnnotations.Schema.Table(name: Infrastructure.TableName.SchemaTelegram.Group,
                                                    Schema = Infrastructure.SchemaName.SchemaTelegram)]
public class Group : ID.BaseEntityGuid
{
    #region Configuration

    internal class Configuration : IEntityTypeConfiguration<Group>
    {
        [System.Obsolete]
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.Property(current => current.Id)
                    .HasDefaultValueSql("newsequentialid()");

            builder.HasIndex(current => current.Name)
                   .IsUnique(unique: true)
                   .HasName("IX_telegram.Groups.Name");
        }
    }

    #endregion

    #region Fields

    private string _name;

    #endregion

    // **********
    [System.ComponentModel.DataAnnotations.Required
        (AllowEmptyStrings = false,
            ErrorMessageResourceType = typeof(Resource.Messages.Message),
            ErrorMessageResourceName = nameof(Resource.Messages.Message.Required))]

    [System.ComponentModel.DataAnnotations.StringLength
        (maximumLength: 200,
            MinimumLength = 1,
            ErrorMessageResourceType = typeof(Resource.Messages.Message),
            ErrorMessageResourceName = nameof(Resource.Messages.Message.MaxLength))]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 1)]
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                value = default;

            value = value.Trim();

            while (value.Contains(value: "  "))
                value = value.Replace(oldValue: "  ", newValue: " ");

            _name = value;
        }
    }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 2)]
    public int Ordering { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Generals.General),
            Name = nameof(Resource.Generals.General.InsertDateTime))]

    [System.ComponentModel.DataAnnotations.Required
        (AllowEmptyStrings = false,
            ErrorMessageResourceType = typeof(Resource.Messages.Message),
            ErrorMessageResourceName = nameof(Resource.Messages.Message.Required))]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 3)]
    public System.DateTime InsertDateTime { get; set; }
    // **********
}