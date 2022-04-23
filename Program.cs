using System;
using System.Threading;

namespace IsikukoodAnalyze
{
    public class IsikukoodAnalyze
    {
        public static void Main()
        {
            bool exit = false;
            Console.Beep();
            Console.Title = "Isikukood analüüs";
            Console.WriteLine("Tere tulemast isikukood analüüsimine!");
            Console.ReadLine();
            do
            {
                Console.Clear();
                Console.WriteLine("Kas me alustame isikukood generaatori tegema või analüüsi?\n1. Generaator (katki)\n2. Analüüs (katki)\n3. Välju");

                string gva = Console.ReadLine();

                if (gva == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Hakkame alustama...");
                    Thread.Sleep(2000);
                    Console.WriteLine("Number 1: Mees või Naine?\n1. Mees\n2. Naine\nVastus:");

                    string mvn = Console.ReadLine();

                    if (mvn == "1")
                    {
                        Console.WriteLine("Mis ta sündis aastal?\n1. 1800-1899\n2. 1900-1999\n3. 2000-2099\n4.2100-2199\nVastus:");

                        string mms1 = Console.ReadLine();
                        if (mms1 == "1")
                        {

                        }

                        string mms2 = Console.ReadLine();
                        if (mms2 == "2")
                        {

                        }
                    }
                    else if (mvn == "2")
                    {

                    }
                }
                else if (gva == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Sisesta su isikukood programmis...");

                    string isikuan1 = Console.ReadLine();

                    if (isikuan1 == "2")
                    {
                        Console.Write("Naine");
                        return;
                    }

                    Console.Write("Sündis aastal: ");
                    Console.Write("Šeks: " + isikuan1);

                }
                else if (gva == "3")
                {
                    Console.WriteLine("Täname, et proovisite minu programmi!\nAutoriõigus 2022 Martin Eesmaa");
                    Thread.Sleep(2000);
                    exit = true;
                }
                else
                {

                }
            }
            while (exit == false);
        }
    }
}