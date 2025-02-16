Console.WriteLine("Yaşinizi girin:");
int yas = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Cinsiyetinizi Giriniz");
char cinsiyet = Convert.ToChar(Console.ReadLine());

if((cinsiyet == 'E' || cinsiyet == 'e') && yas >= 20)
{
    Console.WriteLine("Askere Gidebilirsiniz... Hayirli Tezkereler :)");
}
else
{
    Console.WriteLine("Askere Gidemezsiniz...");

    if(yas<20 && cinsiyet!='E' && cinsiyet!='e')
    {
        Console.WriteLine("Yaşiniz ve Cinsiyetiniz Uygun Degildir...");
    }
    else if(yas<20)
    {
        Console.WriteLine("Yasiniz Uygun Degildir...");
    }
    else
    {
        Console.WriteLine("Cinsiyetiniz Uygun Degildir...");
    }
}