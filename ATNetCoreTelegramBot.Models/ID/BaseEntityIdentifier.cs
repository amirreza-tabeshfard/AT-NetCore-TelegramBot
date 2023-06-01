namespace ATNetCoreTelegramBot.Models.ID;

public abstract class BaseEntityIdentifier : object
{
    // **********
    [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
        (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity), 
            System.ComponentModel.DataAnnotations.Key()]

    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Generals.General),
            Name = nameof(Resource.Generals.General.Id))]

    [System.ComponentModel.DataAnnotations.ScaffoldColumn
        (scaffold: false)]

    [System.ComponentModel.Bindable
        (bindable: false)]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 0)]
    public int Id { get; set; }
    // **********
}