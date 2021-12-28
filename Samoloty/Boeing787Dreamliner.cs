using Linie_Lotnicze_Przemyslaw_Pawluk.Interfejsy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Linie_Lotnicze_Przemyslaw_Pawluk.Samoloty
{
    class Boeing787Dreamliner : ISamolot
    {
        public string nazwa { get; set; } = "Boeing 787-8 Dreamliner";
        public int liczbaMiejsc { get; set; } = 252;
        public string symbolSamolotu { get; set; } = "B787D";
    }
}
