//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
Console.Write("input size of row matrix: ");
int sizerow = Convert.ToInt32(Console.ReadLine());
Console.Write("input size of column matrix: ");
int sizecol = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[sizerow, sizecol];
void DoubleMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().NextDouble() * 20 - 10;
        }
    }
}
void ShowMatrix(double[,] matrixx)
{
    for (int i = 0; i < matrixx.GetLength(0); i++)
    {
        for (int j = 0; j < matrixx.GetLength(1); j++)
        {
            double Number = Math.Round(matrixx[i, j], 1);
            Console.Write(Number + "  ");
        }
        Console.WriteLine();
    }
}
DoubleMatrix(matrix);
ShowMatrix(matrix);

//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//как сделать вывод в конце не нулевого знвчения а текстом, что вашего числа нет?
//ретерн выводит только инт значения.


Console.Write("input row size: ");
int sizeRow = Convert.ToInt32(Console.ReadLine());
Console.Write("input column size: ");
int sizeСolumn = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[sizeRow, sizeСolumn];
for (int i = 0; i < sizeRow; i++)
{
for (int j = 0; j < sizeСolumn; j++)
{
matrix[i, j] = new Random().Next(0, 10);
Console.Write(matrix[i, j] + " ");
}
Console.WriteLine();
}


string FindNumberInMatrix(int[,] matrixx, int indexrow, int indexcol)
{
    for (int i = 0; i < matrixx.GetLength(0); i++)
    {
        for (int j = 0; j < matrixx.GetLength(1); j++)
        {
            if (indexrow== i && indexcol == j) 
                return "your number is " +matrixx[indexrow,indexcol];
            
        }
    } return "no your number in this matrix";
    
}

Console.Write("input index of row: ");
int inrow = Convert.ToInt32(Console.ReadLine());
Console.Write("input index of column: ");
int incol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindNumberInMatrix(matrix, inrow, incol));

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
*/
Console.Write("input row: ");
int sizeRow = Convert.ToInt32(Console.ReadLine());
Console.Write("input column: ");
int sizeСolumn = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[sizeRow, sizeСolumn];
for (int i = 0; i < sizeRow; i++)
{
    for (int j = 0; j < sizeСolumn; j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
void averageOfNumbersColumn(int[,] matrixx)
{
    double sum = 0;
    double count = 0;
    double average =0;
    for (int j = 0; j < matrixx.GetLength(1); j++)
    {

        for (int i = 0; i < matrixx.GetLength(0); i++)
        {
            sum += matrix[i, j];
            count++;
        }
       Math.Round(average = sum / count);
        
        Console.Write(average + "; ");
        sum = 0;
        count = 0;
    }

}
averageOfNumbersColumn(matrix);
