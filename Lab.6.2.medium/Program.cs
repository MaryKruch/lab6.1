//1 var
Console.Write("Введите десятичное число:");
int n = int.Parse(Console.ReadLine());
string b = M(n);
Console.WriteLine($"Десятичное число {n} в двоичной системе: {b}");
string M(int d)
{
    return Convert.ToString(d, 2);
}

