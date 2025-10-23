
    string p = "no";
do{
    //randomizes the numbers.
    Random random = new Random();
    int a = random.Next(1, 10);
    int b = random.Next(1, 50);
    int c = random.Next(1, 100);

    //makes the variables so they can be used.
    int t = 0;
    int x = 0;
    int y = 0;
    int z = 0;

//difficulty selector.
    Console.Write("Hello please select the difficulty you wish to play on: easy, medium, hard");
    Console.WriteLine();
    string difficulty = Console.ReadLine() + "";

    //runs the game based on what the difficulty is.
    switch (difficulty)
    {
        case "easy":
            //make it so it runs tell they get the number right.
            while (a != x)
            {
                Console.WriteLine("Pick a number 1-10");
                x = Convert.ToInt32(Console.ReadLine());
                
                //checks to see if the number is right and it is isnt right it will check if it is greater than or less than the number.
                if (a == x)
                {
                    p = "no";
                    Console.WriteLine("Congrates you picked the right number!!!!!!!!!!1");
                    Console.WriteLine($"It took you {t} many tries");
                    Console.WriteLine("try again to get a better score");
                    Console.WriteLine("Would you like play again (yes/no)");
                    p = Console.ReadLine() + "";
                }
                else
                {
                    //adds to there attempts when playing the game when they get it wrong.
                    t++;

                    if (a >= x)
                    {
                        Console.WriteLine("Sorry your a bit short! try again");
                        Console.WriteLine($"You are on attempt {t}");
                    }
                    else
                    {
                        if (a <= x)
                        {
                            Console.WriteLine("Sorry your number is a bit to large! try again.");
                            Console.WriteLine($"You are on attempt {t}");
                        }
                    }
                }
            }
            break;

        case "medium":

            while (b != y)
            {
                Console.WriteLine("Pick a number 1-10");
                y = Convert.ToInt32(Console.ReadLine());
                if (b == y)
                {
                    Console.WriteLine("Congrates you picked the right number!!!!!!!!!!1");
                    Console.WriteLine($"It took you {t} many tries");
                    Console.WriteLine("try again to get a better score");
                    Console.WriteLine("Would you like play again (yes/no)");
                    p = Console.ReadLine() + "";
                }
                else
                {
                    t++;

                    if (b >= y)
                    {
                        Console.WriteLine("Sorry your a bit short! try again");
                        Console.WriteLine($"You are on attempt {t}");
                    }
                    else
                    {
                        if (b <= y)
                        {
                            Console.WriteLine("Sorry your number is a bit to large! try again.");
                            Console.WriteLine($"You are on attempt {t}");
                        }
                    }
                }
            }
            break;

        case "hard":
            while (c != z)
            {
                Console.WriteLine("Pick a number 1-10");
                z = Convert.ToInt32(Console.ReadLine());

                if (c == z)
                {
                    Console.WriteLine("Congrates you picked the right number!!!!!!!!!!1");
                    Console.WriteLine($"It took you {t} many tries");
                    Console.WriteLine("try again to get a better score");
                    Console.WriteLine("Would you like play again (yes/no)");
                    p = Console.ReadLine() + "";
                }
                else
                {
                    t++;

                    if (c >= z)
                    {
                        Console.WriteLine("Sorry your a bit short! try again");
                        Console.WriteLine($"You are on attempt {t}");
                    }
                    else
                    {
                        if (c <= z)
                        {
                            Console.WriteLine("Sorry your number is a bit to large! try again.");
                            Console.WriteLine($"You are on attempt {t}");
                        }
                    }
                }
            }
            break;

        //makes it so they have to to select a difficulty.
        default:
            Console.WriteLine("I need you to pick a difficulty!!");
            break;
    }
} while (p == "yes");