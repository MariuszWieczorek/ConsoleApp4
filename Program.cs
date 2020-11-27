using System;

namespace ConsoleApp4
{
    // gra
    // podzielna bez reszty przez 3 to FIS
    // podzielna bez reszty przez 5 to BUS
    // podzielna bez reszty przez 3 i 5 to FIZBUS
    // nie podzielna anie przez 3 anie przez 5 to zwracamy liczbę
    // metoda niestatyczna FIZBUS
    class Program
    {
        static void Main()
        {
            Console.WriteLine("FISBUS\nProszę podaj liczbę");
            int number = GetNumber();
            var myFisbus = new Fisbus();
            string result = myFisbus.ShowResult(number);
            Console.WriteLine(result);
        }

        static int GetNumber()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int number))
                {
                    string message = $"wpisanych znaków {input} nie można przekonwertować na liczbę, spróbuj ponownie";
                    Console.WriteLine(message);
                }
                else
                {
                    return number;
                }
            }
        }
    }
}
