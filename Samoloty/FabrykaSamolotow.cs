using Linie_Lotnicze_Przemyslaw_Pawluk.Interfejsy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Linie_Lotnicze_Przemyslaw_Pawluk.Samoloty
{
    class FabrykaSamolotow
    {
        public ISamolot StworzSamolot(string symbolSamolotu)
        {
            ISamolot samolot = null;
            if (symbolSamolotu.Equals("A320")) samolot = new AirbusA320(); 
            if (symbolSamolotu.Equals("A350L")) samolot = new AirbusA350Lufthansy(); 
            if (symbolSamolotu.Equals("B787D")) samolot = new Boeing787Dreamliner(); 
            return samolot;
        }
    }
}
