/*****************************************************************************
Berufschule:    HHEK Bonn
Authorin:		Apostolka Christov
Klasse:			IA219
Datum:			24.08.2020
Datei:          menue.cs
Beschreibung:   Im Module finden Sie die Methode
                zum Anzeigen der Bedienungsanleitung
*****************************************************************************/

using System;

namespace Bruchrechner
{
    partial class MainClass
    {
        static void Menue()
        {
            Console.SetCursorPosition(34, 11);
            WriteText("Hauptmenue");
            AddNewLine(1);
            WriteText("        Zum Kalkulieren der gewuenschten Brueche druecke die folgenden Taste:");
            AddNewLine(1);
            WriteText("                        Zum Addieren [+]:     (A)");
            WriteText("                   Zum Substrahieren [-]:     (S)");
            WriteText("                  Zum Multiplizieren [*]:     (M)");
            WriteText("                      Zum Dividieren [/]:     (D)");
            AddNewLine(1);
            WriteText("                    Zum Programm Beenden:     (B)");

        }
    }
}
