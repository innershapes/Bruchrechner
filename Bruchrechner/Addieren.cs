/*****************************************************************************
Berufschule:    HHEK Bonn
Authorin:		Apostolka Christov
Klasse:			IA219
Datum:			24.08.2020
Datei:          Addieren.cs
*****************************************************************************/

using System;

namespace Bruchrechner
{
    partial class MainClass
    {
        static void Addiere(int zeahler1, int nenner1, int zeahler2, int nenner2)
        {
            int ergebnisZaeler = (zeahler1 * nenner2) + (zeahler2 * nenner1);
            int ergebnisNenner = nenner1 * nenner2;

            string ergebnisZaelerString = Convert.ToString(ergebnisZaeler);
            string ergebnisNennerString = Convert.ToString(ergebnisNenner);

            WriteText(ergebnisZaelerString);
            WriteText("-----");
            WriteText(ergebnisNennerString);
        }
    }
}
