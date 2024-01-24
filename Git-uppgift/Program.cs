using System;
using System.Linq;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;

class Program
{
    static void Main()
    {
        int val = 1;
        while (val > 0)
        {
            Console.WriteLine("Välkommen till multiprogrammet som gör det mesta. Välj vilket delprogram du vill köra");
            Console.WriteLine("1. Räkna ut hypotenusan på en triangel");//Problemlösning_1
            Console.WriteLine("2. Räkna ut en rektangels area"); //Problemlösning_2
            Console.WriteLine("3. Räkna ut medelvärdet av en lista med värden");//Problemlösning_3
            Console.WriteLine("4. Är en sträng/mening ett palindrom?");//Problemlösning_4
            Console.WriteLine("5. Skapa delay på x antal sekunder");//Problemlösning_5
            Console.WriteLine("6. Sortera några ord i bokstavsordning");//Problemlösning_6(WIP)
            Console.WriteLine("7. Kolla om ett tal är ett primtal");
            Console.WriteLine("8. Kolla vilka primtal som finns upp till ett visst tal");
            Console.WriteLine("9. Testa om ett nummer är 'PERFEKT'");
            Console.WriteLine("10. Vad blir ett tal i fakultet?");
            Console.WriteLine("11. Kryptera en text med ceasarkryptering");
            Console.WriteLine("12. Dekryptera en text som använder ceasarkryptering");
            Console.WriteLine("0. Avsluta programmet");


            Console.Write("Skriv in ditt val: ");
            val = int.Parse(Console.ReadLine());

            switch (val)
            {
                case 1:
                    {
                        float bas;
                        float hojd;
                        float hypo;
                        Console.WriteLine("Du vill räkna ut hypotenusan på en triangel. Skriv in bas och höjd för att få reda på hypotenusan.");
                        Console.Write("Skriv in bas: ");
                        bas = float.Parse(Console.ReadLine());
                        Console.Write("Skriv in hojd: ");
                        hojd = float.Parse(Console.ReadLine());
                        hypo = FuncHypotenusa(bas, hojd);
                        Console.WriteLine("Hypotenusan är: " + Math.Sqrt(hypo));
                        break;
                    }
                case 2:
                    {
                        float sida1;
                        float sida2;
                        float area;
                        Console.WriteLine("Vill du veta arean av en rektangel? Fyll i hur långa sidorna i nedan och låt funktionen göra jobbet");
                        Console.Write("Skriv in första sidans längd: ");
                        sida1 = float.Parse(Console.ReadLine());
                        Console.Write("Skriv in andra sidans längd: ");
                        sida2 = float.Parse(Console.ReadLine());
                        area = FuncRArea(sida1, sida2);
                        Console.WriteLine("Rektangelns area är: " + area);
                        break;
                    }
                case 3:
                    {
                        int[] lista = new int[100];
                        int antalnr;
                        float svar;
                        Console.WriteLine("Du söker medelvärdet av en massa värden. Följ instruktionerna i programmet och låt funktionen göra sin magic.");
                        Console.Write("Skriv in hur många nummer du vill använda att få ut medelvärde för: ");
                        antalnr = int.Parse(Console.ReadLine());
                        for (int i = 0; i < antalnr; i++)
                        {
                            Console.Write("Skriv in värde " + i + ": ");
                            lista[i] = int.Parse(Console.ReadLine());
                        }
                        svar = FuncMedelvarde(lista, antalnr);
                        Console.WriteLine("Medelvärdet är: " + svar);
                        break;
                    }
                case 4:
                    {
                        string palTest;
                        Console.WriteLine("Är en mening eller ett ord ett palindrom? Testa och skriv ett ord och se resultatet!");
                        Console.Write("Skriv ordet/meningen du vill testa om det är ett palindrom: ");
                        palTest = Console.ReadLine();
                        if (FuncIsPalindrom(palTest))
                        {
                            Console.WriteLine(palTest + " IS A FRICKIN' PALINDROME, MAN!");
                        }
                        else
                        {
                            Console.WriteLine("No luck.. " + palTest + " is no palindrome");
                        }
                        break;
                    }
                case 5:
                    {
                        string ord;
                        int sek;
                        Console.WriteLine("Så det finns en funktion som skapar delay? Ja, om nån har programmerat den! prova och skriv nåt å se om det blir delay.");
                        Console.Write("Skriv in det ord du vill ska skrivas ut med delay: ");
                        ord = Console.ReadLine();
                        Console.Write("Skriv in hur många sekunder du vill att delayen ska vara: ");
                        sek = int.Parse(Console.ReadLine());
                        FuncDelay(sek);
                        Console.WriteLine(ord);
                        break;
                    }
                case 6:
                    {
                        string ord;
                        string sorteratOrd;
                        Console.WriteLine("Sortera en sträng i bokstavsordning. Skriv '-' (ett bindestreck) mellan orden du vill sortera");
                        Console.WriteLine("Exempel: hej-yggdrasil-tomte-bonde");
                        Console.Write("Skriv in det du vill sortera i bokstavsordning: ");
                        ord = Console.ReadLine();
                        sorteratOrd = FuncSortera(ord);
                        Console.WriteLine("Först skrev du in: " + ord);
                        Console.WriteLine("Det blev till: " + sorteratOrd);
                        break;
                    }
                case 7:
                    {
                        int tal;
                        Console.WriteLine("Du vill prova om ett tal är primtal? Prova på!");
                        Console.Write("Skriv in ett tal och se om det är ett primtal: ");
                        tal = int.Parse(Console.ReadLine());
                        Console.WriteLine(tal + " är ett primtal? ");
                        Console.WriteLine(FuncIsPrime(tal));
                        break;
                    }
                case 8:
                    {
                        int varde;
                        Console.WriteLine("Dags att prova att få en lista med massa jäkla primtal upp till ett visst värde.");
                        Console.Write("Skriv in hur högt värde du vill hitta alla primtal upp till: ");
                        varde = int.Parse(Console.ReadLine());
                        int[] allPrimes;
                        allPrimes = FuncHittaPrimtal(varde);
                        Console.WriteLine("Denna lista som skrivs ut nedan är alla primtal upp till det tal du skrev in: ");
                        for (int i = 0; i < allPrimes.Length; i++)
                        {
                            Console.Write(allPrimes[i] + ", ");
                        }
                        break;
                    }
                case 9:
                    {
                        int tal;
                        Console.WriteLine("Testa om ett nummer är perfekt!");
                        Console.Write("Skriv in det tal du vill testa: ");
                        tal = int.Parse(Console.ReadLine());
                        Console.WriteLine(FuncPerfectNum(tal));
                        break;
                    }
                case 10:
                    {
                        int tal;
                        int svar;
                        Console.Write("Skriv in det tal du vill prova i fakultet: ");
                        tal = int.Parse(Console.ReadLine());
                        svar = FuncFakultet(tal);
                        Console.WriteLine(tal + " i fakultet blir: " + svar);
                        break;
                    }
                case 11:
                    {
                        int chiffer;
                        string text;
                        string kryptad;
                        Console.WriteLine("Kryptera en text! Skriv in chiffer (ett heltal mellan 1-20): ");
                        chiffer = int.Parse(Console.ReadLine());
                        Console.Write("Skriv in texten du vill kryptera: ");
                        text = Console.ReadLine();
                        kryptad = FuncCeasarCrypt(text, chiffer);
                        Console.WriteLine("Din text krypterad: " + kryptad);
                        break;
                    }
                case 12:
                    {
                        int chiffer;
                        string text;
                        string decrypt;
                        Console.WriteLine("Decrypt dax. Du behöver dels den krypterade strängen och dess chiffer");
                        Console.Write("Skriv in det chiffer som användes vid kryptering (ett heltal mellan 1-20): ");
                        chiffer = int.Parse(Console.ReadLine());
                        Console.Write("Skriv in texten du vill dekryptera: ");
                        text = Console.ReadLine();
                        decrypt = FuncCeasarDecrypt(text, chiffer);
                        // Implementera din dekrypteringslogik här
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Välkommen tillbaka");
                        break;
                    }
            }
        }
    }
    static float FuncHypotenusa(float bas, float hojd)
    {
        //myCode
        float hypotenusa = 0;
        hypotenusa = bas * bas + hojd * hojd;
        return hypotenusa;

        // Gör en funktion som räknar ut hypotenusan när
        // man får reda på basen och höjden av en rätvinklig triangel

    }

