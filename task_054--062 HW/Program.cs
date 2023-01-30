/*/---------------------------------------
Console.Clear();
Console.WriteLine("Task ....");

Console.WriteLine("Task   done. Press <Enter> to continue..."); Console.ReadLine();
/**/
//========================================

//---------------------------------------
Console.Clear();
Console.WriteLine("Task 62: Fill 4x4 matrix by spiral way");

int[,] matrix62 = new int[4, 4];

FillMatrixbySpiral(matrix62);

PrintInt2DArray(matrix62);

Console.WriteLine("Task 62 done. Press <Enter> to continue..."); Console.ReadLine();
/**/
//========================================
void FillMatrixbySpiral(int[,] matrix){
    int item = 1;
    int row = 0;
    int col = 0; 
    int way = 0;

    while( item < (matrix.GetLength(0) * matrix.GetLength(1)) ){

        if(way == 1 ){
            if( (col+1) < matrix.GetLength(1) && matrix[row, col+1] == 0 ){
                col++;
            }else way = 2;
        }     

        if(way == 2){
            if( (row+1) < matrix.GetLength(0) && matrix[row+1, col] == 0) {
                 row++;
            } else way = 3;
        }    

        if(way == 3){
            if( (col-1) >=0 && matrix[row, col-1] == 0 ){
                col--;
            }else way = 4;
        }

        if(way == 4){
            if( (row-1) >= 0 && matrix[row-1, col] == 0) {
                row--;
            }else { way = 0; }
        }    

        if(way == 0) way = 1;
        else item++;

        matrix[row, col] = item;
    }
}

//---------------------------------------
Console.Clear();
Console.WriteLine("Task 60: Make and print 3D array with uniq elements");

int[,,] array3D = Make3DArray(3, 3, 3);

Print3DArrayInt(array3D);
 
Console.WriteLine("Task 60 done. Press <Enter> to continue..."); Console.ReadLine();
/**/
//========================================
void Print3DArrayInt(int[,,] cube){
    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int d = 0; d < cube.GetLength(2); d++)
            {
                Console.Write($"{cube[i, j, d]}({i},{j},{d}) ");
            }
        }
        Console.WriteLine("");
    }
}

int[,,] Make3DArray(int rows, int cols, int dims){
    int[,,] cube = new int[rows, cols, dims];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            for (int d = 0; d < dims; d++)
            {
                cube[i, j, d] = new Random().Next(10, 100);
            }
        }
    }

    return cube;
}


//---------------------------------------
Console.Clear();
Console.WriteLine("Task 58: Prodact of matrixes");

int[,] matrixA = InitInt2DArray(3, 3, 0, 10);
Console.WriteLine("---------- Matrix A:");
PrintInt2DArray(matrixA);

int[,] matrixB = InitInt2DArray(3, 3, 0, 10);
Console.WriteLine("---------- Matrix B:");
PrintInt2DArray(matrixB);

int[,] matrixC = MultiplyMatrix(matrixA, matrixB);
Console.WriteLine("---------- A * B:");
PrintInt2DArray(matrixC);

Console.WriteLine("Task 58 done. Press <Enter> to continue..."); Console.ReadLine();
/**/
int[,] MultiplyMatrix(int[,] matrixA, int[,] matrixB){

    int[,] matrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for(int row = 0; row < matrixA.GetLength(0); row++){
        for (int col = 0; col < matrixB.GetLength(1); col++){
            for(int k = 0; k < matrixA.GetLength(1); k++){
                matrix[row, col] += matrixA[row, k] * matrixB[k, col]; 
            }
        }
    }
    return matrix;
}

//---------------------------------------
Console.Clear();
Console.WriteLine("Task 56: Find row with minimum sum of elements");

int userSize = 0;
if(!GetUserIntNumber(ref userSize, "input size of matrix")) return;
int[,] matrix56 = InitInt2DArray(userSize, userSize, 0, 10);
PrintInt2DArray(matrix56);

FindMininumRow(matrix56);

Console.WriteLine("Task 56 done. Press <Enter> to continue..."); Console.ReadLine();
/**/
//========================================
void FindMininumRow(int[,] matrix){
    int minRow = 0;
    int minSum = 0;
    int sum = 0;

    for(int i = 0; i < matrix.GetLength(0); i++){
        
        sum = 0;
        for(int j = 0; j < matrix.GetLength(1); j++){
            sum += matrix[i, j];
        }

        if(i == 0 ){
            minSum = sum;
        }
        else if(sum < minSum){
            minSum = sum;
            minRow = i;
        }
    }

    Console.WriteLine($"Row {minRow+1} has minimum sum = {minSum}");
}

//---------------------------------------
Console.Clear();
Console.WriteLine("Task 54: Sorting to Minimum in rows of random matrix");

int userRows = 0;
int userCols = 0;
if(!GetUserIntNumber(ref userRows, "input number of rows")) return;
if(!GetUserIntNumber(ref userCols, "input number of columns")) return;
int[,] matrix54 = InitInt2DArray(userRows, userCols, 0, 100);
PrintInt2DArray(matrix54);

MinSortingRows(matrix54);
Console.WriteLine("After Min sorting rows: ");
PrintInt2DArray(matrix54);

Console.WriteLine("Task 54 done. Press <Enter> to continue..."); Console.ReadLine();
/**/
//========================================
void MinSortingRows(int[,] array){
    int size = array.GetLength(1);

    for(int r = 0; r < array.GetLength(0); r++){
       for(int i = 0; i < size - 1; i++){
            for(int j = i + 1; j < size; j++){
                if(array[r, j] > array[r, i]){
                    int temp = array[r, i];
                    array[r, i] = array[r, j];
                    array[r, j] = temp;
                }
            }
        }
    }
}

void PrintInt2DArray(int[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    } 
}

int[,] InitInt2DArray(int rows, int cols, int randMin, int randMax){
    int[,] matrix = new int[rows, cols];
    for(int i = 0; i < rows; i++){
        for(int j = 0; j < cols; j++){
            matrix[i, j] = new Random().Next(randMin, randMax + 1);
        }
    }
    return matrix;
}

bool GetUserIntNumber(ref int result, string query){

    int times = 5;
    string text;

    while(times > 0){

        Console.Write($"{query}< ");
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