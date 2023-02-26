// // Изучение типа данных "строки" и смежных.

// char a = 'A';

// System.Console.WriteLine((int)a); 

// // ConsoleKeyInfo keyInfo;
// // do
// // {
// //   keyInfo=Console.ReadKey();
// //   char ch = keyInfo.KeyChar;
// //   System.Console.WriteLine(keyInfo.KeyChar);
// //   if (ch>='0' && ch<='9') System.Console.WriteLine("Digit");
// //   if (char.IsDigit(ch)) System.Console.WriteLine("Digit!"); // более грамотная реализация строки выше
// //   if (ch>='A' && ch<='Z') System.Console.WriteLine("Big latin");
// //   System.Console.WriteLine(keyInfo.Key);
// // } while(keyInfo.Key!=ConsoleKey.Escape);

// string text = "For Esample.";

// System.Console.WriteLine(text[0]);

// string s = Console.ReadLine();
// string [] s1 = s.Split(' ',StringSplitOptions.RemoveEmptyEntries); // задаем разделить. В данном случае - пробел. При вводе двух пробелов мы написали "удалить пустую область"
// for (int i = 0; i<s1.Length; i++) // программа выводит элементы массива, разделим их по пробелу
// System.Console.WriteLine(s1[i]);

// int [] num = new int [s1.Length]; // конвертация отледных элементов string в int
// for (int i = 0; i<s1.Length; i++) 
//   num[i] = Convert.ToInt32(s1[i]); 
//   // или 
//   int [] copyNum = Array.ConvertAll<string, int> (s1, Convert.ToInt32);


// // неэффективный способ скалдывания строк
//   System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch;
//   stopwatch.Start();
//   string s = "";
//  for (int i = 0; i<100; i++) 
//   s = s + "QWERTYUIOPASDFGHJKLZXCVBNM";
//   stopwatch.Stop();
//   System.Console.WriteLine(stopwatch.ElapsedMilliseconds);

  // правильный способ
  using System.Text ;
  StringBuilder sb = new StringBuilder ();
  for (int i=0; i<1000; i++)
    sb.Append("15151");
  