    static float FuncRArea(float bas, float hojd)
    {
        //MyCode
        float area = 0;
        area = bas * hojd;
        return area;

        // Gör en funktion som räknar ut area av en rektangel med värdena som fås av användaren.
        // Returnera arean

    }

    static float FuncMedelvarde(int[] listaMedVarden, int antal)
    {
        //MyCode
        float medel = 0;
        medel = listaMedVarden.Sum() / antal;
        return medel;


    }

    static bool FuncIsPalindrom(string mening)
    {
        //MyCode (hittad online och testad, vet inte om det finns något lättare sätt. Denna var svår...)
        bool palindrome = false;

        try
        {
            int halfLength = mening.Length / 2;

            string leftHalfString = mening.Substring(0, halfLength);

            char[] reversedArray = mening.ToCharArray();
            Array.Reverse(reversedArray);
            string reversedString = new string(reversedArray);

            string rightHalfStringReversed = reversedString.Substring(0, halfLength);

            palindrome = leftHalfString == rightHalfStringReversed ? true : false;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        // Ett palindrom är en sträng/mening/ord som läses likadant baklänges som framlänges se exemplen nedan.
        // Ex: "naturrutan", "kajak", "tillit", "mus rev inuits öra, sa röst i universum"
        // Man ignorerar whitespaces och komman (",") etc, bara bokstäverna betyder något.
        return palindrome;
    }

    static void FuncDelay(int sekunder)
    {
        //MyCode
        for (int i = 0; i < sekunder; i++) 
        {
            Thread.Sleep(1000);
            Console.WriteLine(1 + i + ".");               
        }

    }

    static string FuncSortera(string ord)
    {
        //MyCode(WIP)
        string[] strings = new string[ord.Length];
        string sorteradString = "";
        Array.Sort(strings);
        foreach (string s in strings) 
        {
            Console.WriteLine(sorteradString);
        }

        // Skapa en funktion som sorterar en sträng som kommer in i bokstavsordning.
        // Strängen som kommer in kommer innehålla flera ord, och det är de som ska sorteras i bokstavsordning.
        // Orden i strängen som kommer in kommer vara separerade med ett bindestreck, se exempel nedan.
        // Ex: (trollfabrik-tomater-fisk-påfågel) ska komma tillbaka som (fisk-påfågel-tomater-trollfabrik)
        return sorteradString;
    }

    static bool FuncIsPrime(int nummer)
    {
        bool test = false;
        // Gör en funtion som kollar om en siffra är ett primtal. Om det är ett primtal skicka tillbaka "True", annars "False".
        return test;
    }

    static int[] FuncHittaPrimtal(int nummer)
    {
        int[] primes = new int[100];
        // Gör en funktion som hittar alla primtal upp till numret som skickats in till funktionen.
        // Spara primtalen i en array.
        // Returnera detta som en array.
        // Använd gärna funktionen som vi skapat för att kolla om ett tal är primtal (FuncIsPrime())
        return primes;
    }

    static bool FuncPerfectNum(int nummer)
    {
        bool isPerfect = false;
        // Gör en funktion som provar om ett tal är "perfekt". Vad är ett "perfekt" tal då? Kolla nedan.
        // Ett perfekt tal är ett tal där alla dess delbara heltal summerat är lika med sig själv.
        // Ex: Det första perfekta talet är 6 eftersom 6 är delbart med 1, 2 och 3. Summan av 1 + 2 + 3 = 6.
        // Ledtråd: Använd modulo (%).
        return isPerfect;
    }

    static int FuncFakultet(int nummer)
    {
        int svar = 0;
        // Skapa en funktion som räknar ut "fakulteten" av talet som skickas in.
        // Ett tal i fakultet skrivs "3!" och betyder att man multiplicerar talet med alla heltal som är lägre än sig själv.
        // I ovanstående exempel skulle det bli 3 * 2 * 1 = 6
        // Skickar användaren in en 6:a ska funtionen alltså ta 6*5*4*3*2*1 = 720
        // Returnera svaret
        return svar;
    }

    static string FuncCeasarCrypt(string mening, int nummer)
    {
        string krypt = "";
        // Skapa en funktion som krypterar en sträng med hjälp av ceasarkryptering.
        // Ceasar-kryptering fungerar på så sätt att man tar en bokstav i taget och flyttar fram den ett visst antal bokstäver framåt.
        // Om jag vill göra en kryptering på en sträng behöver jag först välja antalet tecken jag vill flytta i strängen. I mitt exempel väljer jag 10 steg.
        // "Tobias äger" börjar med att jag kollar 10 bokstäver fram på stora T i en ASCII-tabell vilket blir tecknet ^. Sen fortsätter jag bokstav för bokstav.
        // Färdig kryptering av strängen "Tobias äger": ^ylsk}*Äqo|
        // Ovanstående är gjort för hand men är förhoppningsvis rätt. Varje bokstav 10 steg framåt i ASCII-tabellen.
        // Returnera krypterad text
        return krypt;
    }

    static string FuncCeasarDecrypt(string mening, int nummer)
    {
        string decrypt = "";
        // Skapa en motsatt funktion som ovan, men som istället för att gå "nummer" steg framåt i ASCII-tabellen, gå istället bakåt.
        return decrypt;
    }


}