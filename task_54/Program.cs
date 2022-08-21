// Задача №54:Задайте двумерный массив.Напишите программу,которая упорядочит по возрастанию элементы 
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

Console.WriteLine("Задача №54");
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
for (int i = 0; i < matrix.GetLength(0); i++){
    for (int j = 0; j < matrix.GetLength(1) - 1; j++){
        for (int k = 0; k < matrix.GetLength(1) - 1; k++){
            if (matrix[i, k] > matrix[i, k + 1]){
                int temp = 0;
                temp = matrix[i, k];
                matrix[i, k] = matrix[i, k + 1];
                matrix[i, k + 1] = temp;}}}}
Console.WriteLine("Полученный массив:");
PrintArray(matrix);