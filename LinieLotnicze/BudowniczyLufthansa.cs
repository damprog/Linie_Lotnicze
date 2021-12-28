using System;
using System.Collections.Generic;
using System.Text;

namespace Linie_Lotnicze_Przemyslaw_Pawluk.LinieLotnicze
{
    class BudowniczyLufthansa : BudowniczyLiniLotniczych
    {
        LiniaLotnicza liniaLotnicza = new LiniaLotnicza();
        public override LiniaLotnicza DajWynik()
        {
            return liniaLotnicza;
        }

        public override void DodajPrzeloty()
        {
            liniaLotnicza.przeloty.Add(new Przelot("16.05.2022", "5:00", 150, true, liniaLotnicza.symbolSamolotu));
            liniaLotnicza.przeloty.Add(new Przelot("18.05.2022", "5:00", 250, true, liniaLotnicza.symbolSamolotu));
            liniaLotnicza.przeloty.Add(new Przelot("18.06.2022", "5:00", 120, true, liniaLotnicza.symbolSamolotu));
            liniaLotnicza.przeloty.Add(new Przelot("18.07.2022", "5:00", 600, true, liniaLotnicza.symbolSamolotu));
        }

        public override void ZalozLinieLotnicza()
        {
            liniaLotnicza.id = 2;
            liniaLotnicza.nazwa = "Lufthansa";
            liniaLotnicza.bagazPodreczny = "56 x 35 x 25 cm, 13kg";
            liniaLotnicza.symbolSamolotu = "A350L";
            liniaLotnicza.bagazRejestrowany = 0;
            liniaLotnicza.rezerwacjaMiejsc = true;
            liniaLotnicza.posilekNaPokladzie = true;
            liniaLotnicza.pierwszaKlasa = true;
            liniaLotnicza.przeloty = new List<IPrzelot>();
        }
    }
}
