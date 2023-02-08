int int_num_var = 100;
double real_num_var = 100.5;
string text_var = "C Sharp World ";


// output
Console.Clear();
Console.WriteLine(">Console output examples...");
Console.Write(text_var);
Console.WriteLine(" man...");
Console.WriteLine($"{int_num_var} ... {real_num_var}");

Console.WriteLine("press enter when ready..."); Console.ReadLine();

Console.Clear();
Random r = new Random();
Console.CursorVisible = false;
while(true){

    Console.SetCursorPosition(
        left: r.Next(Console.WindowWidth),
        top: r.Next(Console.WindowHeight)
    );
    Console.Write(r.Next(10));
    Thread.Sleep(10);
}

