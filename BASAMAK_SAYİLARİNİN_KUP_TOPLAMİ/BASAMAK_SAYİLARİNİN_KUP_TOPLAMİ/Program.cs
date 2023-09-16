namespace BASAMAK_SAYİLARİNİN_KUP_TOPLAMİ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 basamaklı bir sayı giriniz:");
            int sayi=Convert.ToInt32(Console.ReadLine());
           
            if(Basamak(sayi))
            {
                int _sayi = sayi;
                double kuptoplami = 0;
                while(true)
                {
                    int basamak= _sayi % 10;
                    _sayi /= 10;

                    kuptoplami+=Math.Pow(basamak, 3);

                    //371 sayısını deneyerek doğru sonucu bulabiliriz mesela
                    if (_sayi < 10)
                    {
                        basamak = _sayi % 10;
                        kuptoplami += Math.Pow(basamak, 3);
                        break;
                    }
                }
                if(kuptoplami==sayi)
                {
                    Console.WriteLine("eşittir");
                }
                else
                    Console.WriteLine( "eşit değildir");
            }
            else
                Console.WriteLine("lütfen sadece 3 basamaklı bir sayı giriniz:");

        }
        static bool Basamak(int sayi)
        {
            int basamaksayisi = 1;
            while (true)
            {
                basamaksayisi++;
                sayi /= 10;
                if (sayi < 10)
                    break;
            }
            if(basamaksayisi == 3)
            {
                return true;
            }
            else
                
            return false;
        }
    }
}