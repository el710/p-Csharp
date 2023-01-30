

// input
Console.Clear();
Console.WriteLine(">Console input examples...");
Console.Write("input some in console: ");

string user_text = Console.ReadLine() ?? ""; // чтение с проверкой на NULL - и заменой его на "" - пустую строку

Console.WriteLine($"Your input is: {user_text}");

Console.WriteLine("press enter when ready..."); Console.ReadLine();


//---------- get integer 'result' number defined by 'query'
// EX:  if(! GetUserIntNumber(ref lim,"input integer number ")) return;
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