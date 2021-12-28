using Linie_Lotnicze_Przemyslaw_Pawluk.Interfejsy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Linie_Lotnicze_Przemyslaw_Pawluk.Samoloty
{
    class AirbusA350Lufthansy : ISamolot
    {
        public string nazwa { get; set; } = "Airbus A350 Lufthansy";
        public int liczbaMiejsc { get; set; } = 325;
        public string symbolSamolotu { get; set; } = "A350L";
    }
}
