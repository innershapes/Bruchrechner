/*****************************************************************************
Berufschule:    HHEK Bonn
Authorin:		Apostolka Christov
Klasse:			IA219
Datum:			24.08.2020
Datei:          parser.cs
Beschreibung:   Hier werden Parser-Funktionen implementiert.
*****************************************************************************/

using System;

namespace Bruchrechner
{
    partial class MainClass
    {
        //Konvertiere den User-Input von string to int
        static int Parse(string bruchteil)
        {
            int pareser = Convert.ToInt32(bruchteil);
            int ergebnis = pareser;
            return ergebnis;
        }
    }
}
