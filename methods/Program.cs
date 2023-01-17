//============================================
// methods

Console.Clear();
Console.WriteLine("Using of methods...");

Method1();

string mess = String.Empty; // null initialisation of string

Method2("Hello Method2");

Method3(number: 10, msg: "second parameter"); // set paramaters in random order


int[] array1 = {234, 546, 678};
Console.WriteLine($"Method with returned value: max of 1, 2, 3 is {find_max(array1[0],array1[1],array1[2])}");

int intVar = 0, count = 0;
init(ref intVar, ref count); // give referances if variables - method can change variables
Console.WriteLine($"var & count become {intVar} - {count}");


int a = 5, b = 0;
BackParam(a, out b);
Console.WriteLine($"Method return parameter {b}");



Console.WriteLine("Press enter for continue..."); Console.ReadLine();




//---------------- implementation

// simple method
void Method1(){
    Console.WriteLine("Method1: no return value and no parameters");
}

void Method2(string msg){
    Console.WriteLine($"Method2: get string parameter {msg}");
}

void Method3(string msg, int number){
    Console.WriteLine($"Method3: get string - {msg} and integer - {number}");
}

int find_max(int x, int y, int z){ 
    int res = x;
    
    if(y > res) res = y;
    if(z > res) res = z;
    return res;
}

// method take referance of parameters
void init(ref int x, ref int y){

    Console.WriteLine("This method can change parameters by referances");
    x=5;
    y=5;
}

void BackParam(int intIn, out int intOut){
    intOut = intIn;
}

