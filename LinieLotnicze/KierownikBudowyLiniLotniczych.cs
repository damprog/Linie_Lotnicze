using System;
using System.Collections.Generic;
using System.Text;

namespace Linie_Lotnicze_Przemyslaw_Pawluk.LinieLotnicze
{
    //Nadzoruje pracę budowniczego lini lotniczych
    class KierownikBudowyLiniLotniczych
    {
        public void Konstruuj(BudowniczyLiniLotniczych BLL)
        {
            BLL.ZalozLinieLotnicza();
            BLL.DodajPrzeloty();
        }
    }
}
