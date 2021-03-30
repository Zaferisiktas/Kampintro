using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string KategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
                {
                    Console.WriteLine("Giriş Yap butonu");
                }
            Console.WriteLine(KategoriEtiketi);
        }
    }
}
