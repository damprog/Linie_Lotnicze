using System;
using System.Collections.Generic;
using System.Text;

namespace Linie_Lotnicze_Przemyslaw_Pawluk
{
    interface IPrzelot
    {
        string czasOdlotu { get; set; }
        double czasLotuMM { get; set; }
        string przesiadka { get; set; }

    }
}
