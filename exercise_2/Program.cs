// Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого 
// элемента нет.



Console.Write("Введите индекс элемента в столбце ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите индекс элемента в строке ");
int rows = Convert.ToInt32(Console.ReadLine());


int[,] matrix = new int[4, 4];
int el = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 11);
        Console.Write(matrix[i, j] + " ");
        if (i == columns && j == rows)
        {
            el = matrix[i, j];
        }
        
    }
    Console.WriteLine();
}
if (columns > 3 || rows > 3)
        {
            Console.WriteLine("Такого элемента в массиве нет ");
        }
else 
        {
        Console.WriteLine("Элемент с индексом " + columns + ",  " + rows + " равен " + el);
        }