using System;

namespace Zufall
{
    class Program
    {
        static void Main(string[] args)
        

        {
            int high = 100;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            string start = "yes";
            while (start == "yes")
            {
                
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                int nice = 69;
                int lucky = new Random().Next(1, 101);
                Console.CursorLeft = Console.BufferWidth - 25;
                Console.WriteLine("session High Score: " + high);
                Console.Write("Enter a number between 1 and 100: ");

                try
                {
                    String userinput = Console.ReadLine();
                    int GuessConvert = Convert.ToInt32(userinput);
                    int tries = 1;
                    while (lucky != GuessConvert)
                    {
                        if (GuessConvert == nice)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Hehe... funny..");
                        }

                        Console.ForegroundColor = ConsoleColor.DarkRed;



                        if ((GuessConvert > 100) || (GuessConvert < 1))
                        {
                            Console.Beep(750,250);
                            Console.WriteLine("your number isn't betwenn 1 and 100. Please try again");
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            userinput = Console.ReadLine();
                            GuessConvert = Convert.ToInt32(userinput);
                        }


                        if (GuessConvert > lucky)
                        {
                            Console.Beep(500,250);
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Try a smaller number");
                        }

                        if (GuessConvert < lucky)
                        {
                            Console.Beep(1000,250);
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Try a bigger number");
                        }
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        userinput = Console.ReadLine();
                        GuessConvert = Convert.ToInt32(userinput);
                        tries = tries + 1;

                    }

                    if (tries < high)
                    {
                        high = tries;
                        Console.WriteLine("Your new session High Score is " + high);
                    }
                    else
                    {
                        Console.WriteLine("The session High Score remains " + high);
                    }

                    if (GuessConvert == lucky)
                        Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You are great you tried " + tries + " time(s)");
                    Console.WriteLine("Do you want to try again? [yes|no]");
                    start =Console.ReadLine();
                    Console.Clear();
                }
                catch
                {
                    Console.ForegroundColor
                     = ConsoleColor.DarkMagenta;
                    Console.WriteLine("This is no number. Please try again and press enter");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Thank you for playing. Your final session High Score is " + high + " (:");

        }
    }
}
