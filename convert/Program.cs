//=============================================
// data type conversion

double doubleVar;
string stringVar;
int intVar;


Console.Clear();

Console.WriteLine("data type conversion examples...");

Console.Write("input double number in console: ");
stringVar = Console.ReadLine() ?? "";
doubleVar = double.Parse(stringVar); // string to number
Console.WriteLine($"Convert text to real number: {doubleVar}");

intVar = (int)doubleVar;  // real type to integer type
Console.WriteLine($"Convert real to integer: {intVar}");

Console.Write("input integer number (try Convert...): ");
intVar = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Convert text to integer number: {intVar}");

stringVar = $"{intVar}";
Console.WriteLine($"Convert integer to text: {intVar} became a string {stringVar}");

stringVar = "dsfdsd"; 
stringVar = stringVar.ToUpper();
Console.WriteLine($"Convert text to UpCase: {stringVar}");


Console.WriteLine("press enter when ready..."); Console.ReadLine();
