﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Linie_Lotnicze_Przemyslaw_Pawluk
{
    interface IRezerwacja
    {
       
        IBilet zarezerwowanyBilet { get; set; }
        void WyswietlInfo();
    }
}
