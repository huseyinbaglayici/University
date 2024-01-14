using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   // aldığı burs 500tl altında olanlara %10  ve de +50 tl sabit artış yapan program!
    // burs miktarı a dizisinde saklanıyor!
    // sayfa 82 ödev1 | forreach ile yazınız!
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] a = { 150, 600, 700, 450, 850, 275, 950, 1500, 210, 368 };
            
            foreach (double d in a)
            {
                if (d > 500) // 500 tl üstüne artış yapılmayacak. 
                {
                    Console.WriteLine((d + 50) + " :Koşulsuz 50 tl daha burs kazandınız");
                }
                else if ((d<500) && d>=0)
                    {
                    Console.WriteLine((d * 0.1) + (d +50) + " :Tebrikler bursunuz sabit değer üstüne yüzdeli zamlandı!");
                    }
                Console.WriteLine("Devam etmek için bir tuşa basınız!");
                Console.ReadKey(true);
                
            }


        }
    }
}
