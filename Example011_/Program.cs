
//             0  1  2    3   4   5  6   7
int[] arrey = {1, 2, 33, 44, 65, 33, 2, 24 };

int n = arrey.Length;
int find = 33;

int index = 0;

while (index < n )
{
    if (arrey[index] == find)
    {
        Console.WriteLine(index);
        break; // чтобы показывал только первое найденное 
    }
    //index = index + 1; вариант первый 
    index++;

}