using System;
using System.Collections.Generic;
using System.Text;

namespace Linie_Lotnicze_Przemyslaw_Pawluk
{
    interface ILiniaLotnicza
    {
        int id { get; set; }
        string nazwa { get; set; }
        string bagazPodreczny { get; set; }
        double bagazRejestrowany { get; set; }
        string symbolSamolotu { get; set; }
        bool rezerwacjaMiejsc { get; set; }
        bool posilekNaPokladzie { get; set; }
        bool pierwszaKlasa { get; set; }
        List<IPrzelot> przeloty { get; set; }

        void WyswitlInfo();
        void WyswietlPrzeloty();
    }
}
