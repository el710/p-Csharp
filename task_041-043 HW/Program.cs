//--------------------------------------
Console.Clear();
Console.WriteLine("HW task 43: find cross point for two lines ");
 
double[] line1 = DefineLine();
Console.WriteLine($"Line 1: y = {line1[0]}x + {line1[1]}");
double[] line2 = DefineLine();
Console.WriteLine($"Line 2: y = {line2[0]}x + {line2[1]}");

double[] point = GetCrossPoint(line1, line2);
if(point != null){
    Console.WriteLine($"Cross point (x, y): ({point[0]}, {point[1]})");
}else {
    Console.WriteLine($"These lines don't cross");
}

Console.WriteLine("Task 43: done. Press Enter to continue..."); Console.ReadLine();


//=====================================
double[] GetCrossPoint(double[] lineSet1, double[] lineSet2){

    if(lineSet1[0] == lineSet2[0]) return null;

    double[] point = new double[]{0, 0};
    
    //for Y = a1X +b1 and Y = a2X + b2;
    // cross point is:
    // y = (b2 * a1) / (a1 - a2)
    // x = y - b1 / a1
    
    point[1] = (lineSet2[1] * lineSet1[0]) / (lineSet1[0] - lineSet2[0]) - 
               (lineSet2[0] * lineSet1[1]) / (lineSet1[0] - lineSet2[0]);
    point[0] = (point[1] - lineSet1[1]) / lineSet1[0];

    return point;
}


//=====================================
double[] DefineLine(){
    double userNumber = 0.0;
    double[] set = new double[2];

    Console.WriteLine($"For line: y = ax + b ");
    if(! GetUserDoubleNumber(ref userNumber,"input 'a'")) userNumber = 0; 
    set[0] = userNumber;
    if(! GetUserDoubleNumber(ref userNumber,"input 'b'")) userNumber = 0; 
    set[1] = userNumber;
        
    return set;
}

//====================================================
bool GetUserDoubleNumber(ref double result, string query){
   
    string text;

    Console.Write($"{query}: ");
    text = Console.ReadLine() ?? "";

    try{
            result = Convert.ToDouble(text);
            return true;
    }
    catch{}       
    
    return false;
} 


/*/------------------------------------------
Console.Clear();
Console.WriteLine("HW task 41: control of user's numbers > 0 ");
int length = 0;

if(! GetUserIntNumber(ref length,"input size of array ")) return;
if(length > 0){
    int[] array = InitArray(length);
    Console.WriteLine($"There are {GetPositiveCount(array)} number '> 0' in array");
}

Console.WriteLine("Task 41: done. ");
/**/

//=========================================
int GetPositiveCount(int[] set){
    int positiveCount = 0;
    foreach(int item in set){
        if(item > 0) positiveCount++;
    }
    return positiveCount;
}

//=========================================
int[] InitArray(int size){

    int[] set = new int[size];

    int userNumber = 0;
    int count = 0;
    
    while(true){
        Console.Clear();
        Console.WriteLine($" Array[{size}] = [ {String.Join(',', set)} ]");

        if(count == size)  return set;

        if(GetUserIntNumber(ref userNumber,"input item number ")){
            set[count] = userNumber; 
            count++;
        } else return set;    
    }
}


//====================================================
bool GetUserIntNumber(ref int result, string query){
   
    string text;

    Console.Write($"{query}< ");
    text = Console.ReadLine() ?? "";

    try{
            result = Convert.ToInt32(text);
            Console.WriteLine();
            return true;
    }
    catch{}       
    
    return false;
} 
