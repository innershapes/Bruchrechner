/*****************************************************************************
Berufschule:    HHEK Bonn
Authorin:		Apostolka Christov
Klasse:			IA219
Datum:			24.08.2020
Datei:          hauptmenue.cs
Beschreibung:   Im Module finden Sie die Methode
                zum Anzeigen der Haupmenue
*****************************************************************************/

using System;

namespace Bruchrechner
{
    partial class MainClass
    {
        // Zeigt die verfügbaren Funktionen zum Berechnung eines Bruchs
        // und die Tastatur-Tasten zum Auswahl die Funktionen.
        // Erfasst den User-Input und gibt ihn aus zu weiterer Bearbeitung in der run-Methode.
        static string Hauptmenue()
        //TODO: Find out how to capture user-input that is a single character 
        {
            Console.SetCursorPosition(34, 11);
            WriteText("Hauptmenue");
            AddNewLine(1);
            WriteText("        Zum Kalkulieren eines Bruchs waehle von der folgenden Funktionen aus:");
            AddNewLine(1);
            WriteText("                        Zum Addieren [+] drucke Taste (a)");
            WriteText("                   Zum Substrahieren [-] drucke Taste (s)");
            WriteText("                  Zum Multiplizieren [*] drucke Taste (m)");
            WriteText("                      Zum Dividieren [/] drucke Taste (d)");
            AddNewLine(1);
            WriteText("               Zum Beenden des Programms drucke Taste (b)");
            AddNewLine(1);

            string auswahl = Console.ReadLine();
            Console.Clear();
            return auswahl;
        }
    }
}
