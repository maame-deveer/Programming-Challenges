using static System.Console;

namespace HigerLower
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //declaring variables
            bool endGame = false;
            Random random = new Random();
            List<Data> data = new List<Data>();
            int score = 0;
            string isGreater;
            string choice;
            string filePath = @"C:\Users\maame\Documents\c#\Programming Challenges\HigherLower\relatedEntities.csv";

            //check if file exists
            if (File.Exists(filePath))
            {
                //store csv file contents in list
                var temp = File.ReadAllLines(filePath);
                foreach (string line in temp)
                {
                    var value = line.Split(',');
                    data.Add(new Data(value[0], value[1]));
                }
            }
            else WriteLine("File Does Not Exist");

            WriteLine("Welcome To Higher/Lower Game");
            //loop game till user ends it
            while (!endGame)
            {
                WriteLine();
                WriteLine("Which term has higher searches?");

                //get queries and percentage
                var termOne = data[random.Next(0, data.Count - 1)];
                var termTwo = data[random.Next(0, data.Count - 1)];

                //check to make sure the same term is not brought up twice
                while (true)
                {
                    if (termOne == termTwo)
                    {
                        termTwo = data[random.Next(0, data.Count - 1)];
                    }
                    else break;
                }

                //check which is greater and the user's answer
                if (Int32.Parse(termOne.percentage) > Int32.Parse(termTwo.percentage))
                {
                    isGreater = termOne.term;
                }
                else
                {
                    isGreater = termTwo.term;
                }

                //input validation
                while (true)
                {
                    WriteLine($"{termOne.term} or {termTwo.term} : (1/2)");
                    choice = ReadLine();
                    if (choice == "1" || choice == "2") break;
                    else
                    {
                        WriteLine("Invalid Input!. Enter either 1 or 2!");
                    }
                }

                //check user's answer with isGreater
                if (choice == "1" && isGreater == termOne.term)
                {
                    score++;
                    WriteLine($"You win,{termOne.term} makes {termOne.percentage}% of the most searched terms.\n{termTwo.term} only makes {termTwo.percentage}% of most searched terms.");
                    WriteLine($"Score : {score}");
                }
                else if (choice == "2" && isGreater == termTwo.term)
                {
                    score++;
                    WriteLine($"You win,{termTwo.term} makes {termTwo.percentage}% of the most searched terms.\n{termOne.term} only makes {termOne.percentage}% of most searched terms.");
                    WriteLine($"Score : {score}");
                }
                else
                {
                    WriteLine("Better Luck Next Time :(");
                    WriteLine($"{termOne.term} makes {termOne.percentage}% of searches \n Whilst {termTwo.term} makes {termTwo.percentage}% of searches");
                }

                //continue playing or quit
                while (true)
                {
                    WriteLine("Continue Playing ? (y/n)");
                    choice = ReadLine();
                    if (choice == "n")
                    {
                        WriteLine($"Final Score : {score}");
                        endGame = true;
                        break;
                    }
                    else if (choice == "y")
                    {
                        break;
                    }
                    else
                    {
                        WriteLine("Invalid Input. Try Again.");
                    }
                }
            }
        }
    }

    public class Data
    {
        public string term { get; set; }
        public string percentage { get; set; }

        public Data(string term, string percentage)
        {
            this.term = term;
            this.percentage = percentage;
        }
    }
}