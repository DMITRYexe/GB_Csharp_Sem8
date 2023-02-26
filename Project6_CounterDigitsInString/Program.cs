// 83.  Подсчитать количество цифр среди вводимых с клавиатуры символов

string s = Console.ReadLine();
int k=0;
for (int i=0; i<s.Length; i++)
 if (s[i]>='0' && s[i]<='9') k++;
 System.Console.WriteLine(k);

 // но лучше через foreach 
int counter=0;
 foreach (char c in s)
 if (c>='0' && c<='9') counter++;
 System.Console.WriteLine(counter);