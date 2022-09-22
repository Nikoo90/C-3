Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= num)
{
    if (i == num) Console.WriteLine($"{Math.Pow(i, 3)}.");

    else Console.Write($"{Math.Pow(i, 3)},");

    i++;
}