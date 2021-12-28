using Linie_Lotnicze_Przemyslaw_Pawluk.TypyWyliczeniowe;
using System;
using System.Collections.Generic;
using System.Text;

namespace Linie_Lotnicze_Przemyslaw_Pawluk.Bilety
{
    abstract class BiletAbstract : IBilet
    {
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public bool pierwszaKlasa { get; set; }
        public double cena { get; set; }
        public int liczbaDzieci { get; set; }
        public int liczbaDoroslych { get; set; }
        public RodzajBiletu rodzaj { get; set; }
        public IPrzelot przelot { get; set; }
        public ILiniaLotnicza liniaLotnicza { get; set; }
        public abstract void ObliczCene();
        public abstract void WyswietlInfo();
    }
}
