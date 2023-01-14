//============================================
// methods

Console.Clear();
Console.WriteLine("Using of methods...");

//---------------- using
int[] array1 = {234, 546, 678};
int intVar = 0, count = 0;

Console.WriteLine($"Max of 1, 2, 3 is {find_max(array1[0],array1[1],array1[2])}");

init(ref intVar, ref count); // give referances if variables - method can change variables
Console.WriteLine($"var & count become {intVar} - {count}");


Console.WriteLine("Press enter for continue..."); Console.ReadLine();




//---------------- implementation

// simple method
int find_max(int x, int y, int z){ // take mean of parameters
    int res = x;
    
    if(y > res) res = y;
    if(z > res) res = z;
    return res;
}


// method take referance of parameters
void init(ref int x, ref int y){
    x=5;
    y=5;
}



