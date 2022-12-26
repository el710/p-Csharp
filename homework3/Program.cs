// homework 3

int userNumber = 0, taskNumber = 0;

Console.Clear();
Console.WriteLine("Hi, I'v got three task for you today: [19, 21, 23]");


if( !GetUserIntNumber(ref taskNumber, "input task number ")){
    Console.WriteLine("Goodbay then...");
    return;
}


if(taskNumber == 19){
    Console.WriteLine($"You choose task {taskNumber}");

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
}
else if(taskNumber == 21){
    Console.WriteLine($"You choose task {taskNumber}");

    int x1=0, y1=0, z1=0, x2=0, y2=0, z2=0;

    if(! GetUserIntNumber(ref x1,"input X of point 1 ")) return;
    if(! GetUserIntNumber(ref y1,"input Y of point 1 ")) return;
    if(! GetUserIntNumber(ref z1,"input Z of point 1 ")) return;

    if(! GetUserIntNumber(ref x2,"input X of point 2 ")) return;
    if(! GetUserIntNumber(ref y2,"input Y of point 2 ")) return;
    if(! GetUserIntNumber(ref z2,"input Z of point 2 ")) return;

    double distance3D = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2) + Math.Pow(z1-z2,2));
    Console.WriteLine($"The distance between [{x1}, {y1}, {z1}] - [{x2}, {y2}, {z2}] = {Math.Round(distance3D,3)}");

}
else if(taskNumber == 23){
    Console.WriteLine($"You choose task {taskNumber}");

    int lim=0;
    
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
}
else Console.WriteLine($"There is no such task: {taskNumber}");

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
