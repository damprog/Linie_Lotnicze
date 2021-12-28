using System;
using System.Collections.Generic;
using System.Text;

namespace Linie_Lotnicze_Przemyslaw_Pawluk
{
    interface IBilet
    {
        string imie { get; set; }
        string nazwisko { get; set; }
        IPrzelot przelot { get; set; }
        Rodzaj rodzaj { get; set; }
        bool pierwszaKlasa { get; set; }
        decimal cena { get; set; }
        IBilet KupBilet();
        decimal ObliczCene { get; set; }
        ILiniaLotnicza liniaLotnicza { get; set; }
        void WyswietlInfo();
        
    }

    enum Rodzaj
    {
        W_jedną_stronę,
        W_obie_strony
    }
}
