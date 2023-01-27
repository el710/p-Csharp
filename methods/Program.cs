//============================================
// methods

Console.Clear();
Console.WriteLine("Using of methods...");


//--------- C# syntax
var IsEven = (double value) => value % 2 == 0;

double realNumber = 45;

if(IsEven(realNumber)) Console.WriteLine($" even ");
else Console.WriteLine($" odd ");



/*/------------------- recursive 
for(int i = 0; i < 10; i++){
    Console.WriteLine($"Factorial {i} = {Factorial(i)}");
}

int Factorial(int number){

    if(number == 0) return 1;
    else return (number * Factorial(number - 1));
}
/**/

/*/------------------- returned parameter
int a = 5, b = 0;
BackParam(a, out b);
Console.WriteLine($"Method return parameter {b}");

void BackParam(int intIn, out int intOut){
    intOut = intIn;
}
/**/

/*/------------------ using reference as parameter
int intVar = 0, count = 0;
init(ref intVar, ref count); // give referances if variables - method can change variables
Console.WriteLine($"var & count become {intVar} - {count}");

// method take referance of parameters
void init(ref int x, ref int y){

    Console.WriteLine("This method can change parameters by referances");
    x=5;
    y=5;
}
/**/

/*/------------------ returning method
int[] array1 = {234, 546, 678};
Console.WriteLine($"Method with returned value: max of 1, 2, 3 is {find_max(array1[0],array1[1],array1[2])}");

int find_max(int x, int y, int z){ 
    int res = x;
    
    if(y > res) res = y;
    if(z > res) res = z;
    return res;
}
/**/

/*/----------------- set paramaters in random order
Method3(number: 10, msg: "second parameter"); 

void Method3(string msg, int number){
    Console.WriteLine($"Method3: get string - {msg} and integer - {number}");
}
/**/

/*/-------------- with parameter
Method2("Hello Method2");

void Method2(string msg){
    Console.WriteLine($"Method2: get string parameter {msg}");
}
/**/

/*/------------- simple
Method1();

void Method1(){
    Console.WriteLine("Method1: no return value and no parameters");
}
/**/

Console.WriteLine("Press enter for end"); Console.ReadLine();