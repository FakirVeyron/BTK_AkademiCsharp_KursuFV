using System.Runtime.InteropServices;

Console.Write("Dikdörtgenin a kenarini giriniz:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Dikdörtgenin b kenarini giriniz:");
int b = Convert.ToInt32(Console.ReadLine());

var alan = a * b;//sağdaki işlemin tipine göre değişken tipi belirler
var cevre = (a + b) * 2;//parantezler işlem önceliği belirleniz

//Örnek olarak;
//Kenarları 5 ve 3 olan bir dikdörtgenin alanı 15'tir.
//Kenarları 5 ve 3 olan bir dikdörtgenin çevresi 16'dır.
//Opsiyonel olarak Console.Clear(); Eklenebilir
// \n cümleyi asağı satırdan devam eder
Console.WriteLine($"Kenarlari \"{a}\" ve \"{b}\" olan bir dikdörtgenin alani {alan} eder.");
Console.WriteLine($"""Kenarlari "{a}" ve "{b}" olan bir dikdörtgenin çevresi {cevre} eder.""");