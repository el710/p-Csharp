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
Console.WriteLine(">Console output examples...");
Console.Write(text_var);
Console.WriteLine(" man...");
Console.WriteLine($"{int_num_var} ... {real_num_var}");

Console.WriteLine("press enter when ready..."); Console.ReadLine();

// input
Console.Clear();
Console.WriteLine(">Console input examples...");
Console.Write("input some in console: ");
string user_text = Console.ReadLine() ?? ""; // чтение с проверкой на NULL - и заменой его на "" - пустую строку
Console.WriteLine($"Your input is {user_text}");
Console.WriteLine("press enter when ready..."); Console.ReadLine();

//=============================================
// transforamtion
Console.Clear();

Console.WriteLine(">trans examples...");
Console.Write("input number in console (honestly): ");
user_text = Console.ReadLine() ?? "";
real_num_var = double.Parse(user_text); // string to number
int_num_var = (int)real_num_var;  // real type to integer type
Console.WriteLine($"Your input is {int_num_var}");

Console.Write("input number again (for Convert...): ");
int_num_var = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Your input is {int_num_var}");

Console.WriteLine("press enter when ready..."); Console.ReadLine();

Console.Clear();

text_var = $"{int_num_var}";
Console.WriteLine($"Integer variable int_num_var = {int_num_var} became a string = {text_var}");

Console.WriteLine("press enter when ready..."); Console.ReadLine();

//==============================================
// Math: + - * / % ...
Console.Clear();
Console.WriteLine(">Math examples...");
double pow = Math.Pow(int_num_var, 2); //power 2 of int_num_var
Console.WriteLine($"square of {int_num_var} = {pow}");

double sum = pow + int_num_var;
Console.WriteLine($"sum: {pow} + {int_num_var} = {sum}");

double quotient = pow + int_num_var;
Console.Write($"quotient: {pow} / {int_num_var} =");
Console.WriteLine(pow / int_num_var);

int_num_var = new Random().Next(10,20); // random number in [10...19]
Console.WriteLine($"random number: {int_num_var}");
Console.WriteLine("press enter when ready..."); Console.ReadLine();

//=============================================
// if
bool_var = false;
Console.Write("Sign in (masha?): ");
string userName = Console.ReadLine() ?? "";

if(userName.ToLower() == "masha") bool_var = true;
else bool_var = false;

if(bool_var){
    Console.WriteLine("Hello Masyanya!");
}
else {
    Console.WriteLine($"How are you {userName}");
}
Console.WriteLine("press enter when ready..."); Console.ReadLine();

//==============================================
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
Console.WriteLine("press enter when ready..."); Console.ReadLine();

//============================================
// methods
Console.Clear();
Console.WriteLine("Using of methods...");

// simple method
int find_max(int x, int y, int z){ // take mean of parameters
    int res = x;
    
    if(y > res) res = y;
    if(z > res) res = z;
    return res;
}
Console.WriteLine($"Max of 1, 2, 3 is {find_max(array1[0],array1[1],array1[2])}");

// method take referance of parameters
void init(ref int x, ref int y){
    x=5;
    y=5;
}

 init(ref int_num_var, ref count); // give referances if variables - method can change variables
 Console.WriteLine($"var & count become {int_num_var} - {count}");

Console.WriteLine("Press enter for continue..."); Console.ReadLine();


//==============================================
// try...catch
Console.Clear();
Console.WriteLine(">try catch example...");
Console.Write("input any number: ");
try{
    int_num_var = Convert.ToInt32(Console.ReadLine());
}
catch(Exception exc){
        Console.WriteLine($"Error input: {exc.Message}");
}