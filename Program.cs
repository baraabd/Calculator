using System;
using System.Collections.Generic;

namespace Calculator
{

    class MainClass
    {
        static void Main(string[] args)

        {
            bool showMenu = true;

            while (showMenu)

            {

                showMenu = MainMenu();

            }
        }

        public static bool MainMenu()

        {
            Console.Clear();

            Console.WriteLine("Välj vilken operation ( + , - , * , / ):");

            Console.WriteLine("Ange första sifran och tryck Enter: ");

            Console.WriteLine("Ange andra sifran och tryck Enter: ");

            Console.WriteLine("Du kan se resultat: ");

            Console.WriteLine("0) För att avbryta projekt tryck på Esc");

            Console.Write("\r\nVälj ett alternativ: ");


            switch (Console.ReadLine())

            {

                case "+":

                    Addition(Console.ReadLine(), Console.ReadLine());

                    return true;

                case "-":

                    Subtraktion(Console.ReadLine(), Console.ReadLine());

                    return true;
                case "/":

                    Division(Console.ReadLine(), Console.ReadLine());

                    return true;
                case "*":

                    Multiplikation(Console.ReadLine(), Console.ReadLine());

                    return true;
                
                case "0":

                    return false;

                default:

                    return true;
            }
        }



        public static string Addition(string firstNumber, string secondNumber)
        {
            double result = 0;
            double Number;


            if (double.TryParse(firstNumber, out Number) & (double.TryParse(secondNumber, out Number)))
            {    
                result = double.Parse(firstNumber) + double.Parse(secondNumber);
                Console.Write(firstNumber + "+" + secondNumber + "=" + result);
            }
            else Console.WriteLine("Du har inte anget sifror ");
            
            return Console.ReadLine();
        }

        public static string Subtraktion(string firstNumber, string secondNumber)
        {
            double result = 0;
            double Number;

            if (double.TryParse(firstNumber, out Number) & (double.TryParse(secondNumber, out Number)))
            {
                result = double.Parse(firstNumber) - double.Parse(secondNumber);
                Console.Write(firstNumber + "-" + secondNumber + "=" + result);

            }
            else Console.WriteLine("Du har inte anget sifror ");

            return Console.ReadLine();
        }

        public static string Division(string firstNumber, string secondNumber)
        {
            double result = 0;
            double Number;

            if (double.TryParse(firstNumber, out Number) & (double.TryParse(secondNumber, out Number)))
            {
                if (double.Parse(secondNumber) == 0)
                {
                    Console.WriteLine("Du försöker dividera med noll försök igen");
                }
                else
                {
                    result = double.Parse(firstNumber) / double.Parse(secondNumber);
                    Console.Write(firstNumber + "/" + secondNumber + "=" + result);
                }
                

            }
            else Console.WriteLine("Du har inte anget sifror ");
            return Console.ReadLine();
        }

        public static string Multiplikation(string firstNumber, string secondNumber)
        {
            double result = 0;
            double Number;

            if (double.TryParse(firstNumber, out Number) & (double.TryParse(secondNumber, out Number)))
            {
                result = double.Parse(firstNumber) * double.Parse(secondNumber);
                Console.Write(firstNumber + "*" + secondNumber + "=" + result);

            }
            else Console.WriteLine("Du har inte anget sifror ");

            return Console.ReadLine();
        }
    }
}
