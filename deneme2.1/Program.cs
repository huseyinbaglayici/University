Console.WriteLine("Kalma Süresini Giriniz : ");
int girilenSaat = Convert.ToInt32(Console.ReadLine());
int gunKaldi = girilenSaat / 24 + 1;
int ucret = 0 ;

for (int i = 0 ; i < gunKaldi ; i++ )
{
   int gunlukSaat = girilenSaat - i * 24 ;
   gunlukSaat = gunlukSaat < 24 ? gunlukSaat : 24;
   if (gunlukSaat>2)
   {
      ucret+= 5;
      gunlukSaat -= 2;
   }
   if (gunlukSaat<=8)
   ucret += gunlukSaat * 1 ;
   else
    ucret += 8;
}
Console.WriteLine("Toplam = " + ucret + "TL");

