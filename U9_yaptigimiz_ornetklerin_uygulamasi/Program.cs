//değişken tanımlama ve veri türleri uygulaması
int sayi = 135;
var a = 3.14;
string metin = "35";

//tip dönüşüm işlemi uygulaması
int b = Convert.ToInt32(metin);//convert uygulaması
byte c = (byte)sayi;//casting uygulaması

//ekrana yazdırma uygulaması
Console.WriteLine(sayi);
Console.WriteLine(c);
//klavyeden girdi okuma uygulaması
Console.WriteLine("Merhaba dostum!, Nasilsin?");
string cevap = Console.ReadLine();
Console.WriteLine("Klavyeden bir sayi girer misin?");
int girilenSayi = Convert.ToInt32(Console.ReadLine());
//değerleri birleştirme uygulaması
Console.WriteLine($"Cevabiniz: {cevap} \nGirdiğiniz sayi: {girilenSayi}");
//operatör uygulaması
byte d = 4;//00000100 = 4  ====> 11111011 = 251

Console.WriteLine((byte)~d);