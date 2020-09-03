/*****************************************************************************
Berufschule:    HHEK Bonn
Authorin:		Apostolka Christov
Klasse:			IA219
Datum:			24.08.2020
Datei:          Kuerzen.cs
*****************************************************************************/

using System;

namespace Bruchrechner
{
    partial class MainClass
    {
        //Kuerze ein Bruch
        static void Kuerzen(int zaehler, int nenner)
        {
            //Finde den grösten gemeinsamen Teiler (ggT).
            //TODO: Für Kuerzen implementiere das Euklidischen Algorithmus
            //TODO: Finde heraus, was passiert wenn zaehler größer als nenner ist
            //int divisor = nenner / zaehler;
            //TODO:Fehler bei der Berechnung beheben.
            int rest = zaehler - nenner;

            //subtrahiere den Rest vom Zeahler
            int differenz = zaehler - rest;
            int ggT;
            if (rest > differenz)
            {
                ggT = rest / differenz;
            }
            else
            {
                ggT = differenz / rest;
            }

            // Teile die Bruchteile durch den ggT.
            int kuerzenErgebnisZaehler = zaehler / ggT;
            int kuerzenErgebnisNenner = nenner / ggT;

            string ergebnisZaelerString = Convert.ToString(kuerzenErgebnisZaehler);
            string ergebnisNennerString = Convert.ToString(kuerzenErgebnisNenner);

            PrintErgebnis(ergebnisZaelerString, ergebnisNennerString);
        }
    }
}
