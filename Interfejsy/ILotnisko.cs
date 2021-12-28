using System;
using System.Collections.Generic;
using System.Text;

namespace Linie_Lotnicze_Przemyslaw_Pawluk
{
    interface ILotnisko
    {
        string lokalizacja {
            get { return lokalizacja; }
            set { lokalizacja = value; } 
        }
    }
}
