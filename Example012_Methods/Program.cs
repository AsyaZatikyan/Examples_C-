/*Вид 1*/

void Method1()
{
    Console.WriteLine("Автор Затикян Ася!");
}
//Method1();

//Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}

//Method2 (msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine("Текст сообщения");
        i++;//i=+1
    }
}
//Method21("Текст сообщения", 4);
//Method21(msg:"Текст сообщения", count:4);
//Method21(count: 4, msg:"Новый текст");


//Вид3, метод, который возвращает что-то

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);

// Вид4, когда методы что - то принимают и что-то возвращают

//string Method4(int count, string c)
//{
//int i = 0;
//string result = String.Empty;
//while (i < count)
//{
//result = result + c;
//i++;
// }
//return result;
//}
//string str = Method4(10,"c");
//Console.WriteLine(str);

string Method4(int count, string c)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}
string str = Method4(10,"c");
//Console.WriteLine(str);

for (int i = 2; i < 10; i++)
{
 for (int j = 0; j < 10; j++)
 {
    Console.WriteLine($"{i}*{j}={i*j}");
 }
 Console.WriteLine(); //своего рода переход чтобы разделить каждое следующее число
}