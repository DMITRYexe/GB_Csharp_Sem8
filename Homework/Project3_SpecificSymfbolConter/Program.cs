// 86. Подсчитать сколько раз определенный символ (например 'a') встречается в строке.
System.Console.WriteLine("Введите текст:");
string? inputData = Console.ReadLine();
System.Console.WriteLine("Введите символ, который нужно сосчитать:");
ConsoleKeyInfo keyInfo;
keyInfo = Console.ReadKey();
char soughtForSymbol = keyInfo.KeyChar;
int counter = 0;
foreach (char Symbol in inputData)
{
  if (Symbol == soughtForSymbol) counter++;
}
System.Console.WriteLine();
System.Console.WriteLine($"Символ \"{soughtForSymbol}\" встретился {counter} раз(а).");