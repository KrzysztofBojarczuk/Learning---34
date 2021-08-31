using System;
using System.IO;

namespace Learning___182
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Calc();
                    Console.WriteLine("Jesli chcesz zakończyć program wpisz Tak / tak. Jeśli chcesz dalej kontynować wciśjnij inny przycisk:");
                    string end = Console.ReadLine();
                    if (end == "Tak" || end == "tak" || end == "tAk" || end == "tAk")
                    {
                        break;
                    }
                    Console.Clear();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
       


        private static void Calc()
        {
            Console.WriteLine("Zgadywacz liczb!");

            Console.WriteLine("Wprowadź liczb od 1 do 50!");
            Random rand = new Random();
            int next = rand.Next(1, 50);

            int count = 0;
            while (true)
            {
                Console.WriteLine("Wprowadź liczbę: ");
                int number = int.Parse(Console.ReadLine());

                count++;
                if (number == next)
                {
                    Console.WriteLine($"Odgadłeś liczbę: {next}!");
                    break;
                }
                else if (number > next)
                {
                    Console.WriteLine("Liczba za duża!");
                }
                else
                {
                    Console.WriteLine("Liczna za mała!");
                }
            }
            Console.WriteLine($"Twoje próby {count}!");
            StreamWriter lol = File.CreateText("Gra.text");
            lol.WriteLine("$Odgadłeś liczbę: {next}!");
            lol.Close();
        }
    }
}
