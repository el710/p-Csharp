//---------------------- task 2:
Console.Clear();

Console.WriteLine("Задача 2: find Max & Min between two user's numbers");
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