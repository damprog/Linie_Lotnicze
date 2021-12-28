using System;
using System.Collections.Generic;
using System.Text;

namespace Linie_Lotnicze_Przemyslaw_Pawluk.LinieLotnicze
{
    class BudowniczyRyanair : BudowniczyLiniLotniczych
    {
        LiniaLotnicza liniaLotnicza = new LiniaLotnicza();
        public override LiniaLotnicza DajWynik()
        {
            return liniaLotnicza;
        }

        public override void DodajPrzeloty()
        {
            liniaLotnicza.przeloty.Add(new Przelot("12.05.2022", "13:00", 150, true, liniaLotnicza.symbolSamolotu));
            liniaLotnicza.przeloty.Add(new Przelot("12.05.2022", "13:00", 250, true, liniaLotnicza.symbolSamolotu));
            liniaLotnicza.przeloty.Add(new Przelot("19.06.2022", "13:00", 120, true, liniaLotnicza.symbolSamolotu));
            liniaLotnicza.przeloty.Add(new Przelot("19.07.2022", "13:00", 600, true, liniaLotnicza.symbolSamolotu));
        }

        public override void ZalozLinieLotnicza()
        {
            liniaLotnicza.id = 4;
            liniaLotnicza.nazwa = "Ryanair";
            liniaLotnicza.bagazPodreczny = "48 x 35 x 25 cm, 11kg";
            liniaLotnicza.symbolSamolotu = "B787D";
            liniaLotnicza.bagazRejestrowany = 22;
            liniaLotnicza.rezerwacjaMiejsc = true;
            liniaLotnicza.posilekNaPokladzie = true;
            liniaLotnicza.pierwszaKlasa = true;
            liniaLotnicza.przeloty = new List<IPrzelot>();
        }
    }
}
