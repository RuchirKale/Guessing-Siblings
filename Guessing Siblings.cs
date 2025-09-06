using System;
using System.Threading;

class Program
{
    public static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        //

        //
        Console.WriteLine("Im gonna guess your number of sibillings ");
        Thread.Sleep(TimeSpan.FromSeconds(2));
        Console.WriteLine("Do you want to play");
        string yn = Console.ReadLine();
        if (yn == "yes")
        {

            //questions

            Console.WriteLine("1.Consider number of brothers you have.");
            Thread.Sleep(TimeSpan.FromSeconds(5));
            Console.WriteLine("2. multiply it by 2");
            Thread.Sleep(TimeSpan.FromSeconds(5));
            Console.WriteLine("3.add 3 to it");
            Thread.Sleep(TimeSpan.FromSeconds(5));
            Console.WriteLine("4. Multiply it by 5");
            Thread.Sleep(TimeSpan.FromSeconds(5));
            Console.WriteLine("5.add number of sisters you have.");
            Thread.Sleep(TimeSpan.FromSeconds(5));
            Console.WriteLine("6.subtract 20 from it");
            Thread.Sleep(TimeSpan.FromSeconds(5));

            //to claculate the sibillings
            Console.WriteLine("Enter the enter your answer");

            int ans1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            int x = ans1 + 5;
            float x1 = x / 10;
            Console.WriteLine("You have " + x1 + " Brothers");

            //Sister
            int sis = Convert.ToInt32(x1 * 10);

            int sis_1 = x - sis;
            Console.WriteLine("You have " + sis_1 + " sister");



            //int i=10;
            // while (x > i / 10)
            // {
            //     Console.WriteLine("you have"+x % i - x % (i / 10));
            //     i *= 10;
            // }Console.WriteLine ("Hello World");
        }
        }
    }
    

