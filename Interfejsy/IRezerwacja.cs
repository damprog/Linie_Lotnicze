using System;
using System.Collections.Generic;
using System.Text;

namespace Linie_Lotnicze_Przemyslaw_Pawluk
{
    interface IRezerwacja
    {
        string imie { get; set; }
        string nazwisko { get; set; }
        int ileDoroslych { get; set; }
        int ileDzieci {get;set;}
        IPrzelot przelot { get; set; }
        ILiniaLotnicza liniaLotnicza { get; set; }
        IBilet zarezerwowanyBilet { get; set; }
        void WyswietlInfo();
    }
}
