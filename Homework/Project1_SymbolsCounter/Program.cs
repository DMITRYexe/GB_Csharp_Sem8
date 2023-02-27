// 82. C клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки
System.Console.WriteLine("Введите текст. Программа посчитает кол-во символов до первой точки");
string? InputText = Console.ReadLine ();
int SymbolsBeforeDot = InputText.IndexOf('.');
System.Console.WriteLine($"{SymbolsBeforeDot}");
