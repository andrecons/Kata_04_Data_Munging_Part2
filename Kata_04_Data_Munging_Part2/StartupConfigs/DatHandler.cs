using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Kata_04_Data_Munging_Part2.Objects;

namespace Kata_04_Data_Munging_Part2.StartupConfigs
{
    class DatHandler
    {
        const String DATFILEPATH = @"..\..\..\InputFiles\football.dat";

        private static List<Row> rowList = new List<Row>();

        public static void Importer()
        {
            int realDataStartingPoint = 0;

            Console.WriteLine("File at " + DATFILEPATH + " found.\n");
            using (var textFile = System.IO.File.OpenText(DATFILEPATH))
            {
                string line = null;

                while ((line = textFile.ReadLine()) != null)
                {
                    //Console.WriteLine(line);
                    //linea singola verificata

                    string patterSeparator_A = " ";
                    string patterSeparator_B = "-";
                    string patterSeparator_C = ".";
                    String[] separator = { patterSeparator_A, patterSeparator_B, patterSeparator_C };

                    string[] lineToArray = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);

                    int i = 0;
                    foreach (string word in lineToArray)
                    {
                        //Console.WriteLine("position: " + i + " " + word);
                        //i++;
                    }

                    try
                    {
                        string team = lineToArray[1];
                        int firstColumn = Int16.Parse(lineToArray[6]);
                        int secondColumn = Int16.Parse(lineToArray[7]);
                        Row newRow = new Row();
                        newRow.SettId(team);
                        newRow.SetFirstColumn(firstColumn);
                        newRow.SetSecondColumn(secondColumn);
                        rowList.Add(newRow);
                    }
                    catch (Exception e)
                    {

                        //Console.WriteLine(e.Message);

                    }

                    //Console.WriteLine("****EndOfLine****");
                }
            }
        }

        public static void ListPrinter()
        {
            foreach (Row row in rowList)
            {
                Console.WriteLine(row.ToString());
            }
        }

        public static decimal GetSmallestSpread()
        {
            decimal smallestSpread = 10000;

            foreach (Row row in rowList)
            {
                if (row.GetSpread() < smallestSpread)
                {
                    smallestSpread = row.GetSpread();
                }
            }
            return smallestSpread;
        }

        public static string[] GetIndexSmallerSpread()
        {
            int sameSpreadDaysCounter = 0;

            foreach (Row row in rowList)
            {
                if (row.GetSpread() == GetSmallestSpread())
                {
                    sameSpreadDaysCounter++;
                }
            }

            string[] teamIndex = new string[sameSpreadDaysCounter];

            decimal smallestSpread = GetSmallestSpread();

            int arrayIndex = 0;

            foreach (Row singleRow in rowList)
            {
                if (singleRow.GetSpread() == smallestSpread)
                {
                    teamIndex[arrayIndex] = singleRow.GetId();
                    arrayIndex++;
                }
            }

            return teamIndex;
        }



    }
}
