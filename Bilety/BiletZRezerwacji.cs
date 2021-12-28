using System;
using System.Collections.Generic;
using System.Text;

namespace Linie_Lotnicze_Przemyslaw_Pawluk.Bilety
{
    class BiletZRezerwacji : DekoratorBiletu
    {
        public BiletZRezerwacji(BiletAbstract bilet) : base(bilet)
        {
        }

        public override void WyswietlInfo()
        {
            base.WyswietlInfo();
        }

        public override void ObliczCene()
        {
            base.ObliczCene();
        }
        public double ObliczCenePoZnizce(double cena)
        {
            cena *= 0.8;
            Console.WriteLine("Uwzględniono rabat z rezerwacji");
            return cena;
        }
    }
}
