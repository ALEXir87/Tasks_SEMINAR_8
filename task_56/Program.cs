// Задача №56:Задайте прямоугольный двумерный массив.Напишите программу,которая будет находить строку
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой 
// элементов: 1 строка

Console.WriteLine("Задача №56");
Console.Write("Введи количество строк: m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи количество столбцов: n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
FillArrayRandomNumbers(matrix);

void FillArrayRandomNumbers(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            array[i, j] = new Random().Next(0, 10);}}}

void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i, j] + " ");}
        Console.WriteLine("");}}

Console.WriteLine("Исходный массив:");
PrintArray(matrix);
int minSumString = Int32.MaxValue;
int indexString = 0;
for (int i = 0; i < matrix.GetLength(0); i++){
    int SumString = 0;
    for (int j = 0; j < matrix.GetLength(1); j++){
        SumString = SumString + matrix[i, j];}
if (SumString < minSumString){
    minSumString = SumString;
    indexString ++;;}}
Console.WriteLine($"Cтрока с наименьшей суммой элементов под №:{indexString}");