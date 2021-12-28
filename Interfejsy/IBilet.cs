using Linie_Lotnicze_Przemyslaw_Pawluk.TypyWyliczeniowe;
using System;
using System.Collections.Generic;
using System.Text;

namespace Linie_Lotnicze_Przemyslaw_Pawluk
{
    interface IBilet
    {
        string imie { get; set; }
        string nazwisko { get; set; }
        bool pierwszaKlasa { get; set; }
        double cena { get; set; }
        int liczbaDzieci { get; set; }
        int liczbaDoroslych { get; set; }
        RodzajBiletu rodzaj { get; set; }
        IPrzelot przelot { get; set; }
        ILiniaLotnicza liniaLotnicza { get; set; }
        void ObliczCene();
        void WyswietlInfo();
        
    }
}
