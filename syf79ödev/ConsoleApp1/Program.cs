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
            // ikili sayı sistemindeki (kullanıcıdan alınan) bir değeri onlu sayi sistemine dönüştüren program
            int sayi, ikiliDeğer, onluDeger = 0, tabanDeger = 1, basamakDeger;
            Console.WriteLine("Dönüştürmek istediğiniz sayıyı giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());
            ikiliDeğer = sayi;
            
            while (sayi>0)
            {
                basamakDeger = sayi % 10;
                onluDeger = onluDeger + basamakDeger * tabanDeger;
                sayi = sayi / 10;
                tabanDeger = tabanDeger * 2;
            }
            Console.WriteLine("İkili (Binary) Sayı: " + ikiliDeğer);
            Console.WriteLine("\nOnlu (Decimal) Sayı: " + onluDeger);
            Console.ReadLine();




        }
        
    }
}
