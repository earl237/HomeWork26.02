/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
Console.Clear();
int[] array = FillArray(9, 100, 999);


int[] FillArray(int size, int min, int max)
{
    int[] result = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(min, max + 1);
    }
    return result;
}
int getEvenNumbers(int[] arrayNumb)
{
    int count = 0;
for (int k = 0; k < arrayNumb.Length; k++)
{
    if (arrayNumb[k] % 2 == 0)
        count++;
}
return count;
}
Console.WriteLine($"В массиве: [{string.Join(" ", array)}]");
Console.WriteLine($"Количество четных чисел массива  = {getEvenNumbers(array)}");