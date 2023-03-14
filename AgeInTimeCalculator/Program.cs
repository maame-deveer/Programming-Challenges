using System;
using static System.Console;

//declaring
string input;
int day = 0, year = 0, month = 0;
DateTime birthday;
int age;
string choice;
bool endApp = false;

//convert age to secs and others
while (!endApp)
{
    //get user action and validate input
    while (true)
    {
        WriteLine("Age Converter");
        WriteLine("1.To Years\n2.To Months\n3.To Weeks\n4.To Days\n5.To Hours\n6.To Minutes\n7.To Seconds\n8.Exit");
        choice = ReadLine();
        if (Int32.Parse(choice) > 0 && Int32.Parse(choice) <= 8) break;
        else WriteLine("Invalid Input. Try Again. (1-7)");
    }

    if (Int32.Parse(choice) > 0 && Int32.Parse(choice) <= 7)
    {
        //get user date of birth
        WriteLine("Enter Your Birth Date: ");
        //year
        WriteLine("Year: ");
        input = ReadLine();
        year = Int32.Parse(input);

        //month
        while (true)
        {
            WriteLine("Month: ");
            input = ReadLine();
            month = Int32.Parse(input);
            if (month > 0 && month <= 12) break;
            else WriteLine("Enter A Valid Month: (1-12)");
        }

        //day
        while (true)
        {
            WriteLine("Day: ");
            input = ReadLine();
            day = Int32.Parse(input);
            if (month > 0 && month <= 31) break;
            else WriteLine("Enter A Day: (1-31)");
        }

        //user birth date
        birthday = GetDate(year, month, day);
        age = ((DateTime.Now.Year - birthday.Year) * 372 + (DateTime.Now.Month - birthday.Month) * 31 + (DateTime.Now.Day - birthday.Day)) / 372;

        //convert
        if (Int32.Parse(choice) == 1) WriteLine($"Your Age In Years IS {age} Years");
        else if (Int32.Parse(choice) == 2) WriteLine($"Your Age In Years IS {age * 12} Months");
        else if (Int32.Parse(choice) == 3) WriteLine($"Your Age In Months IS {(age * 12) * 4} Weeks");
        else if (Int32.Parse(choice) == 4) WriteLine($"Your Age In Days IS {((age * 12) * 4) * 7} Days");
        else if (Int32.Parse(choice) == 5) WriteLine($"Your Age In Hours IS {(((age * 12) * 4) * 7) * 24} Hours");
        else if (Int32.Parse(choice) == 6) WriteLine($"Your Age In Minutes IS {((((age * 12) * 4) * 7) * 24) * 60} Minutes");
        else if (Int32.Parse(choice) == 7) WriteLine($"Your Age In Seconds IS {(((((age * 12) * 4) * 7) * 24) * 60) * 60} Seconds");
    }
    else endApp = true;
}

DateTime GetDate(int year, int month, int day)
{
    return new DateTime(year, month, day);
}



