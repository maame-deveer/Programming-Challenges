using static System.Console;
using System.IO;
using System.Globalization;

//declaring variables
Random random = new Random();
int nameType;
List<string> boyNames = new List<string>();
List<string> girlNames = new List<string>();
string filePath = @"C:\Users\maame\Documents\c#\Programming Challenges\NameGenerator\names.csv";

//check if data file exists
if (File.Exists(filePath))
{
    //store csv file contents in list
    using (var stream = new StreamReader(filePath))
    {
        while (!stream.EndOfStream)
        {
            var line = stream.ReadLine();
            var values = line.Split();

            foreach (var item in values)
            {
                if (item.Contains("boy")) boyNames.Add(item.Replace(",boy", "").Replace("  ", " "));
                else if (item.Contains("girl")) girlNames.Add(item.Replace(",girl", "").Replace("  ", " "));
            }
        }
    }
}
else
{
    WriteLine("File does not exist");
}

WriteLine("Welcome To Name Generator");
WriteLine("Generate \n1. Boy Name \n2. Girl Name");
var val = ReadLine();
nameType = Convert.ToInt32(val);

if (nameType == 1)
{
    WriteLine("Generating...");
    WriteLine(boyNames[random.Next(0, boyNames.Count - 1)]);
}
else if (nameType == 2)
{
    WriteLine("Generating...");
    WriteLine(girlNames[random.Next(0, girlNames.Count - 1)]);
}
else
{
    WriteLine("Wrong Input Please Try Again");
}
