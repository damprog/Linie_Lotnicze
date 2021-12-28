using System;
using System.Collections.Generic;
using System.Text;

namespace Linie_Lotnicze_Przemyslaw_Pawluk
{
    class Rezerwacja : IRezerwacja
    {
       
        public IBilet zarezerwowanyBilet { get; set; }

        public Rezerwacja(IBilet zarezerwowanyBilet)
        {
            this.zarezerwowanyBilet = zarezerwowanyBilet;
        }

        public void WyswietlInfo()
        {
            Console.WriteLine($"Rezerwacja na {zarezerwowanyBilet.imie} {zarezerwowanyBilet.nazwisko}\n" +
                $"Dorośli - {zarezerwowanyBilet.liczbaDoroslych}, Dzieci - {zarezerwowanyBilet.liczbaDzieci}" +
                $"INFORMACJE O LOCIE" +
                $"{zarezerwowanyBilet.przelot.DajInfo()}");
        }
    }
}
