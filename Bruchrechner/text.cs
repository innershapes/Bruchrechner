/*****************************************************************************
Berufschule:    HHEK Bonn
Authorin:		Apostolka Christov
Klasse:			IA219
Datum:			24.08.2020
Datei:          Main.cs
Beschreibung:   Im Module befinden sich Funktionen zum Umgang mit Text
*****************************************************************************/

using System;

namespace Bruchrechner
{
    partial class MainClass
    {
        // Create new line
        static void NewLine(int numLines)
        {
            for (int i = 0; i < numLines; i++)
            {
                Console.WriteLine();
            }
        }
    }
}
