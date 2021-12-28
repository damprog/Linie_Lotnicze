using System;
using System.Collections.Generic;
using System.Text;

namespace Linie_Lotnicze_Przemyslaw_Pawluk.LinieLotnicze
{
    class BudowniczyPolskieLinieLotniczeLOT : BudowniczyLiniLotniczych
    {
        LiniaLotnicza liniaLotnicza = new LiniaLotnicza();
        public override LiniaLotnicza DajWynik()
        {
            return liniaLotnicza;
        }

        public override void DodajPrzeloty()
        {
            liniaLotnicza.przeloty.Add(new Przelot("06.05.2022", "11:00", 150, true, liniaLotnicza.symbolSamolotu));
            liniaLotnicza.przeloty.Add(new Przelot("08.05.2022", "11:00", 250, true, liniaLotnicza.symbolSamolotu));
            liniaLotnicza.przeloty.Add(new Przelot("08.06.2022", "11:00", 120, true, liniaLotnicza.symbolSamolotu));
            liniaLotnicza.przeloty.Add(new Przelot("08.07.2022", "11:00", 600, true, liniaLotnicza.symbolSamolotu));
        }

        public override void ZalozLinieLotnicza()
        {
            liniaLotnicza.id = 3;
            liniaLotnicza.nazwa = "Polskie Linie Lotnicze LOT";
            liniaLotnicza.bagazPodreczny = "46 x 35 x 25 cm, 11kg";
            liniaLotnicza.symbolSamolotu = "B787D";
            liniaLotnicza.bagazRejestrowany = 20;
            liniaLotnicza.rezerwacjaMiejsc = true;
            liniaLotnicza.posilekNaPokladzie = true;
            liniaLotnicza.pierwszaKlasa = true;
            liniaLotnicza.przeloty = new List<IPrzelot>();
        }
    }
}
