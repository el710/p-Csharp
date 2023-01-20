
/*/---------------------- task 44: Show N Fibonachi line
int userNumber = 0;

Console.Clear();
Console.WriteLine("Task 44:  Show user's length line Fibonachi");

if(! GetUserIntNumber(ref userNumber,"input integer number ")) return;

ShowFibonachi(userNumber);

Console.WriteLine("Task 44:  done");

/**/
int ShowFibonachi(int number){

    if(number <= 0 ) return 0;
    int[] Fibonachi = new int[userNumber];
    int item = 0;
    
    Console.Write("Fibonachi line: ");
    while(item < number){
        if(item == 0){ 
            Fibonachi[item] = 0 ;    
        }
        else if(item == 1){
            Fibonachi[item] = 1;
        }
        else {
            Fibonachi[item] = Fibonachi[item-1] + Fibonachi[item-2];
        }

        Console.Write($"{Fibonachi[item]} ");
        item++;
    }
    Console.WriteLine();
    return 0;
}



/*/-------------------- task 42: Convert user's integer to binary
int userNumber = 0;

Console.Clear();
Console.WriteLine("Task 42:  Convert user's integer to binary");

if(! GetUserIntNumber(ref userNumber,"input integer number ")) return;

Console.WriteLine($"{userNumber} in binary: {IntToStrBin(userNumber)}");
Console.WriteLine("Task 42:  done");

/**/
string IntToStrBin(int number){

    string result = String.Empty;

    if(number == 0) return "0";
    
    while(number > 0){

        result = (number % 2).ToString() + result;
        number /= 2;

    }
    return result;
}
>>>>>>> abdbfb6c515b23c5100ac526ef6acc3ffc7c8ead




/*/----------------- task 40: 
int sideA = 0, sideB = 0, sideC = 0;
int[] sides = new int[3];

Console.Clear();
Console.WriteLine("Task 40:  check triangle existing by users's sides");
if(! GetUserIntNumber(ref sideA,"input length of A side ")) return;
if(! GetUserIntNumber(ref sideB,"input length of B side ")) return;
if(! GetUserIntNumber(ref sideC,"input length of C side ")) return;

sides[0] = sideA;
sides[1] = sideB;
sides[2] = sideC;

if(IsTriangle(sides)) Console.WriteLine($"{sideA} {sideB} {sideC} - are sides of triangle");
else Console.WriteLine($"{sideA} {sideB} {sideC} - are not triangle");

Console.WriteLine("Task 40:  done");

/**/
bool IsTriangle(int[] array){
    if(array[0] < (array[1] + array[2])){
        if(array[1] < (array[0] + array[2])){
            if(array[2] < (array[0] + array[1])){
                return true;

            }else return false;    
        }else return false;    
    }else return false;
}



/*/----------------- task 30: initialisation of array by [0,1]

int[] mas = new int[8];
Console.Clear();
Console.WriteLine("Task 30:  initialisation of array[8] by means of [0,1]");
InitArray(ref mas);
Console.WriteLine("Task 30:  done");

/**/
void InitArray(ref int [] array){

    Console.Write("array[ ");

    for(int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(0,2);
        Console.Write($"{array[i]}");
        if(i<array.Length-1) Console.Write(", ");
    }

    Console.WriteLine(" ]");
}


/*/--------------- task 28: Factorial
int userNumber = 0;

Console.Clear();
Console.WriteLine("Task 28: Find N factorial");
if(! GetUserIntNumber(ref userNumber,"input integer number ")) return;
Console.WriteLine($"{userNumber}! = {GetFactorial(userNumber)}");
Console.WriteLine("Task 28: done");

/**/
int GetFactorial(int number){
    int result = 1;

    for(int i = 2; i <= number; i++) result *=i;

    return result;
}



/*/--------------- task 26: count of digit in number
int userNumber = 0;

Console.Clear();
Console.WriteLine("Task 26: Get digit quantity of user's number");
if(! GetUserIntNumber(ref userNumber,"input integer number ")) return;
Console.WriteLine($"Number {userNumber} has {GetNumberLength(userNumber)} digits");
Console.WriteLine("Task 26: done");

/**/
int GetNumberLength(int number){
    int result = 0;

    if(number == 0) return 1;

    while(number > 0){
        result++;
        number /= 10;
    }
    return result;
}

/*/-------------- task 24: Sum of number's row
int userNumber = 0;

Console.Clear();
Console.WriteLine("Task 24: Find Sum of numbers from 1 to N - user's number");
if(! GetUserIntNumber(ref userNumber,"input integer number ")) return;
Console.WriteLine($" Sum from 1 to {userNumber} = {GetSequenceSum(userNumber)}");
Console.WriteLine("Task 24: has done.");

/*/
int GetSequenceSum (int limit){
    int sum = 0;
    for(int i = 1; i <= limit; i++) sum += i;
    return sum;
}


//---------- get integer 'result' number defined by 'query'
// EX:  if(! GetUserIntNumber(ref lim,"input integer number ")) return;

bool GetUserIntNumber(ref int result, string query){

    int times = 5;
    string text;

    while(times > 0){

        Console.Write($"{query}< ");
        text = Console.ReadLine() ?? "";

        try{
            result = Convert.ToInt32(text);
            Console.WriteLine();
            return true;
        }
        catch{
            times--;
            Console.Write($"{text} is not an integer number! ");
            if(times > 0) Console.WriteLine($"Try again ({times})");
        }       
    }

    return false;
} 

//---------------------- get number with 'length' digits
// EX:  int number = GetNumber(3);

int GetNumber(int length){

    int result, trytime = 5;
    int downBorder = (int)Math.Pow(10,length-1),
        upBorder = (int)Math.Pow(10,length);


    while(true){
        if(length != 0) Console.Write($"Input {length}-digit integer number [{downBorder}..{upBorder}): ");
        else Console.Write("> ");

        if(int.TryParse(Console.ReadLine(), out result)){

            if(length == 0){ 
                return result;
            }
            else if(result >= downBorder && result < upBorder){
                Console.WriteLine($"{result} - ok");
                return result;
            }
            else{
                trytime--;
                if(trytime <=0 ) return -1;
                Console.WriteLine($"Attention! wrong length of number. You have {trytime} tryies...");    
            }
        }     
        else{
            trytime--;
            if(trytime <=0 ) return -1;
            Console.WriteLine($"Attention! wrong input. You have {trytime} tryies...");
        }
    }
}
