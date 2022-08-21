// Console.WriteLine("Введите размер массива ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[N];
// for (int i = 0; i < N; i++)  - для любого размера массива

int[] array = new int[8];
for (int i = 0; i < 8; i++)
{
    Console.WriteLine($"Введите {i+1} число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

string PrintArray(int [] array)
{string str = string.Empty;
// for(int i = 0; i < N; i++) - для любого размера массива
    for(int i = 0; i < 8; i++)
        {
            if(i == 0)
            {str += $"{array[i]}, ";}
            else
            {
                // if(i == N-1) - для любого размера массива
                if(i == 8-1)
            {str += $"{array[i]}";}
                else
                {str += $"{array[i]}, ";}
            }
        }
 return str;
}
Console.WriteLine(PrintArray(array));