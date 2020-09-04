/*****************************************************************************
Berufschule:    HHEK Bonn
Authorin:		Apostolka Christov
Klasse:			IA219
Datum:			24.08.2020
Datei:          Kuerzen.cs
Beschreibung:   Im Modul befindet sich das Algorithmus zum Kuerzen .
*****************************************************************************/

using System;

namespace Bruchrechner
{
    partial class MainClass
    {
        //Kuerze ein Bruch
        static void Kuerzen(int zaehler, int nenner)
        {
            //Finde den ggT (Euklidischen Algorithmus)
            //TODO: Negativen Zahlen handeln.
            //TODO: Das Algorithmus weiter implementieren.
            int rest;
            if (zaehler < nenner)
            {
                rest = nenner - zaehler;
            }
            else
            {
                rest = zaehler - nenner;
            }

            //Subtrahiere den Rest vom Zeahler
            int differenz = zaehler - rest;
            int ggT = 0;

            //Prüfe, ob eine Rekursion nötig ist.
            //TODO: Implementiere die Rekursion 
            if (differenz - differenz == 0)
            {
                ggT = rest;
            }

            else
            {

            }
            // Teile die Bruchteile durch den ggT.
            //TODO: Wie wird es gehandelt, wenn es keinen grösten gemeinsamen Teiler gibt? 
            int kuerzenErgebnisZaehler = zaehler / ggT;
            int kuerzenErgebnisNenner = nenner / ggT;

            //Konvertiere die Zangzahlen zu strings
            string ergebnisZaelerString = Convert.ToString(kuerzenErgebnisZaehler);
            string ergebnisNennerString = Convert.ToString(kuerzenErgebnisNenner);

            //Gebe das Ergebnis in der Console aus.
            PrintErgebnis(ergebnisZaelerString, ergebnisNennerString);
        }
    }
}
