/*
Задача 49: Задайте двумерный массив. Найдите элементы, 
у которых оба индекса чётные, и замените эти элементы 
на их квадраты.
Например, изначально массив  
 выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4

Новый массив будет выглядеть 
вот так:
1 4 7 2
5 81 2 9
8 4 2 4

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
        array[i, j] = new Random().Next(4, 6);
        if ((i % 2 == 0) && (j % 2 == 0))
        {
            array[i, j] = Convert.ToInt32(Math.Pow(array[i, j], 2));
        }

        System.Console.Write(array[i, j]);;
    }
    System.Console.WriteLine(" ");
}
