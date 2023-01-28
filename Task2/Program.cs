/// Задайте одномерный массив, заполненный случайными числами. 
/// Найдите сумму элементов, стоящих на нечётных позициях.

void FillMas(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int num = new Random().Next(100,999);
        arr[i] = num;
    }
}

void PrintMas(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }
   /// Console.WriteLine(arr);
}


Console.Write("Введите размерность массива: ");
int k = int.Parse(Console.ReadLine()?? "");
int[] arr = new int[k];
FillMas(arr);
PrintMas(arr);
Console.WriteLine();
int Summ = 0;
Console.WriteLine();
for (int i = 0; i < arr.Length; i=i+2)
{
    if (i%2==0) Console.WriteLine(arr[i]);
    
    
}


