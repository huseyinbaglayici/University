
Console.WriteLine("İdeal Kilo Hesaplayicisina Hos Geldiniz!\n Lutfen Cinsiyetinizi Girin= Erkek [E] , Kadin [K]");
char cinsiyet = Console.ReadLine().ToUpper() [0];

Console.WriteLine("Lutfen Boyunuzu Girin (CM Cinsinden): ");
double boy = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Kilonuzu Girin (KG): ");
double kilo = Convert.ToDouble(Console.ReadLine());
double idealKilo = 0;
//Cinsiyete göre Kilo hesapla
if (cinsiyet=='E')
{
    idealKilo  = 50 + 2.3 * ((boy/2.54)-60);
    Console.WriteLine("İdeal Kilonuz:" + idealKilo.ToString("N2") +"kilodur");
}
else if (cinsiyet=='K')
{
    idealKilo = 45.5 + 2.3 * ((boy/2.54)-60);
    Console.WriteLine("İdeal Kilonuz: "+ idealKilo.ToString("N2")+" kilodur");
}
 else
 {
    Console.WriteLine("Geçersiz Cinsiyet girişi!");
    return;
 }









