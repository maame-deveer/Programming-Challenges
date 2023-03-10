using static System.Console;

//declaring variables
Random random = new Random();
string[] results = { "h", "t" };
string display = " ";
string choice = " ";
bool endGame = false;
int score = 0;

//loop game till user ends it
while (!endGame)
{
    //get a valid input;
    while (true)
    {
        WriteLine("Heads(h) or Tails(t) ? :");
        choice = ReadLine();

        if (choice == "h" || choice == "t") break;
        else WriteLine("Invalid Input. Try Again (h/t)");
    }


    //toss coin
    string result = results[random.Next(0, results.Length)];

    //output
    WriteLine("Tossing...");
    //score and output
    if (choice == result)
    {
        if (result == "h") display = "heads";
        else display = "tails";
        score++;
        WriteLine($"{display} \nYou Win! \nScore: {score}");
    }
    else WriteLine($"{result} \nYou Lose :( \n{score}");

    //still play or end game
    while (true)
    {
        WriteLine("Do you want to continue?: (y/n)");
        choice = ReadLine();

        if (choice == "n")
        {
            endGame = true;
            WriteLine($"Final Score: {score} \nBye!");
            break;
        }
        else if (choice == "y") break;
        else WriteLine("Invalid Input. Try Again (y/n)");
    }
}






