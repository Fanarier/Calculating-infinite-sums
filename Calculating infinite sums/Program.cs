//3.3.Вычисление бесконечных сумм. Плотников Кирилл Андреевич 22-ИСП-2/2
//№варианта:16
try
{
    Console.ForegroundColor = ConsoleColor.Blue;
    
    Console.Write("Введите n =");
    int n = int.Parse(Console.ReadLine());
    Console.Write("Введите x =");
    int x = int.Parse(Console.ReadLine());
    
    double m = 0;
    int i = 1;
    for (int j = 0; j < n; j++)
    {
        m += (Math.Sin(x * i)) / i;
        i += 2;
    }
    Console.ForegroundColor = ConsoleColor.DarkGray;

    Console.WriteLine($"Ответ = {m:F2}");

    Console.ForegroundColor = ConsoleColor.White;
}
catch (Exception ex)
{ Console.WriteLine(ex.ToString()); }