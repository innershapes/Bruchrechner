/*****************************************************************************
Berufschule:    HHEK Bonn
Authorin:		Apostolka Christov
Klasse:			IA219
Datum:			24.08.2020
Datei:          run.cs
*****************************************************************************/

using System;

namespace Bruchrechner
{
    partial class MainClass
    {
        //Die eigentliche Kalkulation finden in den run-Methode staat.
        static void Run()
        {
            // Zeige den Willkommen/Info Screen
            Splash();

            bool weiter = true;

            //Haupschleife
            while (weiter)
            {
                // Zeige die zur Verfüng stehenden Funktionen, und wie sie zu anwenden sind.
                string auswahl = Hauptmenue();
                if (auswahl == "a")
                {
                    WriteText("Nun gebe bitte den Zaehler deins ersten Bruchs ein:");
                    string zaeler1 = Console.ReadLine();
                    Console.Clear();

                    WriteText("Nun gebe bitte den Nenner deins ersten Bruchs ein:");
                    string nenner1 = Console.ReadLine();
                    Console.Clear();

                    WriteText("Nun gebe bitte den Zaehler deins zweiten Bruchs ein:");
                    string zaeler2 = Console.ReadLine();
                    Console.Clear();

                    WriteText("Nun gebe bitte den Nenner deins zweiten Bruchs ein:");
                    string nenner2 = Console.ReadLine();
                    Console.Clear();

                    // Convert string to int
                    int intZaeler1 = Parse(zaeler1);
                    int intNenner1 = Parse(nenner1);
                    int intZaeler2 = Parse(zaeler2);
                    int intNenner2 = Parse(nenner2);
                    Addiere(intZaeler1, intNenner1, intZaeler2, intNenner2);
                }

                else if (auswahl == "s")
                {
                    WriteText("Nun gebe bitte den Zaehler deins ersten Bruchs ein:");
                    string zaeler1 = Console.ReadLine();
                    Console.Clear();

                    WriteText("Nun gebe bitte den Nenner deins ersten Bruchs ein:");
                    string nenner1 = Console.ReadLine();
                    Console.Clear();

                    WriteText("Nun gebe bitte den Zaehler deins zweiten Bruchs ein:");
                    string zaeler2 = Console.ReadLine();
                    Console.Clear();

                    WriteText("Nun gebe bitte den Nenner deins zweiten Bruchs ein:");
                    string nenner2 = Console.ReadLine();
                    Console.Clear();

                    // Convert string to int
                    int intZaeler1 = Parse(zaeler1);
                    int intNenner1 = Parse(nenner1);
                    int intZaeler2 = Parse(zaeler2);
                    int intNenner2 = Parse(nenner2);
                    Substrahiere(intZaeler1, intNenner1, intZaeler2, intNenner2);
                }

                else if (auswahl == "m")
                {
                    WriteText("Nun gebe bitte den Zaehler deins ersten Bruchs ein:");
                    string zaeler1 = Console.ReadLine();
                    Console.Clear();

                    WriteText("Nun gebe bitte den Nenner deins ersten Bruchs ein:");
                    string nenner1 = Console.ReadLine();
                    Console.Clear();

                    WriteText("Nun gebe bitte den Zaehler deins zweiten Bruchs ein:");
                    string zaeler2 = Console.ReadLine();
                    Console.Clear();

                    WriteText("Nun gebe bitte den Nenner deins zweiten Bruchs ein:");
                    string nenner2 = Console.ReadLine();
                    Console.Clear();

                    // Convert string to int
                    int intZaeler1 = Parse(zaeler1);
                    int intNenner1 = Parse(nenner1);
                    int intZaeler2 = Parse(zaeler2);
                    int intNenner2 = Parse(nenner2);
                    Multipliziere(intZaeler1, intNenner1, intZaeler2, intNenner2);
                }

                else if (auswahl == "d")
                {
                    WriteText("Nun gebe bitte den Zaehler deins ersten Bruchs ein:");
                    string zaeler1 = Console.ReadLine();
                    Console.Clear();

                    WriteText("Nun gebe bitte den Nenner deins ersten Bruchs ein:");
                    string nenner1 = Console.ReadLine();
                    Console.Clear();

                    WriteText("Nun gebe bitte den Zaehler deins zweiten Bruchs ein:");
                    string zaeler2 = Console.ReadLine();
                    Console.Clear();

                    WriteText("Nun gebe bitte den Nenner deins zweiten Bruchs ein:");
                    string nenner2 = Console.ReadLine();
                    Console.Clear();

                    // Convert string to int
                    int intZaeler1 = Parse(zaeler1);
                    int intNenner1 = Parse(nenner1);
                    int intZaeler2 = Parse(zaeler2);
                    int intNenner2 = Parse(nenner2);
                    Dividiere(intZaeler1, intNenner1, intZaeler2, intNenner2);
                }

                else if (auswahl == "b")
                {
                    Console.Clear();
                    WriteText("Moechtest du wuerklich das Programm beenden? Drucke y/n:");
                    string beende = Console.ReadLine();
                    if (beende == "y")
                    {
                        WriteText("Drucke eine Taste um das Programm zu beenden!");
                        weiter = false;
                    }
                    else
                    {
                        WriteText("Zurueck ins Hauptmenue.....");
                        Console.Clear();
                    }

                }
                else
                {
                    WriteText(auswahl + " ist keine moegliche Auswahl. Eine Taste druecken zum Rueclkehren ins Hauptmenue....");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}