int userNumber = 0;

Console.Clear();
Console.WriteLine("Task 19: Find distance between two 3d points");

    int x1=0, y1=0, z1=0, x2=0, y2=0, z2=0;

    if(! GetUserIntNumber(ref x1,"input X of point 1 ")) return;
    if(! GetUserIntNumber(ref y1,"input Y of point 1 ")) return;
    if(! GetUserIntNumber(ref z1,"input Z of point 1 ")) return;

    if(! GetUserIntNumber(ref x2,"input X of point 2 ")) return;
    if(! GetUserIntNumber(ref y2,"input Y of point 2 ")) return;
    if(! GetUserIntNumber(ref z2,"input Z of point 2 ")) return;

    double distance3D = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2) + Math.Pow(z1-z2,2));
    Console.WriteLine($"The distance between [{x1}, {y1}, {z1}] - [{x2}, {y2}, {z2}] = {Math.Round(distance3D,3)}");

Console.WriteLine($"That is all folks");


//============== implementation of methods

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
