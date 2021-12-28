using System;
using System.Collections.Generic;
using System.Text;

namespace Linie_Lotnicze_Przemyslaw_Pawluk.Interfejsy
{
    interface ISamolot
    {
        string nazwa { get; set; }
        int liczbaMiejsc { get; set; }
        string symbolSamolotu { get; set; }
    }
}
