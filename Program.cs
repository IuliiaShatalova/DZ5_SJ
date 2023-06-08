// Задача 34: Задайте массив заполненный 
// случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



// Console.WriteLine("Введите количество элементов массива");
// int N = Convert.ToInt32(Console.ReadLine());

// int [] array = new int [N];
// int evenNum =0;

// void FillArray()
// {
//     for (int i = 0; i < N; i++)
//     {
//         array[i] = new Random().Next(100,1000);
//         Console.Write(array[i]+" ");
//     }
// }

// int FindAnAmountOfEvenElements(int[] numbers)
// {
//     int j =0;
//     while (j <N)
//     { 
//          if(array[j]%2 == 0)
//          {
//             evenNum = evenNum + 1;
//          }
//          j++;
//     }
//     return evenNum;
// }

// FillArray();
// FindAnAmountOfEvenElements(array);

// Console.WriteLine();
// Console.WriteLine($"Количество четных элементов массива: {evenNum}");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0




// Console.WriteLine("Введите количество элементов массива");
// int N = Convert.ToInt32(Console.ReadLine());

// int [] array = new int [N];
// int sumOnAneven =0;

// void FillArray()
// {
//     for (int i = 0; i < N; i++)
//     {
//         array[i] = new Random().Next(0,10);
//         Console.Write(array[i]+" ");
//     }
// }

// int FindSumOnAnevenPosition(int[]array)
// {
//     int j = 1;
//     while (j<N)
//     {
//         sumOnAneven = sumOnAneven + array[j];
//         j = j+2;
//     }
//     return sumOnAneven;
// }

// FillArray();
// FindSumOnAnevenPosition(array);

// Console.WriteLine();
// Console.WriteLine($"Сумма чисел на нечетных позициях: {sumOnAneven}");



// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76




Console.WriteLine("Введите количество элементов массива");
int N = Convert.ToInt32(Console.ReadLine());

int [] array = new int [N];
int difference =0;

void FillArray()
{
    for (int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(0,10);
        Console.Write(array[i]+" ");
    }
}

void FindMaxAndMinDifference(int[] numbers)
{
    int max = array[0];
    int min = array[0];
    for (int j = 0; j < N; j++)
    {
        if (array[j]>max)
        {
            max = array[j];
        }
        else if(array[j]<min)
        {
            min = array[j];
        }
    }
    difference = max-min;
}

FillArray();
FindMaxAndMinDifference(array);

Console.WriteLine();
Console.WriteLine($"Разница между минимальным и максимальным значениями: {difference}");