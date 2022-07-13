int Max(int Arg1, int Arg2, int Arg3) {
    int resuslt = Arg1;
    if(Arg2>resuslt) resuslt = Arg2;
    if(Arg3>resuslt) resuslt = Arg3;
    return resuslt;
}
int [] array = {112 , 212 , 31 , 425 , 581 , 69, 726 , 118 , 93};

int max = Max (
Max(array[0],array[1],array[2]),
Max(array[3],array[4],array[5]),
Max(array[6],array[7],array[8])
);

Console.WriteLine(max);
