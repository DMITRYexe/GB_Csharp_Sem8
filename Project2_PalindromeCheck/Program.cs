// Проверка строки на полиндромом
string s = "POPR";
char [] s1 = s.Reverse().ToArray();
string s2 = new String(s1);
System.Console.WriteLine(s2);
if (s2==s) System.Console.WriteLine("Палиндромом"); else System.Console.WriteLine("Не палиндромом");
