/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

bool FindNumberIn3DArray(int[,,]array, int temp)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i,j,k] == temp) return true;
            }
        }
    }
    return false;
}

void Print3DArray(int[,,] array)
{
    Console.WriteLine("Задан массив:");
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($" {array[i,j,k]}({i},{j},{k})");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}


int[,,] Create3DArray(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            for (int k = 0; k < size3; k++)
            {
                int temp = new Random().Next(0,100);
                if (FindNumberIn3DArray(array, temp)) k--;
                else array[i,j,k] = temp; 
            }
        }
    }
    Console.WriteLine();
    return array;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int size1 = GetInput("Введите первый размер: ");
int size2 = GetInput("Введите второй размер: ");
int size3 = GetInput("Введите третий размер: ");
int[,,] array = Create3DArray(size1, size2, size3);
Print3DArray(array);