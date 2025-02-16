//kullanıcıdan klavyeden 5 tane sayı istenilecek
//kullanıcı hiç sayı girmediği noktada
//en küçük ve en büyük sayıyı saklayacak değişken tanımlanması istemiyor
//ek = Max Int değeri verilecek, eb = Min Int verilecek
//her döngüde karşılaştır ve yeni girilen ile yer değiştir
int ek = int.MaxValue;
int eb = int.MinValue;

for(int i = 0; i < 5; i++)//5 defa döngüye girecek
{
    Console.WriteLine($"{i + 1}.Sayiyi Giriniz:");
    int sayi = Convert.ToInt32(Console.ReadLine());
    if(sayi > eb)
        eb = sayi;

    if(sayi < ek)
        ek = sayi;    
}

Console.WriteLine($"En büyük sayi: {eb}, En küçük sayi: {ek}");