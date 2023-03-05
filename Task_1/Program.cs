/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

Console.Write("Введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[m, n];
Random random = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = Convert.ToDouble(new Random().Next(-99, 99))/10;
    }
}

Console.WriteLine("Двумерный массив со случайными вещественными числами:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

/* Введите количество строк m: 5
Введите количество столбцов n: 6
Двумерный массив со случайными вещественными числами:
0       6,7     9,8     2,1     4,2     6,1
3,6     -7,4    3,5     5,7     -3,4    6,8
-1,8    -6,4    8,3     1,4     -8,9    2,4
8,6     0,2     1,5     -5,1    3,2     3,7
5,7     -1,1    -4,8    6,9     -6,9    1,5 */