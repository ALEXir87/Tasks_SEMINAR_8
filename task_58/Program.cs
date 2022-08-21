// Задача №58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

Console.WriteLine("Задача №58");
Console.Write("Введи количество строк первой матрицы: m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи количество столбцов первой матрицы: n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[m, n];
FillArrayRandomNumbers(matrix1);

Console.Write("Введи количество строк второй матрицы: k = ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи количество столбцов первой матрицы: l = ");
int l = Convert.ToInt32(Console.ReadLine());
int[,] matrix2 = new int[k, l];
FillArrayRandomNumbers(matrix2);

void FillArrayRandomNumbers(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            array[i, j] = new Random().Next(0, 10);}}}

void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i, j] + " ");}
        Console.WriteLine("");}}

int[,] matrix = new int[m, l];
for (int i = 0; i < m; i++){
    for (int j = 0; j < n; j++){
        for (int z = 0; z < k; z++){
            matrix[i, j] = matrix[i, j] + (matrix1[i, z] * matrix2[z, j]);}}}
Console.WriteLine("Первая матрица:");
PrintArray(matrix1);
Console.WriteLine("Вторая матрица:");
PrintArray(matrix2);
Console.WriteLine("Произведение двух матриц:");
PrintArray(matrix);
