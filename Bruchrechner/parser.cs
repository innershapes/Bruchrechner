/*****************************************************************************
Berufschule:    HHEK Bonn
Authorin:		Apostolka Christov
Klasse:			IA219
Datum:			24.08.2020
Datei:          parser.cs
*****************************************************************************/

using System;

namespace Bruchrechner
{
    partial class MainClass
    {
        static int Parse(string bruchteil)
        {
            int pareser = Convert.ToInt32(bruchteil);
            int ergebnis = pareser;
            return ergebnis;
        }
    }
}
