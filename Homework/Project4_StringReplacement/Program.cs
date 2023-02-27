// 88. Заменить все вхождения подстроки w в строке st на строку v. 
// Вывести на экран первоначальную строку и конечную строку

string a = "Начало текста.";
string b = "Середина текста.";
string w = "Конец текста.";

string [] array = new string [] {a , b , w}; 

string result = string.Join(" ", array);

System.Console.WriteLine(result);

string v = "Не конец, а окончание!";

for (int i = 0; i<array.Length; i++) // на случай масштабирования
  if (array[i] == w) array[i] = v;

string result2 = string.Join(" ", array);

System.Console.WriteLine(result2);

// Так понял условие. Уж очень обобщенно (или запутано) написано
