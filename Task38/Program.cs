// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
// [3.5, 7.1, 22.9, 2.3, 78,5]-> 76.2

Console.Write("Введите число элементов массива: ");
int j = Convert.ToInt32 (Console.ReadLine());
double [] numbers = new double [j];
FillArray (numbers);
PrintArray(numbers);

double max = numbers [0];
for (int i = 0; i < j; i++)
{
    if (numbers[i] >max)
    {
        max = numbers[i];
    }
}
double min = numbers [0];
for (int i = 0; i < j; i++)
{
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
}
double difference = max - min;
Console.WriteLine ("Разница между максимальными и минимальными массивами: "+difference);
void FillArray (double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        numbers [i] = new Random().Next(0, 99);
    }
}
void PrintArray (double [] array)
{
    for (int i =0; i < array.Length; i++)
    {
        Console.Write (numbers [i] + " ");
    }
    Console.WriteLine();
}
    