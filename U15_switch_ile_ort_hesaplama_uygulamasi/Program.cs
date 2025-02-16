Console.WriteLine("Donem Sonu Ortalamanizi Giriniz:");
int ort = Convert.ToInt32(Console.ReadLine());

string durum = ort switch
{
    >=85 => "Takdir Belgesi Aldiniz! Basarilarin Devamini Beklerim :)",
    >=70 => "Tebrikler Teşekkür Belgesi Aldiniz Teşekkürler!",
    >=50 => "Sinifi Gecmiş bulunmaktasiniz",
    _=> "Maalesef Sinifta Kaldiniz Geçniş Olsun :(",
};

Console.WriteLine(durum);