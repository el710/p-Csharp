﻿// See https://aka.ms/new-console-template for more information

Console.WriteLine("C# world");

//==============================================
// data types
bool boolVar = true; // or false

char charVar = 'c';

string stringVar = "abc";

int intVar = 123;

double doubleVar = 123.123;

Console.WriteLine($"bool variable boolVar = {boolVar} in [true, false]");
Console.WriteLine($"char variable charVar = {charVar} in ['a', 'b', ... ]");
Console.WriteLine($"string variable stringVar = {stringVar} in any text");
Console.WriteLine($"integer variable intVar = {intVar} in [{0x0} .. {0xFFFFFFFF}]");
Console.WriteLine($"double variable doubleVar = {doubleVar}");

Console.WriteLine("press enter when ready..."); Console.ReadLine();