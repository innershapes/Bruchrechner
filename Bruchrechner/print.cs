/*****************************************************************************
Berufschule:    HHEK Bonn
Authorin:		Apostolka Christov
Klasse:			IA219
Datum:			24.08.2020
Datei:          print.cs
Beschreibung:   Im Module befinden sich Hilfsfunktionen zum Ausgabe
                von Outputs
*****************************************************************************/


using System;
namespace Bruchrechner
{
    partial class MainClass
    {
        // Hilfsfunktion zum Ausgabe von Bruchergebnis
        static void PrintErgebnis(string ergebnisZ, string ergebnisN)
        {
            WriteText(ergebnisZ);
            WriteText("----");
            WriteText(ergebnisN);
        }
    }
}
