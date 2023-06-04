bool isPrintAllFailedValueInTheDatabase = true;

SchemaBase();

void SchemaBase()
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("---------------------------------------------------------------------------------");
    Console.WriteLine("\t\t\t\t\t(( SchemaBase ))");
    Console.WriteLine("---------------------------------------------------------------------------------");
    ATNetCoreTelegramBot.Models.Data.BasicInformation.Schema.SchemaBase.Country.Create(isPrintAllFailedValueInTheDatabase);
    ATNetCoreTelegramBot.Models.Data.BasicInformation.Schema.SchemaBase.Province.Create(isPrintAllFailedValueInTheDatabase);
    ATNetCoreTelegramBot.Models.Data.BasicInformation.Schema.SchemaBase.City.Create(isPrintAllFailedValueInTheDatabase);
}

Console.ReadKey();