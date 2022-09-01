// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.WriteLine("Введите высоту матрицы = ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длинну длинну = ");
int n = int.Parse(Console.ReadLine());
int[ , ] array = new int[m,n];
void FillArray(int [ , ] matr )
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}
void PrintArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
                Console.Write(matr[i,j] + "|");
        }
    Console.WriteLine();
    }
    
}
double result = 0;
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write("Среднее арифметическое каждого толбца = ");
   for(int j = 0; j < array.GetLength(0); j++)
    {
        result = 0;
        for(int i = 0; i < array.GetLength(1); i++)
        {
        result = result + array[i,j];
        }
        Console.Write(result/m+"|");
    }