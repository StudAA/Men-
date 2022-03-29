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
                int auswahl = 0;
                string s, auswahl0;
                string ausgabe = "";
                Console.WriteLine("1: Zeichen ersetzen.");
                Console.WriteLine("2: Vokale entfernen.");
                Console.WriteLine("3: Beenden.");


                auswahl0 = Console.ReadLine();
                if (auswahl0 != "1" && auswahl0 != "2" && auswahl0 != "3")
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
                        Console.WriteLine("Geben Sie eine Zeichenkette ein.");
                        s = Console.ReadLine();
                        Console.WriteLine("Welches Zeichen soll ersetzt werden?");
                        char z = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine("Durch was soll das Zeichen ersetzt werden?");
                        char e = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine("Es wird "+z+" durch "+e+" ersetzt.");
                        for (int i=0; i<s.Length; i++)
                        {
                            if (s[i]==z)
                            {
                                ausgabe += e;
                            }
                            else
                            {
                                ausgabe += s[i];
                            }
                        }
                        Console.WriteLine(s + " wird zu " + ausgabe);
                        break;
                    case 2:
                        Console.WriteLine("Vokabeln sollen entfernt werden.");
                        Console.WriteLine("Geben Sie eine Zeichenkette ein.");
                        s = Console.ReadLine();
                        for (int i=0; i<s.Length; i++)
                        {
                            if (s[i]=='a' || s[i] == 'i' || s[i] == 'e' || s[i] == 'o' || s[i] == 'u')
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
                        Console.WriteLine("Programm wird beendet.");
                        Environment.Exit(0);
                        break;

                   /* default:
                        Console.WriteLine("Auswahl ungültig.");
                        break;*/
                }




                

                Console.WriteLine("Neue Auswahl? (j/n)");
                wiederholen = Console.ReadLine();
            } while (wiederholen == "j" || wiederholen == "J");

        }
    }
}
