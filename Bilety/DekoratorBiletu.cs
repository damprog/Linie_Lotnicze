using Linie_Lotnicze_Przemyslaw_Pawluk.TypyWyliczeniowe;
using System;
using System.Collections.Generic;
using System.Text;

namespace Linie_Lotnicze_Przemyslaw_Pawluk.Bilety
{
    abstract class DekoratorBiletu : BiletAbstract
    {
        public BiletAbstract bilet;

        public DekoratorBiletu(BiletAbstract bilet)
        {
            this.bilet = bilet;
            /*this.bilet.imie = bilet.imie;
            this.bilet.nazwisko = bilet.nazwisko;
            this.bilet.liczbaDoroslych = bilet.liczbaDoroslych;
            this.bilet.liczbaDzieci = bilet.liczbaDzieci;
            this.bilet.liniaLotnicza = bilet.liniaLotnicza;
            this.bilet.pierwszaKlasa = bilet.pierwszaKlasa;
            this.bilet.przelot = bilet.przelot;
            this.bilet.rodzaj = bilet.rodzaj;*/
        }

        public override void ObliczCene()
        {
            if(bilet != null)
            {
                bilet.ObliczCene();
            }
        }

        public override void WyswietlInfo()
        {
            if (bilet != null)
            {
                bilet.WyswietlInfo();
            }
        }
    }
}
