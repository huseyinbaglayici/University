Console.Write ("1. sayıyı giriniz!:");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Toplama için   (+)= ");
Console.WriteLine("Çıkarma   için (-)= ");
Console.WriteLine("Çarpma   için  (*)= ");
Console.WriteLine("Bölme   için   (/)= ");
Console.WriteLine("Mod Alma  için (%)= ");
string islem = Console.ReadLine()?? "İşlem boş olamaz";

Console.WriteLine("2. sayıyı giriniz!:");
int sayi2 = Convert.ToInt32(Console.ReadLine());
double sonuc = 0;
if(islem=="+")    {
     sonuc = sayi1+sayi2;
}
else if (islem=="-")  {
     sonuc = sayi1-sayi2;
}
else if (islem =="*") {
     sonuc = sayi1*sayi2;
}
else if (islem =="/" ) {
     sonuc = sayi1/sayi2;
}
else if (islem =="%"){
     sonuc = sayi1%sayi2;
}
else {
    Console.WriteLine("Geçersiz İşlem Değeri girdiniz !");
}
Console.Write("=" + sonuc);