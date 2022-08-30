// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5  7    -2   -0,2
//1   -3,3   8   -9,9
//8    7,8  -7,1  9

int Prompt(string message)
{
    System.Console.Write(message); //вывести сообщение
    string readValue = Console.ReadLine(); //считывает с консоли строку
    int result = int.Parse(readValue); // преобразует строку в целое число
    return result; //возвращает результат
}
double [,] FillArray(int numLines, int numColumns)
{
    double[,] matrix = new double [numLines, numColumns];
    for (int i =0; i < matrix.GetLength(0); i ++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = (new Random().NextDouble ()*10) -1;
            
        }
    }
    return matrix;
}
void PrintArray(double[,] matrix) 
{
    for (int i =0; i < matrix.GetLength(0); i ++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            
            System.Console.Write ($"{matrix [i,j]:f1}\t");
        }
        System.Console.WriteLine();
    }



}
int numLines = Prompt("Введите количество строк массива : " );
int numColumns = Prompt("Введите количество столбцов массива : " );

double [,] matrix = FillArray(numLines,numColumns);
PrintArray(matrix);
