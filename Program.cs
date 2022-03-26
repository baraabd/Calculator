using System;
using System.Collections.Generic;

namespace Calculator
{

    class MainClass
    {
        static void Main(string[] args)

        {
            bool showMenu = true;
            Console.Clear();
            Console.WriteLine("Instruktioner att använda kalkylator: ");
            Console.WriteLine("-Du kan använda allmänna matematik operationer ( +, -, *, / ):");
            Console.WriteLine("-Du kan trycka på Enter när du vill utföra en annan operation.");
            Console.WriteLine("-Du kan trycka på Esc när du vill avsluta programmet.");

            while (showMenu)

            {
                Addition(CaptureInput());
            }
        }

        static void Addition(string user)
        {
            char type = GetTypeOfOperation(user.Trim());
            string[] subs = user.Split('+', '-', '*', '/');
            double firstNumber = double.Parse(subs[0]);
            double secondNumber = double.Parse(subs[0]);
            double result = 0;
            int Number;

            if (int.TryParse(subs[0], out Number) & (int.TryParse(subs[1], out Number))){

                if (type == '+')
                {
                    result = firstNumber + secondNumber;
                    Console.Write(subs[0] + "+" + subs[1] + "=" + result);
                }
                else if (type == '-')
                {
                    result = firstNumber - secondNumber;
                    Console.Write(subs[0] + "-" + subs[1] + "=" + result);
                }
                else if (type == '*')
                {
                    result = firstNumber * secondNumber;
                    Console.Write(subs[0] + "*" + subs[1] + "=" + result);
                }
                else if (type == '/')
                {
                    if (double.Parse(subs[1]) == 0)
                    {
                        Console.WriteLine("Du försöker dividera med noll");
                    }else
                    {
                        result = double.Parse(subs[0]) / double.Parse(subs[1]);
                        Console.Write(subs[0] + "/" + subs[1] + "=" + result);
                    }
                }
            }
            else Console.WriteLine("Du har inte anget sifror ");
        }

        public static string CaptureInput()
        {
            ConsoleKeyInfo ch;

            ch = Console.ReadKey();
            if (ch.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }

            return Console.ReadLine();
        }

        public static char GetTypeOfOperation(string user)
        {
            char type = 'q';
            for (int i = 0; i < user.Length; i++)
            {
                if ((Char.IsWhiteSpace(user[i])) || !(Char.IsNumber(user[i])))
                {
                    type = user[i];
                }
            }
            return type;
        }
    }
}
