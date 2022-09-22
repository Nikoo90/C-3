int[] arr = new int[6];
for (int i = 0; i < 6; i++)
{
    if (i < 3) Console.WriteLine("Введите кординаты А: ");
    else Console.WriteLine("Введите кординаты B: ");

    int num = Convert.ToInt32(Console.ReadLine());
    arr[i] = num;
}
double result = Math.Sqrt(
                            Math.Pow((arr[3] - arr[0]), 2)
                            + Math.Pow((arr[4] - arr[1]), 2)
                            + Math.Pow((arr[5] - arr[2]), 2)
                        );
Console.WriteLine($"Distance: {Math.Round(result, 2)}");