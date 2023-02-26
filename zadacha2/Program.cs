/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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
int getSumOddNumbers(int[] arrayNumb)
{
    int sum = 0;
for (int k = 0; k < arrayNumb.Length; k++)
{
    if (k % 2 == 1)
        sum += arrayNumb[k];
}
return sum;
}
Console.WriteLine($"В массиве: [{string.Join(" ", array)}]");
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях массива  = {getSumOddNumbers(array)}");
