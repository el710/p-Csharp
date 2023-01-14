

//------------------ Task 8
string number1;
int int_num, item = 1;

Console.Clear();

Console.WriteLine("Задача 8: show even nubers from 1 to user's number");
Console.Write("Введите произвольное целое число: ");

number1 = Console.ReadLine() ?? "";
int_num = int.Parse(number1);

Console.WriteLine($"Четные числа от 1 до {int_num}: ");
while(item < int_num){
    if(item % 2 == 0) Console.WriteLine(item);
    item++;
}