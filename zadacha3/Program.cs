/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
double[] a = new double[5];

Random random = new Random();
for (int i = 0; i < 5; i++)
{
    a[i] = random.NextDouble() * 100;
    //Console.Write("{0,6:F2}",a[i]);
    //Console.WriteLine();
}
double searchMinMax(double[] arrayDouble)
{
    double min = arrayDouble[0];
    double max = arrayDouble[0];
    for (int i = 0; i < arrayDouble.Length; i++)
    {
        if (min > arrayDouble[i])
        {
            min = arrayDouble[i];
        }
        if (max < arrayDouble[i])
        {
            max = arrayDouble[i];
        }
    }
    return max - min;
}
Console.WriteLine($"В массиве: [{string.Join(" ", a)}]"); //как сократить каличество знаков после запятой?
Console.WriteLine($"Разница между максимальным и минимальным элементов массива  = {searchMinMax(a)}");