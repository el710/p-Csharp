int lim = 0;

Console.Clear();
Console.WriteLine("Task 23: Make table of power3 for 1 to N numbers");

    if(! GetUserIntNumber(ref lim,"input integer number ")) return;

    Console.SetCursorPosition(0, 5);
    Console.WriteLine("Number: ");
    Console.SetCursorPosition(0, 6);
    Console.WriteLine("Power of 3: ");

    for(int i = 1; i <= lim; i++){
        Console.SetCursorPosition(7+(i*5), 5);
        Console.Write($"{i} ");
        Console.SetCursorPosition(7+(i*5), 6);
        Console.Write($"{Math.Pow(i,3)} ");
    }
    Console.WriteLine();

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
