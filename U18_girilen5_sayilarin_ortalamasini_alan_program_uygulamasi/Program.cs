int toplam = 0;

for(int i=1; i <= 5 ;i++)
{
    Console.WriteLine($"{i}.Sayiyi Giriniz:");
    int sayi = Convert.ToInt32(Console.ReadLine());
    toplam += sayi; //sayı değişkenini toplamın üzerine ekler
}
//kullanıcan 5 tane sayı almış olduk ve topladık
double ortalama = toplam / 5;
Console.WriteLine("Girilen Sayilarin Ortalamasi:" + ortalama);