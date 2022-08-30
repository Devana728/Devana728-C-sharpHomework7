// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4

//1 7 -> такого числа в массиве нет
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
void FindElement(int[,] matrix, int k, int l)

{
  
    
    if(k >= 0 && k < matrix.GetLength(0) &&
    l >= 0 && l < matrix.GetLength(1))
        {
            System.Console.WriteLine($" значение элемента на заданной позиции : {matrix[k,l]}");
            return;
        }  
    System.Console.WriteLine("Элемент не обнаружен");       
}

int [,] array = FillArray(Prompt("Введите количество строк массива : " ), Prompt("Введите количество столбцов массива : " ));
PrintArray(array);
System.Console.WriteLine();
int i = Prompt("Введите искомую позицию массива i: ");
int j = Prompt("Введите искомую позицию массива j: ");
FindElement(array, i, j);


