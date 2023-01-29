void FillArray(int [] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
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
    int position = -1; //если нет в списке элементов
    while (index < count)
    {
        if(collection[index] == find)
        {
          position = index;
          break; //чтобы получалось первое число 
        }
        index++; 
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
array[4] = 4; //принудительно добавили пару четверок 
array[6] = 4;

PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 45);// поиск цифры
Console.WriteLine(pos);