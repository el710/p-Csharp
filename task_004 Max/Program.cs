//------------------------ Task 4
string number1, number2, number3;
double real_num1, real_num2, real_num3;

Console.Clear();

Console.WriteLine("Задача 4: find Max from 3 double user's numbers");
Console.Write("Введите первое из трех чисел A: ");
number1 = Console.ReadLine() ?? "";
real_num1 = double.Parse(number1);

Console.Write("Введите второе из трех чисел B: ");
number2 = Console.ReadLine() ?? "";
real_num2 = double.Parse(number2);

Console.Write("Введите третье из трех чисел B: ");
number3 = Console.ReadLine() ?? "";
real_num3 = double.Parse(number3);

Console.Write($" Из {real_num1}, {real_num2} и {real_num3}: ");
double max = real_num1;

if(real_num2 > max) max = real_num2;
if(real_num3 > max) max = real_num3;
Console.WriteLine($"{max} - максимальное");