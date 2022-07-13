Console.WriteLine("Введите Ваше имя: ");
string username = Convert.ToString(Console.ReadLine()); 
if(username.ToLower() == "алексей"){
Console.WriteLine("Приветствую тебя, Воин!");
}
else Console.WriteLine("Привет, " + username);