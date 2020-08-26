/*****************************************************************************
Berufschule:    HHEK Bonn
Authorin:		Apostolka Christov
Klasse:			IA219
Datum:			24.08.2020
Datei:          splash.cs
*****************************************************************************/

using System;
using System.Linq;

namespace Bruchrechner
{
    public partial class MainClass
    {

        // Output the welcome massage and information about the programm
        static void Splash()
        {
            string astrerisk = "-";

            Console.WriteLine(String.Concat(Enumerable.Repeat(astrerisk, 79)));
            Console.SetCursorPosition(34, 1);
            AddText("WILLCOMMEN");
            Console.WriteLine(String.Concat(Enumerable.Repeat(astrerisk, 79)));
            NewLine(2);
            AddText("   Programm Name:     Bruchrechner");
            AddText("Programm Version:     V1.0");
            AddText("         Autorin:     Apostolka Christov");
            AddText("    Erstelldatum:     26.08.2020");
            AddText("       Anwendung:     Zum Rechnen mit Brueche");
            NewLine(2);
            Console.WriteLine(String.Concat(Enumerable.Repeat(astrerisk, 79)));
        }
    }
}
