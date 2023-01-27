
//=============================================
// if

bool boolVar;

Console.Clear();
Console.WriteLine("if ...");

Console.Write("Sign in (masha?): ");
string userName = Console.ReadLine() ?? "";

if(userName.ToLower() == "masha") boolVar = true;
else boolVar = false;

if(boolVar){
    Console.WriteLine("Hello Masyanya!");
}
else if(!boolVar){
    Console.WriteLine($"How are you {userName}");
}

Console.WriteLine("press enter when ready..."); Console.ReadLine();

int a = 5;
int b = 10;

int sum = a<b ? a:b;