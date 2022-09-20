/*
Задача 48: Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: 
Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/

int n = 0; 
int m = 0; 

Console.Write("Введите количество строк(N): ");
n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов(M): ");
m = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[n, m];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        array[i, j] = i + j;

        System.Console.Write(array[i, j]);;
    }
    System.Console.WriteLine(" ");
}
