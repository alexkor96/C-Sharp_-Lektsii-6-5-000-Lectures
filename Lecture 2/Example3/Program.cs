int [] array = {13,22,33,33,41,54,63,41,72,18};
int n = array.Length;
int index = 0; 
int Find = 33;
while(index < n)
{
    if (array[index] == Find){
        Console.WriteLine(index);
        break;
    }
    index++;



}