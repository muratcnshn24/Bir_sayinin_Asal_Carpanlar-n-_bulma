using System;
using System.Collections.Generic;
using System.Text;

namespace Bir_sayinin_Asal_Carpanlarını_bulma
{
    class Matematik
    {
        /// <summary>
        /// Parametre olarak aldığı taban ve kuvvet bağlı olarak ustAlma işemi gerçekleştirir.
        /// </summary>
        /// <param name="taban">Taban</param>
        /// <param name="kuvvet">Kuvvet</param>
        /// <returns>Sonuç</returns>
        public static double UstAlma(double taban, double kuvvet)
        {
            double s = 1;
            for (int i = 1; i <= kuvvet; i++)
                s *= taban;
            return s;
        }

        public static int[] AsalCarpanlar(int n)
        {
            string carpanListesi = "";
            int i = 2;

            //asal çarpanları bulalım.
            while (n > 1)
            {
                if (n % i == 0)
                {
                    n = n / i;
                    carpanListesi += i.ToString() + ",";
                }
                else i++;
            }

            carpanListesi = carpanListesi.Substring(0, carpanListesi.Length - 1);
            string[] carpanlar = carpanListesi.Split(",");

            string s = carpanlar[0];
            string y = s;

            for ( i = 0; i < carpanlar.Length; i++)
            {
                if (!(s==carpanlar[i])) // if kontrol ifadesidir. başına ! koyarsan tersine çevirir !true yazarsa false olur vb.
                {
                    y = y + "," + carpanlar[i];
                    s = carpanlar[i];
                }
            }

            carpanlar = y.Split(',');
            int[] asalCarpanlar = new int[carpanlar.Length];
            for (i = 0; i < asalCarpanlar.Length; i++)
                asalCarpanlar[i] = Convert.ToInt32(carpanlar[i]);

            return asalCarpanlar;
        }
    }
}
