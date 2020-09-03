/*****************************************************************************
Berufschule:    HHEK Bonn
Authorin:		Apostolka Christov
Klasse:			IA219
Datum:			24.08.2020
Datei:          Addieren.cs
Beschreibung:   Die Datei enhält die Funktion zum Addieren zwie Brüche.
*****************************************************************************/

using System;

namespace Bruchrechner
{
    partial class MainClass
    {
        //Addieren
        static void Addiere(int zeahler1, int nenner1, int zeahler2, int nenner2)
        {
            //Ergebnisvariable von die Kalkulazion der Bruchteilen asugeführt wird.
            int ergebnisZaeler = (zeahler1 * nenner2) + (zeahler2 * nenner1);
            int ergebnisNenner = nenner1 * nenner2;

            //Konvertiere den Ganzzahl zu string.
            string ergebnisZaelerString = Convert.ToString(ergebnisZaeler);
            string ergebnisNennerString = Convert.ToString(ergebnisNenner);

            //Gebe das Ergebnis in der Console aus.
            PrintErgebnis(ergebnisZaelerString, ergebnisNennerString);
        }
    }
}
