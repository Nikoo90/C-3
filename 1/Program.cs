Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] numsArr = new int[5];
int x = 10000;
for (int i = 0; i < numsArr.Length; i++)
{
    if (i == 0)
    {
        numsArr[i] = (num - num % x) / x;
    }
    else
    {
        int result = num % x;
        x /= 10;
        result /= x;
        numsArr[i] = result;
    }
}
int j = 0;
string answer = "Yes";

while (j < numsArr.Length)
{
    if (numsArr[j] != numsArr[numsArr.Length - (j + 1)])
    {
        answer = "No";
        break;
    }
    j++;
}
Console.WriteLine(answer);