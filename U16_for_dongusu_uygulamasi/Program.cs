Console.WriteLine("For Dongusu\n-------------------------------");

for(int i = 1; i <= 10; i++)
{
    Console.Write($"{i}, "); //10 defa çalıştırır
}
/*
for( ; ;)
{
    Console.WriteLine("Sonsuz");
}
*/
int j = 20;
for( ;j>0; )
{
    Console.Write($"{j}, ");
    j--;//döngü değişkenini içeride artırmış olduk
}