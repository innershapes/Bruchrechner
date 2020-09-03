/*****************************************************************************
Berufschule:    HHEK Bonn
Authorin:		Apostolka Christov
Klasse:			IA219
Datum:			24.08.2020
Datei:          Main.cs
Beschreibung:   Im Module befinden sich Funktionen zum Umgang mit Text
*****************************************************************************/

using System;
using System.Linq;

namespace Bruchrechner
{
    partial class MainClass
    {
        // Creates new line
        static void AddNewLine(int numLines)
        {
            for (int i = 0; i < numLines; i++)
            {
                Console.WriteLine();
            }
        }

        // Adds text. The methode takes a string argument
        static void WriteText(string text)
        {
            Console.WriteLine(text);
        }

        // Set horizontal page border. Pass a string argument with the prefered sign
        static void SetBorder(string sign)
        {
            Console.WriteLine(String.Concat(Enumerable.Repeat(sign, 79)));
        }

        static void PrintOutput(string ergebnisZ, string ergebnisN)
        {
            WriteText(ergebnisZ);
            WriteText("----");
            WriteText(ergebnisN);
        }
    }   
}
