//==============================================
// Math: + - * / % ...

int intVar = 777;

Console.Clear();
Console.WriteLine("Math examples...");

double pow = Math.Pow(intVar, 2); //power 2 of int_num_var
Console.WriteLine($" {intVar}^2 = {pow}");

double sum = pow + intVar;
Console.WriteLine($"sum: {pow} + {intVar} = {sum}");

double quotient = pow + intVar;
Console.Write($"quotient: {pow} / {intVar} =");
Console.WriteLine(pow / intVar);

intVar = new Random().Next(10,20); // random number in [10...19]
Console.WriteLine($"random number: {intVar}");

Console.WriteLine("press enter when ready..."); Console.ReadLine();