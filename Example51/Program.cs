/*
Задача 51: Задайте двумерный массив. Найдите сумму 
элементов, находящихся на главной диагонали 
(с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/

int n = 0; 
int m = 0; 

Console.Write("Введите количество строк(N): ");
n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов(M): ");
m = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[n, m];
int sum = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        array[i, j] = new Random().Next(1, 10);
        if (i == j)
        {
            sum = sum = array[i, j];
        }

    }
    
}

Console.WriteLine($"Сумма элементов диагонали: {sum}");
