using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // KULLANICIYA kaç adet sayı girmek istediği sorulsun
            // Daha sonra kullanıcıdan sayı girilmesi istensin
            //Kullanıcı fark etse de etmese de başta girdiği adet kaar sayı tanımlandığında bu sayıların toplamı ve ortalaması ekrana yazdırılsın
            // sayfa 81 ödev
            Console.WriteLine("Kaç ADET sayı girmek istersiniz?:");
            int adetstatic = 1; // en az 1 sayı zaten girecek!
            int adet = Convert.ToInt16(Console.ReadLine()); // 3 
            int toplam = 0;
            int girilenSayi = 0;
            do
            {
                Console.WriteLine("SAYI GİR:");
                girilenSayi = Convert.ToInt16(Console.ReadLine()); // 30 
                toplam += girilenSayi; // toplam = 0 + 30 toplam 30 
                adetstatic++;
                
            }
                while(adetstatic<=adet);
            Console.WriteLine("SAYILARIN TOPLAMI:" +toplam);
            Console.WriteLine("SAYILARIN ORTALAMASI:" + (toplam / adet));
            Console.ReadLine();

        }
    }
}
