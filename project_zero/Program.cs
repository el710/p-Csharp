// See https://aka.ms/new-console-template for more information

// data types
bool bool_var = true;
int int_num_var = 100;
double real_num_var = 100.5;
string text_var = "C Sharp World ";

// array
int[] array1 = {1, 2, 3};
// int[] array2 = new int[5];
// int[] array3 = new int[]{1, 2, 3, 4, 5};
// int[] array4 = new int[5]{1, 2, 3, 4, 5};


// output
Console.Clear();
Console.Write(text_var);
Console.WriteLine(" man...");
Console.WriteLine($"{int_num_var} ... {real_num_var}");

// input
Console.Write("Введите число: ");
string user_text = Console.ReadLine() ?? ""; // чтение с проверкой на NULL - и заменой его на "" - пустую строку

// transforamtion
int_num_var = int.Parse(user_text); // string to number
int_num_var = (int)real_num_var;  // real type to integer type


// Math: + - * / % ...
double pow = Math.Pow(int_num_var, 2); //square
Console.WriteLine($"square of {int_num_var} = {pow}");

double sum = pow + int_num_var;
Console.WriteLine($"sum: {pow} + {int_num_var} = {sum}");

double quotient = pow + int_num_var;
Console.Write($"quotient: {pow} / {int_num_var} =");
Console.WriteLine(pow / int_num_var);

int_num_var = new Random().Next(10,20); // random number in [10...19]
Console.WriteLine($"random number: {int_num_var}");

// if
bool_var = false;
Console.Write("Sign in: ");
string userName = Console.ReadLine() ?? "";

if(userName.ToLower() == "masha") bool_var = true;
else bool_var = false;

if(bool_var){
    Console.WriteLine("Hello Masyanya!");
}
else {
    Console.WriteLine($"How are you {userName}");
}

// cycle
int count = 10;
Console.Clear();

while(count > 0){

    int x = new Random().Next(0,10);
    int y = new Random().Next(0,10);
    
    Console.SetCursorPosition(x, y);
    Console.Write("*");
    count--;
}

// method
int find_max(int x, int y, int z){
    int res = x;
    
    if(y > res) res = y;
    if(z > res) res = z;
    return res;
}

Console.WriteLine($"Max of 1, 2, 3 is {find_max(array1[0],array1[1],array1[2])}");