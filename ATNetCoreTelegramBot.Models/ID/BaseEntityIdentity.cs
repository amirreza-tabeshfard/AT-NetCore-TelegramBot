namespace ATNetCoreTelegramBot.Models.ID;

public class BaseEntityIdentity : object
{
    // **********
    [System.ComponentModel.DataAnnotations.Key]

    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Generals.General),
            Name = nameof(Resource.Generals.General.Id))]

    [System.ComponentModel.DataAnnotations.StringLength
        (maximumLength: 450,
            ErrorMessageResourceType = typeof(Resource.Messages.Message),
            ErrorMessageResourceName = nameof(Resource.Messages.Message.MaxLength))]

    [System.ComponentModel.DataAnnotations.ScaffoldColumn
        (scaffold: false)]

    [System.ComponentModel.Bindable
        (bindable: false)]
    
    [System.ComponentModel.DataAnnotations.DataType
        ("NVARCHAR(450)")]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 0)]
    public string Id { get; set; }
    // **********
}