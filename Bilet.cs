using System;
using System.Collections.Generic;
using System.Text;

namespace Linie_Lotnicze_Przemyslaw_Pawluk
{
    class Bilet : IBilet
    {
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public IPrzelot przelot { get; set; }
        public Rodzaj rodzaj { get; set; }
        public bool pierwszaKlasa { get; set; }
        public decimal cena { get; set; }
        public decimal ObliczCene { get; set; }
        public ILiniaLotnicza liniaLotnicza { get; set; }

        public IBilet KupBilet()
        {
            //TODO odejmuje miejsca z określonego przelotu
            throw new NotImplementedException();
        }

        public void WyswietlInfo()
        {
            //TODO zrobic wyswietalnie info o bilecie
            throw new NotImplementedException();
        }
    }
}
