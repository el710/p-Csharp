//==============================================
// cycles

//--------------------- while
Console.Clear();
Console.WriteLine("draw with while cycle..."); 

int count = 10;
while(count > 0){

    int x = new Random().Next(0,10);
    int y = new Random().Next(0,10);
    
    Console.SetCursorPosition(x, y);
    Console.Write("*");
    count--;
}

//------------------------ for cycle
Console.WriteLine("init array with for cycle..."); 

int[] array = new int[10];

Console.Write("array[ ");

for(int i = 0; i < array.Length; i++){
    array[i] = new Random().Next(0,2);
    Console.Write($"{array[i]} ");
}

 Console.WriteLine("]");


Console.WriteLine("press enter when ready..."); Console.ReadLine();

//------------------------ foreach
Console.Clear();
Console.WriteLine(" Get sums of positive numbers in array");

int[] array = InitIntArray(12, -9, 9);

int positiveSum = GetPositiveSum(array);

Console.WriteLine($"sum of positive = {positiveSum}");

Console.WriteLine("press enter when ready..."); Console.ReadLine();
/**/

int GetPositiveSum(int[] set){
    int sum = 0;
    foreach( int item in set) 
        if(item > 0) sum += item;
    return sum;
}

int[] InitIntArray(int size, int min, int max){

    int[] set = new int[size];

    Console.Write("array[ ");

    for(int i = 0; i < set.Length; i++){
        set[i] = new Random().Next(min,max+1);
        Console.Write($"{set[i]}");
        if(i<set.Length-1) Console.Write(", ");
    }

    Console.WriteLine(" ]");
    return set;
}