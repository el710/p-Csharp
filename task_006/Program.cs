//----------------- Task 6
string number1;
double real_num1;


Console.Clear();

Console.WriteLine("Задача 6: define odd/even of user's number");
Console.Write("Введите произвольное число: ");

number1 = Console.ReadLine() ?? "";
real_num1 = double.Parse(number1);

if (real_num1 % 2 == 0) Console.WriteLine($"Число {real_num1} - четное");
else Console.WriteLine($"Число {real_num1} - нечетное");
