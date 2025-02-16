Console.WriteLine("Gun Numarasini girin(1-7):");
int gun = Convert.ToInt32(Console.ReadLine());

switch (gun)
{
    case 1:Console.WriteLine("Pazartesi"); break;
    case 2:Console.WriteLine("Sali"); break;
    case 3:Console.WriteLine("Carsamba"); break;
    case 4:Console.WriteLine("Persembe"); break;
    case 5:Console.WriteLine("Cuma"); break;
    case 6:Console.WriteLine("Cumartesi"); break;
    case 7:Console.WriteLine("Pazar"); break;
    default:Console.WriteLine("Hatali Gun!"); break;
}

switch (gun)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:Console.WriteLine("Hafta ici"); break;
    case 6:
    case 7:Console.WriteLine("Hafta sonu"); break;
}