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
            // sayfa 76 ÖDEV2
            // Kullanıcıdan sayı al alınan sayı ile 1 arasındaki tek veya çift tamsayıların toplamını hesaplayarak ekrana yazdır kullanıcıya tek mi çift mi diye sor
            Console.WriteLine("Bir sayı girin");
            int girilen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tek sayılar mı toplansın Çift mi");
            string secim = Console.ReadLine();
            int toplam = 0;
            if (secim == "tek")
            {
                for (int i = 1; i <= girilen; i++)
                {
                    if (i % 2 == 1)
                    {
                        toplam += i;
                    }
                }
            }
            else if (secim == "çift")
            {
                for (int i = 1; i <= girilen; i++)
                {
                    if (i % 2 == 0)
                    {
                        toplam += i;
                    }
                }
            }
            Console.WriteLine(toplam);
        }
    }
}
