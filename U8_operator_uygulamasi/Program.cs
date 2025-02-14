int a = 2, b = 3, c = 6;
Console.WriteLine($"a = {a} , b = {b}, c = {c}");//2, 3, 6

a += 3;//a'nın üzerine 3 ekle 
b--; //b'nin değerini 1 azalt
c = a++ + b; //a'nın değeri ile b'yi topla sonucu c ye aktar, 
            //sonrasında a'nın değerini 1 artır
Console.WriteLine($"a = {a} , b = {b}, c = {c}");//6, 2, 7 

a = a & b;//bitsel and operatörü> 0110 & 0010 == 0010

Console.WriteLine($"a = {a} , b = {b}, c = {c}");//6, 2, 7