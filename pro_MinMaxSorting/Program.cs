// Sorting by MinMax method


int[] intArray = new int[100];


Console.Clear();

InitArray(intArray, 100);
PrintArray(intArray, 15);

Console.WriteLine("For sorting press anykey"); Console.ReadLine();

MaxSorting(intArray);


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
    Console.WriteLine();
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

void MaxSorting(int[] array){

    int size = array.Length;

    for(int i = 0; i < size - 1; i++){
        for(int j = i + 1; j < size; j++){
            if(array[j] < array[i]){
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }

    PrintArray(array, 15);

}