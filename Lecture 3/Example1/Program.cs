// 1 метод ничего не принимает, ничего не возвращает. 
void Method1(){
    Console.WriteLine("Какой то текст");
}

//Method1();
// 2 метод ничего не возвращает, но может принимать какие-либо значения. 
void Method2(string Msg){
    Console.WriteLine(Msg);
}


//Method2("Привет Андрей!!!"); если аргумент 1, дом можно написать код так. 
// Если аргументов несколько, то: 
void Method2_1(string Msg, int count){
    int i = 0;
    while (i<count){
        Console.WriteLine(Msg);
        i++;
    }

}
// Method2_1(Msg:"Привет Алексей", count:3); Возвращает несколько аргументов. 


// 3 метод Что-то возвращает, но ничего не принимает. 
//указываем тот тип данных значения, который мы ожидаем получить.
int Method3(){
    return DateTime.Now.Year;
}

//int Year = Method3();
//Console.WriteLine(Year);

// 4 метод что-то принимает, что-то возвращает. Наиболее частый. 
string Method4(int count, string C){
    int i =0; 
    // string result = " "
    string result = String.Empty;
    while( i < count){
        result = result + C;
        i++;
    }
    return result;
}
//string res = Method4( 10, "a");
//Console.WriteLine(res);