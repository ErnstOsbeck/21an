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
                            svar = "x";
                            int nyttkort = random.Next(1, 10);
                            Console.WriteLine("Ditt nya kort är värt " + nyttkort + " poäng");
                            spelare += nyttkort;
                            Console.WriteLine("Dina poäng: " + spelare);
                            Console.WriteLine("Datorns poäng: " + dator);
                            Console.WriteLine("Vill du dra ett till kort (j/n)");
                        }
                        int nyttkort2 = random.Next(1, 10);
                        Console.WriteLine("Datorn drog ett kort värt " + nyttkort2);
                        dator += nyttkort2;
                        Console.WriteLine("Datorns poäng: " + dator);
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
                        Console.WriteLine("Varje runda i Blackjack börjar med att spelarna som sitter vid bordet lägger en insats i satsningrutorna de sitter vid, även kallat ‘boxar’. Lägsta och högsta tillåtna insats visas tydligt på bordet, och insatsens storlek kan väljas genom att klicka på en marker i det belopp du vill satsa. När insatsen (eller insatserna) har lagts så får varje spelare två öppna kort framför sin ruta och dealern får antingen ett öppet kort (European) eller två öppna kort (Atlantic City), beroende på vilken variant som spelas.\r\n\r\nMålet i Blackjack är att få en bättre hand än dealern. För att göra det, måste du ha en hand som är högre än dealerns, utan att handens totala värde överstiger 21. Du kan även vinna genom att ha ett totalt värde under 22 när det totala värdet på dealerns hand överstiger 21. Om det totala värdet för din hand blir 22 eller högre, så är du 'tjock' ('bust'), vilket innebär att du automatiskt förlorar din insats.\r\n\r\nNär det är din tur kan du be om fler kort till din hand för att försöka öka dess totala värde. Efter att du har dragit önskat antal kort kommer dealern att slutföra sin hand. Reglerna för hur detta sker är väldigt strikta och varierar beroende på vilken typ av Blackjack som spelas. Se till att du förstår reglerna för varje variant eftersom detta har stor betydelse för dina strategiska beslut i varje hand.\r\n\r\nDen bästa handen i Blackjack är, inte helt oväntat, ‘Blackjack‘. Denna hand betalar mer än någon annan kombination (upp till 3:2 på din insats, beroende på vilken variant du spelar), och utgörs av ett ess plus ett kort som är värt 10 - d.v.s. tio, knekt, dam, kung. Blackjack måste fås på dina två första kort, och denna hand är oslagbar. Det kan dock sluta lika om även dealern får Blackjack.\r\n\r\nI Blackjack har tior, knektar, damer och kungar alla ett värde av 10. Ess kan vara värt antingen ett eller elva (du väljer vilket). När du t.ex. kombinerar ett ess och en fyra så kan din hand vara värd antingen fem eller 15. När ett ess värderas till 11, kallas den högre totalen ofta för en ‘soft’ total, så exemplet ovan skulle kallas för ‘soft 15’. Spelare med en ‘soft‘ hand kan antingen dra kort eller dubbla utan risk att bli tjock. En soft hand behöver dock inte bli bättre för att du drar ett till kort.\r\n\r\nVinnarhänder i Blackjack betalar vanligen ut ett-mot-ett (1 mot 1), även kallat ‘jämna pengar‘. Om du satsar 20 marker och vinner handen så får du därför normalt 20 marker plus din insats tillbaka. Om du får Blackjack när du spelar en variant som betalar 3 mot 2 så får du 30 marker plus din insats, om inte dealern också får Blackjack.\r\n\r\n‘Push’ är när din hand blir lika med dealerns hand. Om detta sker, får du tillbaka din insats, men ingen vinst. Om du förlorar din hand, går din insats till huset. Det finns undantag till dessa generella regler, och dessa förklaras nedan och på varje spelvariants regelsida.\r\n\r\nVanligtvis får du din vinst när dealern har avslutat sin hand. Det är viktigt att du läser reglerna för varje variant för att förstå hur dessa skiljer sig åt, eftersom reglerna för hur dealern spelar sin hand är väldigt strikta och ofta olika. Den vanligaste skillnaden mellan olika varianter är om dealern tar kort på soft 17 eller inte. I vissa varianter måste dealern stanna på soft 17, medan dealern måste ta kort i andra. I samtliga Blackjack-spel drar dealern kort på alla varianter av 16 eller lägre.");
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
