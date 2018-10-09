using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helllo
{
    class Program
    {
        static void Main(string[] args)
        {
            string imie;
            string nazwisko;
            int wiek;

            if (args.Length == 0)
            {
                Console.WriteLine("Proszę podać swoje dane - imię, nazwisko oraz wiek.");

                Console.Write("Podaj swoje imię: ");
                imie = Console.ReadLine();

                Console.Write("Podaj swoje nazwisko: ");
                nazwisko = Console.ReadLine();

                Console.Write("Podaj swój wiek: ");
                wiek = Convert.ToInt32(Console.ReadLine());

                if (wiek < 0)
                {
                    Console.WriteLine("Witaj, " + imie + " " + nazwisko + ". Niestety wprowadzono błedne dane. Spróbuj ponownie.");
                }

                else if (wiek <= 67)
                {
                    Console.WriteLine("Witaj, " + imie + " " + nazwisko + ". Masz " + wiek + " lat. Do emerytury pozostało Ci {0} lat.", 67 - wiek);
                }

                else
                {
                    Console.WriteLine("Witaj, " + imie + " " + nazwisko + ". Masz " + wiek + " lat. Gratulacje, jesteś emerytem!");
                }
            }

            else if (args.Length == 1)
            {
                imie = args[0];
                Console.WriteLine("Witaj " + imie + "! Poniżej uzupełnij swoje dane.", imie);

                Console.Write("Podaj swoje nazwisko: ");
                nazwisko = Console.ReadLine();

                Console.Write("Podaj swój wiek: ");
                wiek = Convert.ToInt32(Console.ReadLine());

                if (wiek < 0)
                {
                    Console.WriteLine("Witaj, " + imie + " " + nazwisko + ". Niestety wprowadzono błedne dane. Spróbuj ponownie.");
                }
                else if (wiek <= 67)
                {
                    Console.WriteLine("Witaj, " + imie + " " + nazwisko + ". Masz " + wiek + " lat. Do emerytury pozostało Ci {0} lat.", 67 - wiek);
                }
                else
                {
                    Console.WriteLine("Witaj, " + imie + " " + nazwisko + ". Masz " + wiek + " lat. Gratulacje, jesteś emerytem!");
                }
            }
            else if (args.Length == 2)
            {
                imie = (args[0]);
                nazwisko = (args[1]);
                Console.WriteLine("Witaj, " + imie + " " + nazwisko + "!");

                Console.Write("Podaj swój wiek: ");
                wiek = Convert.ToInt32(Console.ReadLine());

                if (wiek < 0)
                {
                    Console.WriteLine("Witaj, " + imie + " " + nazwisko + ". Niestety wprowadzono błedne dane. Spróbuj ponownie.");
                }

                else if (wiek <= 67)
                {
                    Console.WriteLine("Witaj, " + imie + " " + nazwisko + ". Masz " + wiek + " lat. Do emerytury pozostało Ci {0} lat.", 67 - wiek);
                }
                else
                {
                    Console.WriteLine("Witaj, " + imie + " " + nazwisko + ". Masz " + wiek + " lat. Gratulacje, jesteś emerytem!");
                }
            }

            else if (args.Length == 3)
            {
                imie = (args[0]);
                nazwisko = (args[1]);
                wiek = Convert.ToInt32(args[2]);
                if (wiek < 0)
                {
                    Console.WriteLine("Witaj, " + imie + " " + nazwisko + ". Niestety wprowadzono błedne dane. Spróbuj ponownie.");
                }

                else if (wiek <= 67)
                {
                    Console.WriteLine("Witaj, " + imie + " " + nazwisko + ". Masz " + wiek + " lat. Do emerytury pozostało Ci {0} lat.", 67 - wiek);
                }

                else
                {
                    Console.WriteLine("Witaj, " + imie + " " + nazwisko + ". Masz " + wiek + " lat. Gratulacje, jesteś emerytem!");
                }
            }

            else if (args.Length >= 3)
            {
                imie = (args[0]);
                nazwisko = (args[1]);
                wiek = Convert.ToInt32(args[2]);
                if (wiek < 0)
                {
                    Console.WriteLine("Witaj, " + imie + " " + nazwisko + ". Niestety wprowadzono błedne dane. Spróbuj ponownie.");
                }

                else if (wiek <= 67)
                {
                    Console.WriteLine("Witaj, " + imie + " " + nazwisko + ". Masz " + wiek + " lat. Do emerytury pozostało Ci {0} lat.", 67 - wiek);
                    Console.Write("Pozostałe dane nie były potrzebne. ");
                }

                else
                {
                    Console.WriteLine("Witaj, " + imie + " " + nazwisko + ". Masz " + wiek + " lat. Gratulacje, jesteś emerytem!");
                    Console.Write("Pozostałe dane nie były potrzebne. ");
                }
            }

            Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować program.");
            Console.ReadKey();
        }
    }
    //Copyright © by:              Karol Bronowski
    //Code of the laboratory:      inf1A/1/IE/S
    //Number of album:             10502
}