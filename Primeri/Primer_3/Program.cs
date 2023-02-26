// Задача 3: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
double[] GenerateArray(int length, int minValue, int maxValue)
{
    double[] result = new double[length];             
    var rnd = new Random();                  

    
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }

    return result;
}
void ShowArray(double[] array)
{
    System.Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}

double MaxMinR(double[] array)
{
    double min = Int32.MaxValue;
    double max = Int32.MaxValue;  
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i] > max)
        {
            max = array[i];
        }
         if (array[i] < min)
        {
            min = array[i];
        }
    }
    double raz = max - min;
    return raz;
}


System.Console.WriteLine("Введите размер массива > ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите минимальный размер массива >");
int minValue = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите максимальный размер массива >");
int maxValue = Convert.ToInt32(Console.ReadLine());
double[] myArray = GenerateArray(size, minValue, maxValue);
ShowArray(myArray);
double razn = MaxMinR(myArray);
System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {razn}");