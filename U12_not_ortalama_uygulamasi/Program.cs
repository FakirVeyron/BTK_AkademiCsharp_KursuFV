//klavyeden 3 sınav notu girilecek
//ortalama hesaplanacak
//koşul < 50 oldugu takdirde başarısız yazılacak değilse başarılı yazacak
//not ortalama uygulanması istenmiştir
using System.Runtime.InteropServices.Marshalling;

Console.WriteLine("1.Notu giriniz:");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2.Notu giriniz:");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("3.Notu giriniz");
int n3 = Convert.ToInt32(Console.ReadLine());

double ort = (n1 + n2 + n3) / 3.0;// (int + int + int)/double ==> int

Console.WriteLine("Ortalamaniz: " + ort);

if(ort >= 50)
{
    Console.WriteLine("TEBRIKLER SINIFI GEÇMEYE BAŞARDINIZ....");
}
else
{
    Console.WriteLine("BAŞARISIZ!!!");
}