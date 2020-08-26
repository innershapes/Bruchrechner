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
        // Create new line
        static void NewLine(int numLines)
        {
            for (int i = 0; i < numLines; i++)
            {
                Console.WriteLine();
            }
        }

        // Output the welcome massage and information about the programm
        static void Splash()
        {
            string astrerisk = "-";

            Console.WriteLine(String.Concat(Enumerable.Repeat(astrerisk, 79)));
            Console.SetCursorPosition(34, 2);
            Console.WriteLine("WELCOME");
            Console.WriteLine(String.Concat(Enumerable.Repeat(astrerisk, 79)));
            NewLine(2);
            Console.SetCursorPosition(34, 2);

        }
    }
}
