/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */



Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, cols];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        array[i, j] = new Random().Next(0, 50);
    }
}

for (int i = 0; i < rows; i++)
{
    for (int m = 0; m < cols; m++)
    {
        Console.Write(array[i, m] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("Среднее арифметическое элементов в каждом столбце:");
for (int j = 0; j < cols; j++)
{
    int sum = 0;
    for (int i = 0; i < rows; i++)
    {
        sum += array[i, j];
    }
    double avg = (double)sum / rows;
    Console.WriteLine($"Столбец {j+1}: {avg}");
}

/* Введите количество строк: 4
Введите количество столбцов: 6
7       46      15      36      14      13
27      33      8       18      30      19
36      38      33      37      14      24
43      31      1       3       12      37
Среднее арифметическое элементов в каждом столбце:
Столбец 1: 28,25
Столбец 2: 37
Столбец 3: 14,25
Столбец 4: 23,5
Столбец 5: 17,5
Столбец 6: 23,25 */
