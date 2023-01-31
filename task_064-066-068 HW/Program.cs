//---------------------------------------
Console.Clear();
Console.WriteLine("Task 68: Akkerman function");

int numberM = 0;
if(!GetUserIntNumber(ref numberM, "input integer number M")) return;
int numberN = 0;
if(!GetUserIntNumber(ref numberN, "input integer number N")) return;
double funAkkerman = Akkerman((double)numberM, (double)numberN);
Console.WriteLine($"A({numberM}, {numberN}) = {funAkkerman}");

Console.WriteLine("Task 68 done. Press <Enter> to continue..."); Console.ReadLine();
/**/
//========================================
double Akkerman(double M, double N){
    if(M == 0) return N + 1;
    if(N == 0) return Akkerman(M - 1, 1);
    return Akkerman(M - 1, Akkerman(M, N - 1));
}

//---------------------------------------
Console.Clear();
Console.WriteLine("Task 66: Get sum of numbers in [N..M] recursively");

int startNumber = 0;
if(!GetUserIntNumber(ref startNumber, "input start number")) return;
int endNumber = 0;
if(!GetUserIntNumber(ref endNumber, "input end number")) return;

if(startNumber > endNumber) (startNumber, endNumber) = (endNumber, startNumber);

Console.WriteLine($" = {GetReqSum(startNumber, endNumber)}");

Console.WriteLine("Task 66 done. Press <Enter> to continue..."); Console.ReadLine();
/**/
//========================================
int GetReqSum(int start, int end){
    
    Console.Write($"{start}");
    if(start < end){
        Console.Write(" + ");
        return (start) + GetReqSum(start+1, end);
    }else{
        return start;
    } 
}

//---------------------------------------
Console.Clear();
Console.WriteLine("Task 64: Show inverse line of number from N to 1");

startNumber = 0;
if(!GetUserIntNumber(ref startNumber, "input start number")) return;

ShowLine(startNumber, 1);

Console.WriteLine("Task 64 done. Press <Enter> ..."); Console.ReadLine();
/**/
//===============================================
void ShowLine(int startNumber, int endNumber){
    Console.Write($"{startNumber}");
    if(startNumber != endNumber){
        Console.Write(", "); 
        ShowLine(startNumber - 1, endNumber);
    } 
    else Console.WriteLine(""); 

}

bool GetUserIntNumber(ref int result, string query){

    int times = 5;
    string text;

    while(times > 0){

        Console.Write($"{query}: ");
        text = Console.ReadLine() ?? "";

        try{
            result = Convert.ToInt32(text);
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