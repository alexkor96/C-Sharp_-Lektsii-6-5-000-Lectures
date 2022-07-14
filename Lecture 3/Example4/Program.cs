// ====== Работа с текстом 
// Дан текст. В тексте нужно все пробелы заменить черточками, 
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить на маленькие "с".
string text = "- Я думаю, - сказать князь, улыбаясь, -что," 
            + "ежели бы Вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля"
            + "Вы так красноречивы, Вы дадите мне чаю?";

string RePlace(string text, char oldValue, char newValue){
    string result = String.Empty;
    int Lenhgt = text.Length;
    for (int i = 0; i < Lenhgt; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string NewText = RePlace(text, ' ','|');
Console.WriteLine(NewText);
Console.WriteLine();
NewText = RePlace(NewText, 'к','К');
Console.WriteLine(NewText);
Console.WriteLine();
NewText = RePlace(NewText, 'с','С');
Console.WriteLine(NewText);

