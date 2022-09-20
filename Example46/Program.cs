/*
Задача 46: Задайте двумерный массив размером m×n, 
заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1
*/

// Размерность массива
int n = 0; // кол-во строк
int m = 0; // кол-во столбцов

Console.Write("Введите количество строк(N): ");
n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов(M): ");
m = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[n, m];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        array[i, j] = new Random().Next(1, 10);
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        System.Console.Write(array[i, j]);;
    }
    System.Console.WriteLine(" ");
}