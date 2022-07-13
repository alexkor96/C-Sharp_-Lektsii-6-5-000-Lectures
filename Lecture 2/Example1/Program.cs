int Max(int Arg1, int Arg2, int Arg3) {
    int resuslt = Arg1;
    if(Arg2>resuslt) resuslt = Arg2;
    if(Arg3>resuslt) resuslt = Arg3;
    return resuslt;
}
int a1 = 10;
int b1 = 65;
int c1 = 56;
int a2 = 14;
int b2 = 15;
int c2 = 50;
int a3 = 87;
int b3 = 54;
int c3 = 23;

int Max1 = Max(a1,b1,c1);
int Max2 = Max(a2,b2,c2);
int Max3 = Max(a3,b3,c3);
int max = Max(Max1,Max2,Max3);
Console.WriteLine(max);
