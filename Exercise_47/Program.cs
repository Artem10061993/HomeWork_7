//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("Введите высоту матрицы = ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длинну длинну = ");
int n = int.Parse(Console.ReadLine());
double[ , ] array = new double[m,n];
Random rand = new Random();
void FillArray(double [ , ] matr )
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = Math.Round(rand.Next(-10,10) + rand.NextDouble(),2);
        }
    }
}
void PrintArray(double [,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i,j] + " ");
        }
    Console.WriteLine();
    }
    
}
FillArray(array);
PrintArray(array);
