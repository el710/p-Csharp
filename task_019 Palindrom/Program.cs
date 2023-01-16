int userNumber = 0;

Console.Clear();
Console.WriteLine("Task 19: Recognizing palindrom in user's number");

    if(! GetUserIntNumber(ref userNumber,"input 5-digit number ")) return;
    if(userNumber < 10000 && userNumber > 99999){
        Console.WriteLine($"{userNumber} is not 5-digit number");
        return;
    }   

    int left = userNumber / 10000;
    int right = userNumber % 10;
    if(left != right){
       Console.WriteLine($"{userNumber} is not a palindrom");
    }
    else{
        right = (userNumber / 10) % 1000;

        left = right / 100;
        right = right % 10;
        if(left != right){
            Console.WriteLine($"{userNumber} is not a palindrom");
        }
        else Console.WriteLine($"{userNumber} is a palindrom");
    }

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
