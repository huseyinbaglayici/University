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
            // kullanıcı iki sayı girsin iki sayı arasından isterse çiftleri isterse teklerin toplamını ekrana yazdırsın
            // kullanıcıya seçenek verilsin!
            // SAYFA 76 ödev3
            Console.WriteLine("Küçük sayıyı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Büyük sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tek sayılar mı bulunsun Çift mi ?:");
            string tercih=(Console.ReadLine());
            int toplam = 0;
            if(tercih == "çift")
            {
                for (int i = sayi; i<= sayi2; i++)
                    if (i % 2 == 0) { 
                        toplam += i;
                    }
            }
            else if (tercih == "tek")
            {
                for (int i = sayi; i<=sayi2; i++)
                {
                    if (i % 2 == 1)
                    {
                        toplam += i;
                    }
                }
            }
            Console.WriteLine(toplam);
            Console.ReadLine();

        }
    }
}
