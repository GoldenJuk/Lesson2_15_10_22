//
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;

    /*
        Далее используем position = -1 для того, чтобы обозначать, что искомого элемента нет в массиве.
        Так как, если будем искать элемент, котороого нет в массиве, то программа выдаст позицию "0", что не верно,
        т.к. там находится первый элемент массива.
    */
    
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array,4);

if(pos == -1)
{
    Console.WriteLine("Искомый элемент не найден");
}
else
{
    Console.WriteLine(pos);
}
