Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindStepenNumber(A));

double FindStepenNumber(int A)
{
    double result = Math.Pow(A, B);
    return result;
}