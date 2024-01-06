using System;

namespace projekt_21an
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till 21an");
            int input = 0;
            while (input != 4)
            {

                Console.WriteLine("Välj ett altenativ:");
                Console.WriteLine("1. Spela 21:an");
                Console.WriteLine("2. Visa senaste vinnaren");
                Console.WriteLine("3. Spelets regler");
                Console.WriteLine("4. Avsluta");
                input = int.Parse(Console.ReadLine());
                Random random = new Random();
                string vinnare = "Det finns ingen tidigare vinnare";
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Nu kommer två kor dras per spelare");
                        int spelare = random.Next(1, 10) + random.Next(1,10);
                        int dator = random.Next(1, 10) + random.Next(1,10);
                        Console.WriteLine("Dina poäng: " + spelare);
                        Console.WriteLine("Datorns poäng: " + dator);
                        Console.WriteLine("Vill du dra ett till kort (j/n)");
                        string svar = Console.ReadLine();
                        while (svar.ToLower() == "j" && spelare <= 21)
                        {
                            int nyttkort = random.Next(1, 10);
                            Console.WriteLine("Ditt nya kort är värt " + nyttkort + " poäng");
                            spelare += nyttkort;
                            Console.WriteLine("Dina poäng: " + spelare);
                            Console.WriteLine("Datorns poäng: " + dator);
                            Console.WriteLine("Vill du dra ett till kort (j/n)");
                        }

                        Console.WriteLine("Datorn drog ett kort värt ");
                        if (spelare == 21 || dator > 21)
                        {
                            Console.WriteLine("Du vann!");
                            Console.WriteLine("Skriv in ditt namn");
                            vinnare = Console.ReadLine();
                        }
                        else if (spelare > 21 || dator > spelare )
                        {
                            Console.WriteLine("Datorn vann!");
                            vinnare = "Datorn";
                        }
                        break;
                    case 2:
                        Console.WriteLine("Senaste vinnaren var: " + vinnare);
                        break;
                    case 3:
                        Console.WriteLine("Regler");
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Du har inte valt ett validet alternativ");
                        break;
                }
            }
        }
    }
}