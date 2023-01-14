//==============================================
// try...catch

int intVar;

Console.Clear();

Console.WriteLine("try catch example...");
Console.Write("input any number: ");
try{
    intVar = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Convert succed: {intVar}");
}
catch(Exception exc){
        Console.WriteLine($"Error input: {exc.Message}");
}


Console.WriteLine("Press enter for continue..."); Console.ReadLine();