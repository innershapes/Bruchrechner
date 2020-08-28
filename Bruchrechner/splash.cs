/*****************************************************************************
Berufschule:    HHEK Bonn
Authorin:		Apostolka Christov
Klasse:			IA219
Datum:			24.08.2020
Datei:          splash.cs
Beschreibung:   Im Module befindet sich die Methode zum Anzeigen der
                Programm-relevanten Informationen.
*****************************************************************************/

using System;


namespace Bruchrechner
{
    public partial class MainClass
    {

        // Outputs the welcome massage and information about the programm
        static void Splash()
        {
            SetBorder("-");
            Console.SetCursorPosition(34, 1);
            WriteText("WILLKOMMEN");
            SetBorder("-");
            AddNewLine(1);
            WriteText("                       Programm Name:     Bruchrechner");
            WriteText("                             Version:     1.0");
            WriteText("                             Autorin:     Apostolka Christov");
            WriteText("                        Erstelldatum:     26.08.2020");
            WriteText("                           Anwendung:     Zum Rechnen mit Brueche");
            AddNewLine(1);
            SetBorder("-");
            AddNewLine(1);
        }
    }
}
