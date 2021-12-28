using Linie_Lotnicze_Przemyslaw_Pawluk.Interfejsy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Linie_Lotnicze_Przemyslaw_Pawluk.Samoloty
{
    class AirbusA320 : ISamolot
    {
        public string nazwa { get; set; } = "Airbus A320";
        public int liczbaMiejsc { get; set; } = 180;
        public string symbolSamolotu { get; set; } = "A320";
    }
}
