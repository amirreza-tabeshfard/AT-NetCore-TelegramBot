namespace ATNetCoreTelegramBot.Models.ID;

public abstract class BaseEntityGuid : object
{
    public BaseEntityGuid()
    {
        //Id = Guid.NewGuid();
    }

    // **********
    //[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
    //    (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity),
    //        System.ComponentModel.DataAnnotations.Key()]
    
    [System.ComponentModel.DataAnnotations.Key]

    [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
        (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]

    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Generals.General),
            Name = nameof(Resource.Generals.General.Id))]

    [System.ComponentModel.DataAnnotations.ScaffoldColumn
        (scaffold: false)]

    [System.ComponentModel.Bindable
        (bindable: false)]

    //[System.ComponentModel.DefaultValue
    //    (typeof(Guid), value: "(newid())")]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 0)]
    public Guid Id { get; set; }
    // **********
}