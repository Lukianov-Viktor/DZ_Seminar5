//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.


// Ввод данных о элементе
Console.Write("Введите строку: ");
int element1 = Convert.ToInt32(Console.ReadLine()) -1;
Console.Write("Введите столбец: ");
int element2 = Convert.ToInt32(Console.ReadLine()) -1;

// Задаю кол-во строк и столбцов
int rows = 8; 
int collums = 9; 
Random random = new Random();
int[,] array = new int[rows, collums];
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
{
    array[i, j] = random.Next(1, 101);
Console.Write("{0} ", array[i, j]);
}
Console.WriteLine();
}
    if (element1 < 0 | element1 > array.GetLength(0) - 1 | element2 < 0 | element2 > array.GetLength(1) - 1)
{
Console.WriteLine("Элемент не существует  ");
}
    else
{
    Console.WriteLine("Значение элемента массива = {0}", array[element1, element2]);
}
