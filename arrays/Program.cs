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
PrintArray(array);

//================================================
// 1. find the random element "lost"
lost = new Random().Next(0, _randomSize);

result = IndexOf(array, lost);

if(result != -1) Console.WriteLine($"We find {lost} in array[{result}] ");
else Console.WriteLine($"There is no {lost} in array ");


Console.WriteLine("press enter when ready..."); Console.ReadLine();


//==================== implemantation

void PrintArray(int[] set){

    int size = set.Length;
    int index = 0;

    while( index < size){
        if(index % 20 == 0 && index != 0) Console.WriteLine($"{set[index]} ");
        else Console.Write($"{set[index]} ");
        
        index++;
    }
    Console.WriteLine("");

}

void InitArray(int[] set, int rand){

    int size = set.Length;
    int index = 0;

    while( index < size){
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