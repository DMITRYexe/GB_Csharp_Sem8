// 84. Определить являются ли введенные с клавиатуры символы правильно записью целого числа. 
// Вычислить сумму цифр введенного числа
System.Console.WriteLine("Введите данные. Если будет введено целое число, программа посчитает сумму цифр в числе");
try
{
  int inputData = Convert.ToInt32(Console.ReadLine());
  int summary = 0;
  while (inputData%10!=0)
  {
   summary = summary + inputData%10;
   inputData = inputData/10;
  }
System.Console.WriteLine(summary);
}
catch
{
  System.Console.WriteLine("Не целое число");
}


