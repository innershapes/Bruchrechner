/*****************************************************************************
Berufschule:    HHEK Bonn
Authorin:		Apostolka Christov
Klasse:			IA219
Datum:			24.08.2020
Datei:          Multiplizieren.cs
*****************************************************************************/

using System;

namespace Bruchrechner
{
    partial class MainClass
    {
        //Multipliziere zwei Brüche
        static void Multipliziere(int zeahler1, int nenner1, int zeahler2, int nenner2)
        {
            //Ergebnisvariablen.
            int ergebnisZaeler = (zeahler1 * nenner2) * (zeahler2 * nenner1);
            int ergebnisNenner = nenner1 * nenner2;

            //Konvertiere den Ganzzahl zu String.
            string ergebnisZaelerString = Convert.ToString(ergebnisZaeler);
            string ergebnisNennerString = Convert.ToString(ergebnisNenner);

            //Gebe den Ergebnis in der Console aus.
            PrintErgebnis(ergebnisZaelerString, ergebnisNennerString);
        }
    }
}
