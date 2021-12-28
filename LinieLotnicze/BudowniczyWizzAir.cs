using System;
using System.Collections.Generic;
using System.Text;

namespace Linie_Lotnicze_Przemyslaw_Pawluk.LinieLotnicze
{
    class BudowniczyWizzAir : BudowniczyLiniLotniczych
    {
        LiniaLotnicza liniaLotnicza = new LiniaLotnicza();
        public override LiniaLotnicza DajWynik()
        {
            return liniaLotnicza;
        }

        public override void DodajPrzeloty()
        {
            liniaLotnicza.przeloty.Add(new Przelot("22.05.2022", "18:00", 150, true, liniaLotnicza.symbolSamolotu));
            liniaLotnicza.przeloty.Add(new Przelot("22.05.2022", "18:00", 250, true, liniaLotnicza.symbolSamolotu));
            liniaLotnicza.przeloty.Add(new Przelot("29.06.2022", "18:00", 120, true, liniaLotnicza.symbolSamolotu));
            liniaLotnicza.przeloty.Add(new Przelot("29.07.2022", "18:00", 600, true, liniaLotnicza.symbolSamolotu));
        }

        public override void ZalozLinieLotnicza()
        {
            liniaLotnicza.id = 5;
            liniaLotnicza.nazwa = "Wizz Air";
            liniaLotnicza.bagazPodreczny = "50 x 34 x 24 cm, 10kg";
            liniaLotnicza.symbolSamolotu = "A320";
            liniaLotnicza.bagazRejestrowany = 18;
            liniaLotnicza.rezerwacjaMiejsc = true;
            liniaLotnicza.posilekNaPokladzie = true;
            liniaLotnicza.pierwszaKlasa = true;
            liniaLotnicza.przeloty = new List<IPrzelot>();
        }
    }
}
