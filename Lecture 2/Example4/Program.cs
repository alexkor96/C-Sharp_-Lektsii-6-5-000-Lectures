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



int[] array = new int[10];
FillArray(array);
PrintArray(array);