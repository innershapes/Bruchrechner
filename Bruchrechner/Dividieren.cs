/*****************************************************************************
Berufschule:    HHEK Bonn
Authorin:		Apostolka Christov
Klasse:			IA219
Datum:			24.08.2020
Datei:          Dividieren.cs
*****************************************************************************/

using System;

namespace Bruchrechner
{
    partial class MainClass
    {
        static void Dividiere(int zeahler1, int nenner1, int zeahler2, int nenner2)
        {


            int ergebnisZaeler;
            int ergebnisNenner;
            if (nenner1 == 0 | nenner2 ==0)
            {
                WriteText("Nullteilung nicht erlaubt!");
                WriteText("Kalkulation wird beendet! Zurück ins Hauptmenue...");

                if (nenner1 == 0)
                {
                    ergebnisZaeler = zeahler1;
                    ergebnisNenner = nenner1;
                }
                else
                {
                    ergebnisZaeler = zeahler2;
                    ergebnisNenner = nenner2;
                }
            }

            else
            {
                ergebnisZaeler = (zeahler1 * nenner2) / (zeahler2 * nenner1);
                ergebnisNenner = nenner1 * nenner2;
            }

            string ergebnisZaelerString = Convert.ToString(ergebnisZaeler);
            string ergebnisNennerString = Convert.ToString(ergebnisNenner);

            PrintOutput(ergebnisZaelerString, ergebnisNennerString);
        }
    }
}
