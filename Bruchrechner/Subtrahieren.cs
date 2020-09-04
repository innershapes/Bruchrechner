/*****************************************************************************
Berufschule:    HHEK Bonn
Authorin:		Apostolka Christov
Klasse:			IA219
Datum:			24.08.2020
Datei:          Substahieren.cs
Beschreibung:   Die Datei enhält die Funktion zum Subtrahieren zwie Brüche.
*****************************************************************************/

using System;

namespace Bruchrechner
{
    partial class MainClass
    {
        static void Subtrahiere(int zeahler1, int nenner1, int zeahler2, int nenner2)
        {
            //Ergebnisvariablen
            int ergebnisZaehler;
            int ergebnisNenner;
            //Prüfe, ob Zaehler und Nenner glecih sind. Wenn nicht, multipliziere sie.
            if (nenner1 == nenner2)
            {
                ergebnisZaehler = zeahler1 - zeahler2;
                ergebnisNenner = nenner1;
            }

            else
            {
                ergebnisZaehler = (zeahler1 * nenner2) - (zeahler2 * nenner1);
                ergebnisNenner = nenner1 * nenner2;
            }
            Kuerzen(ergebnisZaehler, ergebnisNenner);
        }
    }
}
