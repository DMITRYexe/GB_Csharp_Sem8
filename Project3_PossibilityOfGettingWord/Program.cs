// Проверка на возможность из набора символов получить конкретные данные

string s1 = "ABCDE";
string s2 = "CDEAB";

char [] c1 = s1.ToCharArray();
char [] c2 = s2.ToCharArray();
Array.Sort(c1);
Array.Sort(c2);

string s3 = new String (c1);
string s4 = new String (c2); 
// если после сортировки массивы совпали, то трансформация возможна
if (s3==s4) System.Console.WriteLine("Трансформация возможна");
else System.Console.WriteLine($"Из {s1} не получить {s2}");
