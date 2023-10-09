using System;

namespace inlämning_3._5;

class Program
{
    static void Main(string[] args)
    {
        double num1, num2, resultat;

        Console.Write("Skriv in det första talet: ");
        if (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Ogiltig inmatning för det första talet.");
        }

        Console.Write("Skriv in det andra talet: ");
        if (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Ogiltig inmatning för det andra talet.");
        }

        Console.WriteLine("Välj ett räknesätt:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraktion");
        Console.WriteLine("3. Multiplikation");
        Console.WriteLine("4. Division");

        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
        {
            Console.WriteLine("Ogiltigt val.");
        }

        switch (choice)
        {
            case 1:
                resultat = num1 + num2;
                Console.WriteLine("Resultatet av additionen är: " + resultat);
                break;
            case 2:
                resultat = num1 - num2;
                Console.WriteLine("Resultatet av subtraktionen är: " + resultat);
                break;
            case 3:
                resultat = num1 * num2;
                Console.WriteLine("Resultatet av multiplikationen är: " + resultat);
                break;
            case 4:
                if (num2 == 0)
                {
                    Console.WriteLine("Kan inte dela med noll.");
                }
                resultat = num1 / num2;
                Console.WriteLine("Resultatet av divisionen är: " + resultat);
                break;
        }
    }
}
