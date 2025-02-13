int a=5, b=3;

int sonuc = a * b;//15

Console.WriteLine(a + " * " + b + " = " + sonuc);
Console.WriteLine(string.Format("{0} * {1} = {2}", a, b, sonuc));
Console.WriteLine("{0} * {1} = {2}", a, b, sonuc);

Console.WriteLine($"{a} * {b} = {sonuc}");//string interpolation uygulaması