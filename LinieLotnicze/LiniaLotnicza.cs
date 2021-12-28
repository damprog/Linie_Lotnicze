using System;
using System.Collections.Generic;
using System.Text;

namespace Linie_Lotnicze_Przemyslaw_Pawluk.LinieLotnicze
{
    //Klasa jako produkt
    class LiniaLotnicza : ILiniaLotnicza 
    {
        public int id { get; set; }
        public string nazwa { get; set; }
        public string bagazPodreczny { get; set; }
        public double bagazRejestrowany { get; set; }
        public string symbolSamolotu { get; set; }
        public bool rezerwacjaMiejsc { get; set; }
        public bool posilekNaPokladzie { get; set; }
        public bool pierwszaKlasa { get; set; }
        public List<IPrzelot> przeloty { get; set; }

        public void WyswitlInfo()
        {
            Console.WriteLine($"{nazwa}: oferuje przeloty samolotem\n" +
                $"Podstawowe informacje:\n" +
                $"Bagaż podręczny - {bagazPodreczny}\n" +
                $"Bagaż rejestrowany - {bagazRejestrowany}");
            if (rezerwacjaMiejsc) Console.WriteLine("Możliwość rezerwacji miejsc");
            if (posilekNaPokladzie) Console.WriteLine("Poczęstunek w samolocie");
            if (pierwszaKlasa) Console.WriteLine("Oferuj lot pierwszą klasą");
        }
        public void WyswietlPrzeloty()
        {
            foreach(Przelot p in przeloty)
            {
                Console.WriteLine(p.DajInfo());
                Console.WriteLine("-----------------------------------------");
            }
        }
    }
}
