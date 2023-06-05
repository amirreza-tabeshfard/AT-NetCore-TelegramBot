using ATNetCoreTelegramBot.Models.Data.BasicInformation.SchemaBase;

Culture culture = new Culture();

SchemaBase();

void SchemaBase()
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("---------------------------------------------------------------------------------");
    Console.WriteLine("\t\t\t\t\t(( SchemaBase ))");
    Console.WriteLine("---------------------------------------------------------------------------------");

    culture.CreateByDefault();
}

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n\n\n\t\t\t\t\t\tPress any key to end Project.");
Console.ReadKey();