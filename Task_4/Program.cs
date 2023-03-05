/* Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12 */


Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[n, n];

Random random = new Random();

Console.WriteLine("Сгенерированный массив:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = random.Next(10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

int sum = 0;
for (int i = 0; i < n; i++)
{
    sum += array[i, i];
}

Console.WriteLine("Сумма элементов на главной диагонали: " + sum);

/* Введите размерность массива: 4
Сгенерированный массив:
9 4 9 7
8 0 7 4
6 6 2 6
8 3 7 9
Сумма элементов на главной диагонали: 20 */