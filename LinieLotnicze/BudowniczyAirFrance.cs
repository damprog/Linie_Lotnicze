using System;
using System.Collections.Generic;
using System.Text;

namespace Linie_Lotnicze_Przemyslaw_Pawluk.LinieLotnicze
{
    class BudowniczyAirFrance : BudowniczyLiniLotniczych
    {
        LiniaLotnicza liniaLotnicza = new LiniaLotnicza();
        public override LiniaLotnicza DajWynik()
        {
            return liniaLotnicza;
        }

        public override void DodajPrzeloty()
        {
            liniaLotnicza.przeloty.Add(new Przelot("26.05.2022","15:00",150, true, liniaLotnicza.symbolSamolotu)); 
            liniaLotnicza.przeloty.Add(new Przelot("28.05.2022","15:00",250, true, liniaLotnicza.symbolSamolotu)); 
            liniaLotnicza.przeloty.Add(new Przelot("28.06.2022","15:00",120, true, liniaLotnicza.symbolSamolotu)); 
            liniaLotnicza.przeloty.Add(new Przelot("28.07.2022","15:00",600, true, liniaLotnicza.symbolSamolotu)); 
        }

        public override void ZalozLinieLotnicza()
        {
            liniaLotnicza.id = 1;
            liniaLotnicza.nazwa = "Air France";
            liniaLotnicza.bagazPodreczny = "55 x 35 x 25 cm, 12kg";
            liniaLotnicza.symbolSamolotu = "A320";
            liniaLotnicza.bagazRejestrowany = 0;
            liniaLotnicza.rezerwacjaMiejsc = false;
            liniaLotnicza.posilekNaPokladzie = true;
            liniaLotnicza.pierwszaKlasa = false;
        }
    }
}
