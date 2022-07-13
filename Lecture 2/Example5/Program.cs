void FillArray(int [] collection)
{
    int Lenght = collection.Length;
    int index = 0;
    while(index < Lenght)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}
void PrintArray(int[] col)
{
    int Count = col.Length;
    int position = 0;
    while(position< Count){
        Console.WriteLine(col[position]);
        position++;
    }
}
int IndexOf(int [] collection, int find)
{
    int count = collection.Length;
    int index = 0; 
    int position = -1;
    while(index < count){
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
int Pos = IndexOf(array, 4); 
Console.WriteLine(Pos);