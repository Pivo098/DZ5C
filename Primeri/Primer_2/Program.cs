// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GenerateArray(int length, int minValue, int maxValue)
{
    int[] result = new int[length];             
    var rnd = new Random();                  

    
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }

    return result;
}
void ShowArray(int[] array)
{
    System.Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}

int SumNechPosition(int[] array)
{
    int sum = 0;  
    for (int i = 0; i < array.Length; i++) 
    {
        if (i % 2 == 0)
        {
            sum += array[i];
        }
    }
    return sum;
}


System.Console.WriteLine("Введите размер массива > ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите минимальный размер массива >");
int minValue = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите максимальный размер массива >");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] array = GenerateArray(size, minValue, maxValue);
ShowArray(array);
int nech = SumNechPosition(array);
System.Console.WriteLine($"Сумма элементов массива на нечетных позициях равна {nech}");