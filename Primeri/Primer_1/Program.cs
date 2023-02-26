// Задача 1: Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


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
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

int KolChet(int[] array)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)            
        {
            quantity += 1;             
        }
    }
    return quantity;
}

System.Console.WriteLine("Введите размер массива > ");
int size = Convert.ToInt32(Console.ReadLine());
int minValue = 100;
int maxValue = 999;
int[] array = GenerateArray(size, minValue, maxValue);
ShowArray(array);
int chet = KolChet(array);
System.Console.WriteLine($"Количество четных элементов массива равна {chet}");