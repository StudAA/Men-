using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menü
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arbeiten mit strings

            /* 
            string s="example";
            s[1]='x'
            s.Length=7
            for (int i=0; i<s.Length;i++)
            {
               Console.WriteLine(s[i]);
            }
            */

            // s.Replace();
            // ausgabe = s.Replace(z, e);

            string wiederholen;
            

            do
            {
                int auswahl = 0, ziffer, summe = 0;
                string s, auswahl0, gk, ausgabe = "", k = "", ausgabe1 = "",E = "";
                Console.WriteLine("1: Zeichen ersetzen.");
                Console.WriteLine("2: Vokale entfernen.");
                Console.WriteLine("3: Quersumme bilden");
                Console.WriteLine("4: Beenden.");
                Console.WriteLine("\nAuswahl:");


                auswahl0 = Console.ReadLine();
                if (auswahl0 != "1" && auswahl0 != "2" && auswahl0 != "3" && auswahl0 != "4")
                {
                    Console.WriteLine("Auswahl ist ungültig.");
                }
                else
                {
                    auswahl = Convert.ToInt32(auswahl0);
                }

                switch (auswahl)
                {
                    case 1:
                        Console.WriteLine("Zeichen sollen ersetzt werden.");
                        Console.WriteLine("Geben Sie eine Zeichenkette ein:");
                        s = Console.ReadLine();
                        Console.WriteLine("Welches Zeichen soll ersetzt werden?");
                        char z = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine("Durch was soll das Zeichen ersetzt werden?");
                        char e = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine("Groß- und Kleinschreibung beachten? (j/n)");
                        gk = Console.ReadLine();
                        for (int i = 0; i < 1; i = 0)
                        {
                            if (gk == "j" || gk == "J" || gk == "n" || gk == "N")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Auswahl ist ungültig.");
                                Console.WriteLine("Groß- und Kleinschreibung beachten? (j/n)");
                                gk = Console.ReadLine();
                            }
                        }
                        Console.WriteLine("Es wird "+z+" durch "+e+" ersetzt.");
                        if (gk == "j" || gk == "J")
                        {
                            for (int i = 0; i < s.Length; i++)
                            {
                                if (s[i] == z)
                                {
                                    ausgabe += e;
                                }
                                else
                                {
                                    ausgabe += s[i];
                                }
                            }
                        }
                        if (gk=="n" || gk=="N")
                        {
                            E = e.ToString();
                            E = E.ToUpper();
                            for (int i = 0; i < s.Length; i++)
                            {
                                k = z.ToString();
                                k = k.ToUpper();
                                if (s[i] == k[0])
                                {
                                    ausgabe1 += E;
                                }
                                else
                                {
                                    ausgabe1 += s[i];
                                }
                            }
                        }
                        if (gk == "n" || gk == "N")
                        {
                            E = E.ToLower();
                            for (int i = 0; i < ausgabe1.Length; i++)
                            {
                                k = k.ToLower();
                                if (ausgabe1[i] == k[0])
                                {
                                    ausgabe += E;
                                }
                                else
                                {
                                    ausgabe += ausgabe1[i];
                                }
                            }
                        }
                        Console.WriteLine(s + " wird zu " + ausgabe);
                        break;
                    case 2:
                        Console.WriteLine("Vokale sollen entfernt werden.");
                        Console.WriteLine("Geben Sie eine Zeichenkette ein:");
                        s = Console.ReadLine();
                        for (int i=0; i<s.Length; i++)
                        {
                            if (s[i]=='a' || s[i] == 'i' || s[i] == 'e' || s[i] == 'o' || s[i] == 'u' || s[i] == 'A' || s[i] == 'I' || s[i] == 'E' || s[i] == 'O' || s[i] == 'U')
                            {
                                ausgabe += "";
                            }
                            else
                            {
                                ausgabe += s[i];
                            }
                        }
                        Console.WriteLine(s + " wird zu " + ausgabe);
                        break;
                    case 3:
                        Console.WriteLine("Geben Sie eine Zahl an:");
                        string zahl = Console.ReadLine();
                        for (int i=0;i<zahl.Length;i++)
                        {
                            ziffer = Convert.ToInt32(zahl[i]);
                            Console.WriteLine(ziffer);
                            summe = summe + ziffer;
                        }
                        Console.WriteLine("Die Quersumme ist:" + summe);
                        break;
                    case 4:
                        Console.WriteLine("Programm wird beendet.");
                        Environment.Exit(0);
                        break;

                   /* default:
                        Console.WriteLine("Auswahl ungültig.");
                        break;*/
                }




                

                Console.WriteLine("Neue Auswahl? (j/n)");
                wiederholen = Console.ReadLine();
                for (int i=0; i<1; i=0)
                {
                    if (wiederholen != "j" && wiederholen != "J" && wiederholen != "n" && wiederholen != "N")
                    {
                        Console.WriteLine("Auswahl ist ungültig.");
                        Console.WriteLine("Neue Auswahl? (j/n)");
                        wiederholen = Console.ReadLine();
                    }
                    else
                    {
                        break;
                    }
                }
            } while (wiederholen == "j" || wiederholen == "J");

        }
    }
}
