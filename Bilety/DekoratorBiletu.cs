using Linie_Lotnicze_Przemyslaw_Pawluk.TypyWyliczeniowe;
using System;
using System.Collections.Generic;
using System.Text;

namespace Linie_Lotnicze_Przemyslaw_Pawluk.Bilety
{
    abstract class DekoratorBiletu : BiletAbstract
    {
        protected BiletAbstract bilet;

        public DekoratorBiletu(BiletAbstract bilet)
        {
            this.bilet = bilet;
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
