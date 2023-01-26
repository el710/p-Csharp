// work with array

Console.WriteLine("There are examples with arrays");

//=========== defines array
// int[] array1 = {1, 2, 3};
// int[] array2 = new int[5];
// int[] array3 = new int[]{1, 2, 3, 4, 5};
// int[] array4 = new int[5]{1, 2, 3, 4, 5};

// int[,] array2D = new int[5, 5]



// -------------- multi dimension arrays
int[,] matrix = new int[3, 4]; 

Console.Clear();
Console.WriteLine("2D array - matrix");
FillMatrix(matrix);
ShowMatrix(matrix);


/**/
void FillMatrix(int[,] matr){
    for(int i = 0; i < matr.GetLength(0); i++){
        for(int j = 0; j < matr.GetLength(1); j++){
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void ShowMatrix(int[,] matr){
    for(int i = 0; i < matr.GetLength(0); i++){
        for(int j = 0; j < matr.GetLength(1); j++){
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}


/*/---------------  initialisation and show array
const int _arraySize = 100;
const int _randomSize = 100;

int[] array = new int[_arraySize];
int lost, result;

InitArray(array, _randomSize);
Console.WriteLine(String.Join(" ",array));
Console.WriteLine();
PrintIntArray(array, 10, 10);

//=========== find the random element "lost"
lost = new Random().Next(0, _randomSize);
result = IndexOf(array, lost);
if(result != -1) Console.WriteLine($"We find {lost} in array[{result}] ");
else Console.WriteLine($"There is no {lost} in array ");
Console.WriteLine("press enter when ready..."); Console.ReadLine();
/**/

//==================== implementation

//=====================================================
void PrintIntArray(int[] set, int row, int columns){

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