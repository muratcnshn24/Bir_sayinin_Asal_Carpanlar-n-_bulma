using System;

namespace Bir_sayinin_Asal_Carpanlarını_bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] asalCarpanlar = Matematik.AsalCarpanlar(32);
            for (int i = 0; i < asalCarpanlar.Length; i++)
            {
                Console.WriteLine(asalCarpanlar[i]);
            }
        }
    }
}
