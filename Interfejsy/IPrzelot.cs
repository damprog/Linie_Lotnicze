using Linie_Lotnicze_Przemyslaw_Pawluk.Interfejsy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Linie_Lotnicze_Przemyslaw_Pawluk
{
    interface IPrzelot
    {
        string dzienOdlotu { get; set; }
        string godzinaOdlotu { get; set; }
        double czasLotuMM { get; set; }
        bool przesiadka { get; set; }
        public ISamolot samolot { get; set; }
        int aktualnaIlosc { get; set; }

        void WyswietlInfo();
        string DajInfo();
        bool SprawdzDostepnosc(int ileBiletow);
        void DodajPasazerow(int ile);
        void OdejmijPasazerow(int ile);
    }
}
