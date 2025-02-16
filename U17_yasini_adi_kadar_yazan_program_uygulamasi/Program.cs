//klavyeden kişinin adı ve soyadı girilecek
//kişinin adını yaşı defa ekrana yazacak
//ve bu uygulama for dongüsü ile gerçekleştirilmeli
Console.WriteLine("Adinizi ve soyadinizi giriniz:");
string ad = Console.ReadLine();
Console.WriteLine("Yasinizi giriniz:");
int yas = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= yas; i++)
{
    Console.WriteLine($"{i} - {ad}");
}