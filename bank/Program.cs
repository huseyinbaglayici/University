using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıya işlem türünü sor
            // 1- bakiye görüntüle
            // 2- para çekme
            // 3- para yatırma
            // q ya basarak çıkış yap

            Console.WriteLine("Bankamıza hoş geldiniz!\n Lütfen İşlem Türünü seçiniz\n  Bakiye Görüntüle(1) | Para Çek  (2) | Para yatır(3)|ÇIKIŞ YAPMAK İÇİN 'Q' Tuşlayınız! ");
            String girilenDeger = Console.ReadLine();
            int bakiye = 526;
            int cekTusla  ;




            if (girilenDeger == "1")
            {
                Console.WriteLine("İşlem Başarılı! Yeni bakiyeniz: " + bakiye + "$" + "\n Çıkmak İçin 'Q' tuşuna basın");
                Console.ReadKey();
            }
            else if (girilenDeger == "2")
            {
                Console.WriteLine("Çekilecek Değeri giriniz!:");
                cekTusla = Convert.ToInt16(Console.ReadLine());
                if (cekTusla > bakiye)
                {
                    Console.WriteLine("Çekmek istediğiniz bakiye geçersiz!" + "\nÇıkmak için 'Q' tuşuna basın!");
                    Console.ReadKey();
                }
                else if (cekTusla < 0)
                {
                    Console.WriteLine("Çekim tutarı 0 dan küçük olamaz!"+"\nÇıkmak için 'Q' tuşuna basın!");
                    Console.ReadKey();
                }
                else
                {

                    bakiye -= cekTusla;
                    Console.WriteLine("İşlem Başarılı! Yeni bakiyeniz: " + bakiye + "$" +"\nÇıkmak için 'Q' tuşuna basın!");
                    Console.ReadKey();

                }
            }
            if (girilenDeger == "3")
            {
                Console.WriteLine("Yatırmak istediğiniz Miktarı Tuşlayınız!");
                int yatirTusla = Convert.ToInt16(Console.ReadLine());
                bakiye += yatirTusla;
                Console.WriteLine("İşlem Başarılı! Yeni bakiyeniz:" + bakiye + "$" + "\nÇıkmak İçin 'Q' tuşuna basın!");
                Console.ReadKey();
            }
            else if (girilenDeger == "Q")
            {
                Console.WriteLine("İşlemi bitirmek istediğinize emin misiniz Eminseniz tekrar 'Q' tuşlayın!");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Yanlış Tuşlama yaptınız!" + "\nÇıkmak için 'Q' tuşuna basın!");
                
            }

            }
                            
            }

        }
    

