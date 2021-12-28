using System;
using System.Collections.Generic;
using System.Text;

namespace Linie_Lotnicze_Przemyslaw_Pawluk
{
    class Rezerwacja : IRezerwacja
    {
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public int ileDoroslych { get; set; } = 0;
        public int ileDzieci { get; set; } = 0;
        public IPrzelot przelot { get; set; }
        public ILiniaLotnicza liniaLotnicza { get; set; }
        public IBilet zarezerwowanyBilet { get; set; }

        public void WyswietlInfo()
        {
            Console.WriteLine($"Rezerwacja na {imie} {nazwisko}\n" +
                $"Dorośli - {ileDoroslych}, Dzieci - {ileDzieci}" +
                $"INFORMACJE O LOCIE" +
                $"{przelot.DajInfo()}");
        }
    }
}
