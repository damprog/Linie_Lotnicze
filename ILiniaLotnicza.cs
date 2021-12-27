using System;
using System.Collections.Generic;
using System.Text;

namespace Linie_Lotnicze_Przemyslaw_Pawluk
{
    interface ILiniaLotnicza
    {
        string nazwa { get; set; }
        string bagazPodreczny { get; set; }
        double bagazRejestrowany { get; set; }
        bool rezerwacjaMiejsc { get; set; }
        bool posilekNaPokladzie { get; set; }
        bool pierwszaKlasa { get; set; }
    }
}
