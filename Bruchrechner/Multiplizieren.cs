/*****************************************************************************
Berufschule:    HHEK Bonn
Authorin:		Apostolka Christov
Klasse:			IA219
Datum:			24.08.2020
Datei:          Multiplizieren.cs
Beschreibung:   Die Datei enhält die Funktion zum Multiplizierenm zwie Brüche.
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
            int ergebnisZaehler = zeahler1 * zeahler2;
            int ergebnisNenner = nenner1 * nenner2;

            Kuerzen(ergebnisZaehler, ergebnisNenner);
        }
    }
}
