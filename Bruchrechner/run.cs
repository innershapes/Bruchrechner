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
            // Zeige den Willkommen und Info Screen
            Splash();
            // Zeige die zur Verfüng stehenden Funktionen, und wie sie zu anwenden sind. 
            Hauptmenue();

            //
            while (true) 
            {
                string auswahl = Hauptmenue();
            }
        }
    }
}