//sayfa 76 Ödev1 
//Öyle bir program yazın ki kullanıcının klavyeden girdiği sayıları toplasın kullanıcı klavyeden 83 girerse toplama işlemi bitsin ve ekrana yazdırılsın

Console.WriteLine("Kaç kez sayı yazacağınızı giriniz");
int girilenMiktar = Convert.ToInt32(Console.ReadLine());
int toplam = 0;
for (int i = 1; i <= girilenMiktar; i++)
{
    Console.WriteLine("Sayıları giriniz.");
    int girilen = Convert.ToInt32(Console.ReadLine());
    if (girilen != 83)
    {
        toplam += girilen;
    }
    else if (girilen == 83)
    {
        toplam += 83;
        Console.WriteLine("Sayı olarak 83 yazdığınız için işlem sona erdi!");
        break;
    }
}
Console.WriteLine("İşlemin Sonucu=" + toplam);