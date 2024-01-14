using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{//B değerinin asal olup olmadığını bulan program!
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bu program girdiğiniz sayının asal olup olmadığını kontrol eder!\n Bir sayı giriniz: ");
            int b  = Convert.ToInt32(Console.ReadLine());
            int a; // B=11
            string s = "girdiğiniz sayı asal sayı";
            if (b==1) { Console.Write("'1' Asal Değildir!"); goto bitir; }
            for (a = 2;  a<=b /2; a++)
            {
                if (b%a==0)
                {
                    s = "girdiğiniz sayı asal sayı değildir!";
                    break;
                } 
            }
            Console.WriteLine(s);
        bitir: Console.Write("DEVAM ETMEK İÇİN BİR TUŞA BASINIZ...");
            Console.ReadKey(true);
            
        }
    }
}
