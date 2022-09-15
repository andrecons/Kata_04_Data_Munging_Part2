using Kata_04_Data_Munging_Part2.StartupConfigs;

DatHandler.Importer();
DatHandler.ListPrinter();
Console.WriteLine("\nSmallest Spread:" + DatHandler.GetSmallestSpread());

/*Printing days with smallest spread value*/
Console.WriteLine("Registered by Team/Teams");
string[] array = DatHandler.GetIndexSmallerSpread();

foreach (string team in array)
{
    Console.Write(team + "*");
}