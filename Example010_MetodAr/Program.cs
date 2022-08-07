// Имеется одномерный массив array из n элементов, требуется найти элемент массива равный find

//int[] array = {1, 12, 31, 4, 15, 16, 4, 18}; - Если массив задан
//int n = array.Length;
//int find = 4;
//int index = 0;
//while (index < n)
//{
//    if (array[index] == find)
//    {
//        Console.WriteLine(index);
//        break;
//    }
//    index ++;
//}

// Если массив не задан и нужно его сгенерировать

void FillArray(int[] collection)// Создать, сгенерировать массив
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index ++;
    }
}

void PrintArray(int[] col)// Печать массива
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position ++;
    }
}

int IndexOf (int[] collection, int find)
{
    int count = collection.Length;
    int index =0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break; // чтобы остановить цикл, чтобы программа выдала первый найденный результат
        }
        index ++;
    }
    return position;
}

int[] array = new int[10]; // создать новый массив из 10 лементов

FillArray(array); // Заполнить массив
// array[4] = 4; - принудительно добавить значения элементам массива
// array[6] = 4;
PrintArray(array); // Печатать на экран
Console.WriteLine(); // чтобы выветси пустую строку
int pos = IndexOf(array, 4); // здесь find указано 4, но можно указать любое
Console.WriteLine(pos);

