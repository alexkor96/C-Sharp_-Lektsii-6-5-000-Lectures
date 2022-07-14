// пример использования цикла For
string Method4(int count, string C){
     
    // string result = " "
    string result = String.Empty;
    for(int i =0; i< count; i++)
    {
        result = result + C;
    }
    return result;
}
string res = Method4( 10, "a");
Console.WriteLine(res);
