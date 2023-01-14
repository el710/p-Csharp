

// input
Console.Clear();
Console.WriteLine(">Console input examples...");
Console.Write("input some in console: ");

string user_text = Console.ReadLine() ?? ""; // чтение с проверкой на NULL - и заменой его на "" - пустую строку

Console.WriteLine($"Your input is: {user_text}");

Console.WriteLine("press enter when ready..."); Console.ReadLine();