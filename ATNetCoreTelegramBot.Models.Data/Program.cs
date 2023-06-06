using ATNetCoreTelegramBot.Models.Data.BasicInformation.SchemaBase;

#region Field(s)

#region SchemaBase

Culture culture = new Culture();
Country country = new Country();
Province province = new Province();

#endregion

#region SchemaPerson



#endregion

#endregion

SchemaBase();

void SchemaBase()
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("---------------------------------------------------------------------------------");
    Console.WriteLine("\t\t\t\t\t(( SchemaBase [Insert] ))");
    Console.WriteLine("---------------------------------------------------------------------------------");

    culture.CreateByDefault();
    country.CreateByDefault();
    province.CreateByDefault();
}

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n\n\n\t\t\t\t\t\tPress any key to end Project.");
Console.ReadKey();