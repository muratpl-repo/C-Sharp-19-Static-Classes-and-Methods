using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60DersStaticKavrami
{
    class Program
    {
        class Insan{
            private static int insanSayisi = 0; //Bu deger static kullanildigi icin Insan CLASS'ina aittir. Objelerin uzerinde bi degerdedir.
            public const double PI = 3.14; // Bu sabit deger static kulanıldigi icin Insan CLASS'ina aittir.
            public int yas;

            public Insan()
                {
                    insanSayisi++;
                }
            public static int insanSayisiniSoyle() //Bu metot static kullanildigi icin Insan CLASS'ina aittir.
                {
                    return insanSayisi;
                }
        }

        static void Main(string[] args)
        {
            Insan i1 = new Insan();
            Insan i2 = new Insan();
            i1.yas = 25;
            i2.yas = 30;

            Console.WriteLine(i1.yas + " " + i2.yas);
            Console.WriteLine("Class'ın insan sayisi: "+ Insan.insanSayisiniSoyle());
            Console.WriteLine(Insan.PI);

        }
    }
}
