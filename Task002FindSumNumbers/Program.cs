Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());;
string str = number.ToString();
int[] array = new int[str.Length];

int[] AdditionArray(int[] arr)
{
for( int i=0; i< str.Length; i++)
{
     array[i] = int.Parse(str[i].ToString());
} return array;
}

int FindSumNumbers(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sum += arr[i];
        }
    }
    return sum;
}

int[] addition = AdditionArray(array);
int sum = FindSumNumbers(addition);
System.Console.WriteLine(sum);