// 1

string[,] table = new string[2, 5];

// String.Empty
// table[0,0] table[0,1] table[0,2]
// table[1,0] table[1,1] table[1,2]
// table[2,0] table[2,1] table[2,2]
// table[1, 2] = "word";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//        Console.WriteLine($" - {table[rows, columns]}");
//     }
// }



void PrintArray(int[,] array) // выводит матрицу
{
    // for (int i = 0; i < 3; i++)
    for (int i = 0; i < array.GetLength(0); i++)
    {
        // for (int j = 0; j < 4; j++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// добавим метод который будет заполнять матрицу случайными числами
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10); // генератор псевдослучайдых чисел от [1 до 10)
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);