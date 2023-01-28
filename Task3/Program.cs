/// Задайте массив вещественных чисел. 
/// Найдите разницу между максимальным и минимальным элементов массива.


void FillMas(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int num = new Random().Next(10,99);
        arr[i] = num;
    }
}

void PrintMas(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }
   
}


Console.Write("Введите размерность массива: ");
int k = int.Parse(Console.ReadLine()?? "");
int[] arr = new int[k];
FillMas(arr);
PrintMas(arr);
Console.WriteLine();
int Max = arr[0];
int Min = arr[0];
int A = 0;

Console.WriteLine();
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i]>Max) Max= arr[i];
    
}
Console.WriteLine(Max);
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i]<Min) Min= arr[i];
    
}
Console.WriteLine(Min);

A = Max - Min;
Console.WriteLine("Разница между "+Max+ " и " +Min+" = "+A);

