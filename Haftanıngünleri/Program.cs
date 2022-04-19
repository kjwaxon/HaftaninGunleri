using System;

namespace Haftanıngünleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pazartesi haftanın {0}. günüdür.",(int)Günler.Pazartesi);
            Console.WriteLine("Salı haftanın {0}. günüdür.", (int)Günler.Salı);
            Console.WriteLine("Çarşamba haftanın {0}. günüdür.", (int)Günler.Çarşamba);
            Console.WriteLine("Perşembe haftanın {0}. günüdür.", (int)Günler.Perşembe);
            Console.WriteLine("Cuma haftanın {0}. günüdür.", (int)Günler.Cuma);
            Console.WriteLine("Cumartesi haftanın {0}. günüdür.", (int)Günler.Cumartesi);
            Console.WriteLine("Pazar haftanın {0}. günüdür.", (int)Günler.Pazar);
            Console.ReadKey();
      }
        enum Günler
        {
            Pazartesi = 1,
            Salı =2,
            Çarşamba=3,
            Perşembe=4,
            Cuma=5,
            Cumartesi=6,
            Pazar=7
        }
    }
}
