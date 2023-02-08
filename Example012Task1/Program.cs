//===== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К"
//а большие "С" заменить маленькими "с"

// Ясна ли задача?

string text = "_ Я думаю, - сказал князь, улыбаясь, - что, "
+  "ежели бы вас послали вместо нашего милого Винценгероде"
+  "вы бы взяли приступом согласие прусского короля."
+  "Вы так красноречивы. Вы дадите мне чаю?" ;

// string s = "qwerty" индекс начинается с 0, поэтому r в слове qwerty - это s[3](0,1,2,3)
 // s [3] // r

string Replace(string text, char oldValue, char newvalue)
{
string result = String. Empty;
int length = text.Length;

for (int i = 0; i < length; i++)
{
  if(text[i] == oldValue) result = result + $"{newvalue}";
  else result = result + $"{text[i]}";
}

return result;
}
String newText = Replace(text, ' ', 'I');
Console.WriteLine(newText);

Console.WriteLine();
newText = Replace (newText, 'k', 'K');
Console.WriteLine (newText) ;
