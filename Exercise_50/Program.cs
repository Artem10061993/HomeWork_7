// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
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
        Console.Write(matr[i,j] + " ");
        }
    Console.WriteLine();
    }
    

}

FillArray(array);
PrintArray(array);
Console.WriteLine();

Console.WriteLine("Введите строку элемента = ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите столбец элемента = ");
int y = int.Parse(Console.ReadLine());

if(x>=m || y>=n)
{Console.WriteLine("Такого элемента не существует");}
else
{Console.WriteLine("Ваш элемент = "+array[x,y]);}
