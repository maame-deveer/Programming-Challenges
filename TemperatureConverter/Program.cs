using static System.Console;

//declaring variables
decimal tempToConvert;
decimal convert;
string temp;
string choice;
bool endApp = false;

//loop until user closes program
while (!endApp)
{
    //convert to cels or fahr
    //input validation
    while (true)
    {
        WriteLine("Temperature Converter\n1.Celcius\n2.Fahrenheit");
        choice = ReadLine();
        if (choice == "1" || choice == "2") break;
        else WriteLine("Invalid Input. Try Again");
    }

    //get temperature to convert
    if (choice == "1")
    {
        WriteLine("Enter Temperature In Fahrenheit To Convert To Celsius: ");
        temp = ReadLine();
        tempToConvert = decimal.Parse(temp);
        WriteLine("Converting...");
        WriteLine($"{tempToConvert}°F Is {Math.Round(ConvertToCelsius(tempToConvert), 2)}°C");
    }
    else if (choice == "2")
    {
        WriteLine("Enter Temperature In Celsius To Convert To Fahrenheit: ");
        temp = ReadLine();
        tempToConvert = decimal.Parse(temp);
        WriteLine("Converting...");
        WriteLine($"{tempToConvert}°C Is {Math.Round(ConvertToFahrenheit(tempToConvert), 2)}°F");
    }

    //exit application
    //input validation
    while (true)
    {
        WriteLine("Exit Applcation ? (y/n)");
        choice = ReadLine();
        if (choice == "y")
        {
            endApp = true;
            break;
        }
        else if (choice == "n") break;
        else WriteLine("Invalid Input. Try Again");
    }
}

decimal ConvertToCelsius(decimal tempConverted)
{
    return convert = (tempToConvert - 32.0M) * 5.0M / 9.0M;
}

decimal ConvertToFahrenheit(decimal tempConverted)
{
    return convert = (tempToConvert * 9.0M / 5.0M) + 32.0M;
}
