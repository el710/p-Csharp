
/*/--------------------------------- 
Console.Clear();
Console.WriteLine("Task 34: Find quontity of even numbers in array");
int sizeArray = 0;
if(! GetUserIntNumber(ref sizeArray,"input size of array ")) return;
if(sizeArray > 0){
    int[] array1 = new int[sizeArray];
    InitArray(ref array1, 100, 999);
    PrintArray(array1, 5, 5);
    Console.WriteLine($"This array has {CountEvenNumbers(array1)} even numbers");
}

Console.WriteLine("Task 34: done. Press anykey to continue..."); Console.ReadLine();
/**/

/*/---------------------------------- 
Console.Clear();
Console.WriteLine("Task 36: Find sum of odd position items in array");
int length = 0;

if(! GetUserIntNumber(ref length,"input size of array ")) return;
if(length > 0){
    int[] array36 = new int[length];
    InitArray(ref array36, 0, 100);
    PrintArray(array36, 5, 5);
    Console.Write($"Sum of odd position items: ");
    double result = GetSumOddItems(array36);
    Console.WriteLine($" = {result}");
}
Console.WriteLine("Task 36: done. Press anykey to continue..."); Console.ReadLine();
/**/

//-----------------------------------
Console.Clear();
Console.WriteLine("Task 38: Find difference between Max & Min items of array");
int length = 0;

if(! GetUserIntNumber(ref length,"input size of array ")) return;
if(length > 0){
    double[] array38 = new double[length];
    InitRealArray(array38, 0, 100);
    PrintRealArray(array38, 5, 5);
    MaxSorting(array38);
    
    Console.WriteLine($"Difference between Max({array38[length-1]}) & Min({array38[0]}) items  = {GetDiffMAxMin(array38)} ");
  
}
Console.WriteLine("Task 36: done. Press anykey to continue..."); Console.ReadLine();


//=====================================================
void PrintRealArray(double[] set, int fromRow, int columns){

    int size = set.Length;
    int index = 0;

    int cols;

    while( index < size){
        if((size-index) > columns ) cols = columns;
        else cols = size - index;

        for(int j = 0; j < cols; j++){
            Console.SetCursorPosition(7+(j*5), 1+fromRow);
            Console.Write($" {set[index]} ");
            index++;
        }    
        fromRow++;               
    }
    Console.WriteLine("");
}

//====================================================
void InitRealArray(double[] set, int randMin, int randMaх){
    for(int i = 0; i < set.Length; i++){
        set[i] = new Random().NextDouble(); //(randMin,randMaх + 1);
    }
}

//=====================================================
double GetDiffMAxMin(double[] set){
    return set[set.Length - 1] - set[0];
}

//=====================================================
void MaxSorting(double[] array){

    int size = array.Length;

    for(int i = 0; i < size - 1; i++){
        for(int j = i + 1; j < size; j++){
            if(array[j] < array[i]){
                double temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
}

//=====================================================
double GetSumOddItems( int[] set){
    double sum = 0;
    bool lastodd  = ((set.Length % 2) == 0);

    for(int i = 0; i < set.Length; i++){
        if((i % 2) == 0){
            Console.Write($"{set[i]} ");
            sum += set[i];
            if(i < (set.Length - 2) ) Console.Write($"+ ");
        }
    }
    return sum;
}



int CountEvenNumbers(int[] set){
    int evenCount = 0;
    for(int i = 0; i < set.Length; i++){
        if((set[i] % 2) == 0) evenCount++;
    }
    return evenCount;
}

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

//====================================================
void InitArray(ref int[] set, int randMin, int randMaх){
    for(int i = 0; i < set.Length; i++){
        set[i] = new Random().Next(randMin,randMaх + 1);
    }
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
