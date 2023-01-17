//-------------------------------- task 25: Find A^B
int userBase = 1, userPow = 1;

Console.Clear();
Console.WriteLine("Task 25: Find result of A ^ B");

if(! GetUserIntNumber(ref userBase,"input base number ")) return;
if(! GetUserIntNumber(ref userPow,"input pow number ")) return;

Console.WriteLine($"{userBase} ^ {userPow} = {GetPow(userBase, userPow)}");

Console.WriteLine("Task 25: done. Press anykey to continue..."); Console.ReadLine();


//-------------------------------- task 27: Sum of number's digits
int userNumber = 0;

Console.Clear();
Console.WriteLine("Task 27: Find sum of digits in user's number");

if(! GetUserIntNumber(ref userNumber,"input integer number ")) return;

Console.WriteLine($"Sum of digits in {userNumber} = {GetSumDigits(userNumber)}");

Console.WriteLine("Task 27: done. Press anykey to continue..."); Console.ReadLine();

//-------------------------------- task 29: Make array
const int _ArraySize = 8;
const int _MaxValue = 100;

int[] array = new int[_ArraySize];
int index = 0, newValue = 0;

Console.Clear();
Console.WriteLine("Task 29: Make array of eight(8) elements");

InitArray(ref array, _MaxValue);
PrintArray(array, 0, 4);
Console.WriteLine("");

Console.WriteLine("You can change value of one element");
if(GetUserIntNumber(ref index,"input index of element in [1..8]")){
    if(GetUserIntNumber(ref newValue,$"input new value of array[{index}] ")){
        if(index<1 || index>8){
            Console.WriteLine("Your index is wrong, so take the first element");
            index = 1;
        }
        array[index-1] = newValue;
        PrintArray(array, 8, 4);
    }
}

Console.WriteLine("Task 29: done. Press anykey to continue..."); Console.ReadLine();

//=====================================================
void PrintArray(int[] set, int row, int columns){

    int size = set.Length;
    int index = 0;

    int cols;

    while( index < size){
        if((size-index) > columns ) cols = columns;
        else cols = size - index;

        for(int j = 0; j < cols; j++){
            Console.SetCursorPosition(7+(j*5), 1+row);
            Console.Write($"{set[index]} ");
            index++;
        }    
        row++;               
    }
    Console.WriteLine("");
}

void InitArray(ref int[] set, int random){
    for(int i = 0; i < set.Length; i++){
        set[i] = new Random().Next(0,random + 1);
    }
}

//=================================================
int GetSumDigits(int number){
    int sum = 0;

    while(number > 0){
        sum += number % 10;
        number /= 10;
    }

    return sum;
}

//==================================================
int GetPow(int inBase, int inPow){
    int result;

    if(inPow > 0){
        result = inBase;
        for(int i = 1; i < inPow; i++) result *= inBase;
    }
    else result = 1;

    return result;
}

//====================================================
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
