/*

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue +1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int CheckParity(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
        if(arr[i] % 2 == 0) count++;
    return count;
    
}

int [] newArray = CreateRandomArray(5, 100, 999);

ShowArray(newArray);

int result = CheckParity(newArray);
Console.WriteLine("Количество четных чисел в массиве: " + result);

*/

/*

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue +1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int GetSumOddIndex(int[] arr)
{
    int sum = 0;

    for (int i = 1; i < arr.Length; i+= 2)
        sum+= arr[i];
    return sum;
    
}

int [] newArray = CreateRandomArray(6, 10, 99);

ShowArray(newArray);

int result = GetSumOddIndex(newArray);
Console.WriteLine("Сумма чисел на нечетных индексах в массиве: " + result);

*/


double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue) + new Random().NextDouble();
    }
    return array;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}


double Difference(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] >= max) max = array[i];
        else if (array[i] <= min) min = array[i];
    }
    return max - min;
}

double[] newArray = CreateRandomArray(5, 1, 10);

ShowArray(newArray);

double result = Difference(newArray);

Console.WriteLine("Разница между минимальным и максимальным значением в массиве: " + result);

