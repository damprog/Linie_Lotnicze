using System;
using System.Collections.Generic;
using System.Text;

namespace Linie_Lotnicze_Przemyslaw_Pawluk
{
    interface IKlient
    {
        string imie { get; }
        string nazwisko { get; }
        List<IBilet> bilety { get; set; }
        List<IRezerwacja> rezerwacje { get; set; }
        void PokazRezerwacje();
        void PokazBilety();
        void Rezerwuj(Rezerwacja rezerwacja);
        void Kup(IBilet bilet);
        void Kup(IBilet bilet, Rezerwacja rezerwacja);
        void ZdejmijRezerwacje(Rezerwacja rezerwacja);

    }
}
