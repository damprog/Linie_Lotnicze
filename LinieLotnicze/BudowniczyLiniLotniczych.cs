using System;
using System.Collections.Generic;
using System.Text;

namespace Linie_Lotnicze_Przemyslaw_Pawluk.LinieLotnicze
{
    // Udostępnia metody twrzenia lini lotniczych
    abstract class BudowniczyLiniLotniczych
    {
        public abstract void ZalozLinieLotnicza();
        public abstract void DodajPrzeloty();
        public abstract LiniaLotnicza DajWynik();
    }
}
