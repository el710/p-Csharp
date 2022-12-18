// Home work 1


//---------------------- task 2:
Console.Clear();
Console.WriteLine("Задача 2");
Console.Write("Введите первое из двух чисел A: ");
string number1 = Console.ReadLine() ?? "";

double real_num1 = double.Parse(number1);

Console.Write("Введите второе из двух чисел B: ");
string number2 = Console.ReadLine() ?? "";

double real_num2 = double.Parse(number2);

Console.Write($" Из {real_num1} и {real_num2}: ");

if(real_num1 > real_num2) {
    Console.WriteLine($" большее {real_num1} меньшее {real_num2} "); 
}
else if(real_num1 < real_num2) {
    Console.WriteLine($" большее {real_num2} меньшее {real_num1} "); 
}
else  Console.WriteLine($" они равны "); 


//------------------------ Task 4
string number3;
double real_num3;
Console.WriteLine("");
Console.WriteLine("Задача 4");
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


//----------------- Task 6
Console.WriteLine();
Console.WriteLine("Задача 6");
Console.Write("Введите произвольное число: ");

number1 = Console.ReadLine() ?? "";
real_num1 = double.Parse(number1);

if (real_num1 % 2 == 0) Console.WriteLine($"Число {real_num1} - четное");
else Console.WriteLine($"Число {real_num1} - нечетное");


//------------------ Task 8
int int_num, item = 1;
Console.WriteLine();
Console.WriteLine("Задача 8");
Console.Write("Введите произвольное целое число: ");

number1 = Console.ReadLine() ?? "";
int_num = int.Parse(number1);

Console.WriteLine($"Четные числа от 1 до {int_num}: ");
while(item < int_num){
    if(item % 2 == 0) Console.WriteLine(item);
    item++;
}