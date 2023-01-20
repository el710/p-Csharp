// work with array

Console.WriteLine("There are examples with arrays");

//defines array
// int[] array1 = {1, 2, 3};
// int[] array2 = new int[5];
// int[] array3 = new int[]{1, 2, 3, 4, 5};
// int[] array4 = new int[5]{1, 2, 3, 4, 5};



const int _arraySize = 100;
const int _randomSize = 100;

int[] array = new int[_arraySize];
int lost, result;

// initialisation of array
InitArray(array, _randomSize);
// show array
//Console.WriteLine(String.Join(" ",array));
//Console.ReadLine();
PrintArray(array, 20);

//================================================
// 1. find the random element "lost"
lost = new Random().Next(0, _randomSize);

result = IndexOf(array, lost);

if(result != -1) Console.WriteLine($"We find {lost} in array[{result}] ");
else Console.WriteLine($"There is no {lost} in array ");


Console.WriteLine("press enter when ready..."); Console.ReadLine();


//==================== implementation

void PrintArray(int[] set, int columns){

    int size = set.Length;
    int index = 0;
     
    int row = 0;
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

void InitArray(int[] set, int rand){

    int index = 0;

    while( index < set.Length){
        set[index] = new Random().Next(0, rand);
        index++;
    }
    Console.WriteLine("");
}

int IndexOf(int[] set, int seek){
    int size = set.Length;
    int index = 0;

    while( index < size){
        
        if(set[index] == seek ) return index;
        index++;
    }
     
    return -1;
}