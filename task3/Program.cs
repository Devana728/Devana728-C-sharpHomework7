// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4

//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int Prompt(string message)
{
    System.Console.Write(message); //вывести сообщение
    string readValue = Console.ReadLine(); //считывает с консоли строку
    int result = int.Parse(readValue); // преобразует строку в целое число
    return result; //возвращает результат
}
int [,] FillArray(int numLines, int numColumns )
{

int[,] matrix = new int [numLines, numColumns];
    for (int i =0; i < matrix.GetLength(0); i ++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           
             matrix[i,j] = new Random().Next(0, 20);

        }
    }
    return matrix;
}

void PrintArray(int[,] matrix) 
{
    for (int i =0; i < matrix.GetLength(0); i ++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write ($"{matrix [i,j]}\t");
        }
        System.Console.WriteLine();
    }
}
void Average(int[,] matrix)
{
Console.WriteLine("Среднее арифметическое элементов :");    

    for (int i =0; i < matrix.GetLength(1); i ++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum = sum + matrix[j,i];
                
        }
        double average = (double) sum / matrix.GetLength(0);
        
        
        Console.Write($"{average:f2}\t ");

        
    }
Console.WriteLine();    
}
int [,] array = FillArray(Prompt("Введите количество строк массива : " ), Prompt("Введите количество столбцов массива : " ));
PrintArray(array);
System.Console.WriteLine();
Average(array);
