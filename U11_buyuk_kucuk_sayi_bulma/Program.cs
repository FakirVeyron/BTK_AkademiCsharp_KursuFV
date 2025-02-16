Console.WriteLine("Birinci Sayiyi Giriniz:");
int s1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("İkinci Sayiyi Giriniz:");
int s2 = Convert.ToInt32(Console.ReadLine());
//bu aşamada kullanıcıdan iki sayı elde edilmiş olur
if(s1 > s2)
{
    Console.WriteLine($"{s1} büyük olan sayidir, {s2} küçük olan sayidir.");
}
else if(s1 < s2)
{
    Console.WriteLine($"{s2} büyük olan sayidir, {s1} küçük olan sayidir.");
}
else
{
    Console.WriteLine("Sayilar eşittir.");
}