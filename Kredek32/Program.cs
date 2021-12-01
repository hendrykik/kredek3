using System;
using System.Collections.Generic;

namespace Kredek32
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tab = {"w","i","d","e","l","e","c"};

            string z = "";
            string slowo = "";
            Console.WriteLine("Zgadnij wisielca\n");
            foreach(string item in tab)
            {
                z += "_ ";
                slowo += item;
            }
            Console.WriteLine(z+"\n");

            var liczby = new List<int> { };
            int c = 3;
            while (c!=0) {
                int ilosc = 0;
                string a = Console.ReadLine();
                for (int i=0; i<tab.Length; i++)
                {
                    if (tab[i] == a)
                    {
                        ilosc += 1;
                        liczby.Add(i);
                    }
                }
                Console.WriteLine($"Literka pojawia się " + ilosc + " razy");
                if(ilosc == 0)
                {
                    if (c == 1)
                    {
                        Console.WriteLine("Przegrałeś");
                        Console.WriteLine(":(((((");
                    }
                    c -= 1;
                    if (c != 0)
                    {
                        Console.WriteLine("Zostało ci " + c + " prób");
                    }
                }
                string b = "";
                string spr = "";
                int odej = 0;
                foreach (string jed in tab) {
                    odej = 0;
                    foreach (var licz in liczby) { 
                        if (jed==tab[licz]) {
                            b += jed;
                            spr += jed;
                            odej = 1;
                            break;
                        }
                    }
                    if(odej==0)
                    {
                        b += "_";
                    }
                    b += " ";
                }
                if (c != 0)
                {
                    Console.WriteLine(b);
                }
                if (spr == slowo)
                {
                    Console.WriteLine("Brawo, zgadłeś słowo");
                    c = 0;
                }
                //foreach (var licz in liczby) { Console.WriteLine(licz); }
            }
        }
    }
}
