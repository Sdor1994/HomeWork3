///  Задайте массив заполненный случайными положительными трёхзначными числами. 
///  Напишите программу, которая покажет количество чётных чисел в массиве.


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

int Summ = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i]%2==0) Summ = Summ + 1; 
    
    
}
Console.WriteLine();
Console.WriteLine("Колличество чентых чисел = "+Summ);

