/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4 */

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, cols];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        array[i, j] = new Random().Next(-50, 50);
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

Console.Write("Введите номер строки элемента: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца элемента: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a < rows && b < cols)
{
    Console.WriteLine($"Элемент array[{a}, {b}] == {array[a-1, b-1]}");
}
else
{
    Console.WriteLine("Такого элемента не существует");
}

/* Введите количество строк: 5
Введите количество столбцов: 5
-7      -14     6       42      24
-37     -15     -14     11      47
-38     22      33      -14     39
0       13      24      -27     12
44      -9      -31     -22     -44
Введите номер строки элемента: 4
Введите номер столбца элемента: 4
Элемент array[4, 4] == -27
PS C:\Users\poval\Desktop\Homework_6\Task_2>
PS C:\Users\poval\Desktop\Homework_6\Task_2> dotnet run
Введите количество строк: 5
Введите количество столбцов: 5
31      -49     43      48      -20
43      -3      49      -43     44
8       -13     32      5       -37
1       -45     -44     33      -13
34      41      2       -24     -6
Введите номер строки элемента: 6
Введите номер столбца элемента: 5
Такого элемента не существует */







