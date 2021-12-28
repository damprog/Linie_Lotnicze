using Linie_Lotnicze_Przemyslaw_Pawluk.LinieLotnicze;

using System;

namespace Linie_Lotnicze_Przemyslaw_Pawluk
{
    class Program
    {
        static void Main(string[] args)
        {
            StworzLinieLotnicze();

            Klient klient = new Klient("Jan", "Kowalski");
            klient.Rezerwuj();
            klient.Kup();

            //TODO: STWORZ lotniska
            //TODO: STWORZ przeloty
            //TODO: Klient wybiera linie
            //TODO: Klient wybiera przelot
            //TODO: sprawdzenie czy klient ma możliwość rezerwacji biletu w wybranej lini lotniczej
            //TODO: Po wyborze następuje utworzenie biletu i dodanie go do listy rezerwacji lub zakup biletu



        }

        public static void StworzLinieLotnicze()
        {
            //Kierownik do nadzoru tworzenia lini
            KierownikBudowyLiniLotniczych kierownikLini = new KierownikBudowyLiniLotniczych();

            //tworzenie Air France
            BudowniczyLiniLotniczych BLL1 = new BudowniczyAirFrance();
            kierownikLini.Konstruuj(BLL1);
            LiniaLotnicza airFrance = BLL1.DajWynik();
            airFrance.WyswitlInfo();


        }
    }
}
