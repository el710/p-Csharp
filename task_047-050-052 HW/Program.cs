//--------------------------------------
Console.Clear();
Console.WriteLine("HW task 52 : Find average in cols of 2D array ");

int[,] matrix52 = InitInt2DArray(5, 5, 0, 20);
PrintInt2DArray(matrix52, 1);
Console.WriteLine("-------------- averages ---------------");
GetColsAverage(matrix52);

Console.WriteLine("Task 52: done. Press Enter to continue..."); Console.ReadLine();
/**/

//===============================================
void GetColsAverage(int[,] matrix){
    double sum = 0;

    for(int j = 0; j < matrix.GetLength(1); j++){
        for(int i = 0; i < matrix.GetLength(0); i++){
            sum += matrix[i, j];
        }
       
        Console.Write($" {Math.Round(sum / matrix.GetLength(1), 2, MidpointRounding.ToEven)}  ");
        sum = 0;
    } 
    Console.WriteLine();
}

//===============================================
void PrintInt2DArray(int[,] matrix, int row){
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            Console.SetCursorPosition((j*8), row + i);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine("");
    } 
}

//===============================================
int[,] InitInt2DArray(int rows, int cols, int randMin, int randMax){
    int[,] matrix = new int[rows, cols];
    for(int i = 0; i < rows; i++){
        for(int j = 0; j < cols; j++){
            matrix[i, j] = new Random().Next(randMin, randMax + 1);
        }
    }
    return matrix;
}


//--------------------------------------
Console.Clear();
Console.WriteLine("HW task 50 : find 2D array item by indexes ");
int userRow = 0;
int userCol = 0;
if(!GetUserIntNumber(ref userRow, "input index of row [0..]")) return;
if(!GetUserIntNumber(ref userCol, "input index of column [0..]")) return;

double[,] matrix50 = Init2DArrayReal(5, 5, -10, 10);

FindItem(matrix50, userRow, userCol);

Print2DArrayReal(matrix50);

Console.WriteLine("Task 50: done. Press Enter to continue..."); Console.ReadLine();
/**/
//========================================
void FindItem(double[,] set, int row, int col){
    if(row < set.GetLength(0) && col < set.GetLength(1)){
      Console.WriteLine($"item[{row}, {col}] = {Math.Round(set[row, col], 3, MidpointRounding.ToEven)}");  
    }
    else Console.WriteLine($"item[{row}, {col}] not exists");
}

//--------------------------------------
Console.Clear();
Console.WriteLine("HW task 47 : Initialization of 2D array with real numbers ");

int userRows = 0;
int userCols = 0;
if(!GetUserIntNumber(ref userRows, "input number of rows")) return;
if(!GetUserIntNumber(ref userCols, "input number of columns")) return;

double[,] matrix = Init2DArrayReal(userRows, userCols, -10, 10);
Print2DArrayReal(matrix);

Console.WriteLine("Task 47: done. Press Enter"); Console.ReadLine();
/**/

//=====================================================
void Print2DArrayReal(double[,] set){
    for(int i = 0; i < set.GetLength(0); i++){
        for(int j = 0; j < set.GetLength(1); j++){
            if(set[i,j] > 0) Console.Write(" ");
            Console.Write($"{Math.Round(set[i,j], 3, MidpointRounding.ToEven)}   ");
        } 
        Console.WriteLine("");     
    }
}

//==================================
double[,] Init2DArrayReal(int rows, int cols, int randMin, int randMax){
    int baseNumber = 0;
    double partNumber = 0.0;

    double[,] matrix = new double[rows, cols];

    for(int i = 0; i < rows; i++){
        for(int j = 0; j < cols; j++){

            baseNumber = new Random().Next(randMin, randMax + 1);
            partNumber = new Random().NextDouble();
            matrix[i, j] = baseNumber + partNumber; 
        }
    }
    return matrix;
}

//======================================
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