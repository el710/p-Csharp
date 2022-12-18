// work with array
//1. find the element "lost"

const int arraySize = 100;
const int randomSize = 100;

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


int[] array = new int[arraySize];
int lost, result;


// init
InitArray(array, randomSize);
PrintArray(array);

// 1. find the element "lost"
lost = new Random().Next(0, randomSize);
result = IndexOf(array, lost);
if(result != -1) Console.WriteLine($"We find {lost} in array[{result}] ");
else Console.WriteLine($"There is no {lost} in array ");

